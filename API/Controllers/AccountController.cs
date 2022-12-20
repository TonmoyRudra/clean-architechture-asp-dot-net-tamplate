using API.Dtos;
using Application.Dtos;
using Application.Interfaces;
using AutoMapper;
using Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Security.Claims;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAuthService _authService;
        private readonly ITokenService _tokenService;
        private readonly IMapper _mapper;
        private readonly IReposotory<UM_MENU_ACCESS_V> _menuRepo;

        public AccountController(IAuthService authService,ITokenService tokenService, IMapper mapper, IReposotory<UM_MENU_ACCESS_V> menuRepo)
        {
            _authService = authService;
            _tokenService = tokenService;
            _mapper = mapper;
            _menuRepo = menuRepo;
        }

        [HttpPost("login")]
        public async Task<ActionResult<UserToReturnDto>> Login(LoginDto loginDto)
        {
            var LoginSecurityString = await _authService.CheckLoginAttemps(loginDto.UserName.ToLower(), loginDto.Password);
            if (!string.IsNullOrEmpty(LoginSecurityString))
            {
                return BadRequest(LoginSecurityString);
            }

            var userToLogin = await _authService.Login(loginDto.UserName.ToLower(), loginDto.Password);

            if (userToLogin == null)
                return Unauthorized("Invalid Password");

            var userRoles = await _authService.GetRolesAsync(Convert.ToInt64(userToLogin.BM_UserID));

            var userMenus = _menuRepo.FindListAllAsync(x => x.LOOKUP_ID == 18 && x.USERID == userToLogin.BM_UserID).ToList();


            //var allData = (from ma in db.UM_MENU_ACCESS_V
            //               where ma.USERID == uid && ma.RSPID == rspid
            //               orderby ma.MGSERIALNO
            //               select ma).ToList();

            var allData = _menuRepo.FindListAllAsync(x=>x.LOOKUP_ID == 18).ToList();

            var applications = (from a in allData
                                select new
                                {
                                    a.APP_NAME,
                                    a.LOOKUP_ID,
                                    id = a.LOOKUP_ID,
                                    text = a.APP_NAME,
                                    a.APP_SHORTCODE,
                                    APP_ID = a.LOOKUP_ID,
                                    a.APP_ICONNAME
                                }).Distinct().ToList();

            var menuGroups = (from mg in allData
                              select new
                              {
                                  mg.MGID,
                                  id = mg.MGID,
                                  text = mg.MGNAME,
                                  mg.MGRUOUTENAME,
                                  mg.SHORTCODE_MG,
                                  mg.MGTOOLTIP,
                                  mg.ICONNAME_MG,
                                  mg.LOOKUP_ID,
                              }).Distinct().ToList();
           
            var menus = (from m in allData
                         select new
                         {
                             m.MID,
                             id = m.MID,
                             m.ROUTINGNAME,
                             text = m.MENUNAME,
                             m.MENUSHORTNAME,
                             m.MENUTOOLTIP,
                             m.MENUDESCHELP,
                             m.MGID,
                             m.LOOKUP_ID,
                             m.CANINSERT,
                             m.CANUPDATE,
                             m.CANDELETE
                         }).Distinct().ToList();





            var menuTree = (from mg in menuGroups
                            select new MenuItem
                            {
                                Id = "_" + mg.id,
                                Text = mg.text,
                                ROUTE_NAME = mg.MGRUOUTENAME,
                                AppRouteName = mg.SHORTCODE_MG,
                                MENUTOOLTIP = mg.MGTOOLTIP,
                                Icon = mg.ICONNAME_MG,
                                expanded = false,
                                Items = (from m in menus
                                         where m.MGID == mg.MGID
                                         select new MenuItem
                                         {
                                             Id = mg.id + "_" + m.id,
                                             Text = m.text,
                                             Type = "MENU",
                                             MENUSHORTNAME = m.MENUSHORTNAME,
                                             MENUTOOLTIP = m.MENUTOOLTIP,
                                             MENUDESCHELP = m.MENUDESCHELP,
                                             ROUTE_NAME = "/" + mg.MGRUOUTENAME + "/" + m.ROUTINGNAME,
                                             CANINSERT = m.CANINSERT,
                                             CANDELETE = m.CANDELETE,
                                             CANUPDATE = m.CANUPDATE,
                                             MenuGroupRouteName = mg.MGRUOUTENAME,
                                             Path = m.ROUTINGNAME,
                                             expanded = false
                                         }).ToList()
                            }).ToList();

            var data = new UserToReturnDto
            {
                Email = userToLogin.Email,
                BMUserId = userToLogin.BM_UserID,
                HrEmpId= userToLogin.HR_EmployeeID,
                AppId = 18,//app lookup id
                LogUserID = userToLogin.LogUserID,
                Token = _tokenService.GenerateToken(userToLogin, userRoles.Select(x=>x.RSPID.ToString()).ToList()),
                Roles = userRoles.Select(x=>x.RSPID.ToString()).ToArray(),
                UserMenus = userMenus.Select(x=>new UserMenu { Text = x.MENUNAME, Path=x.ROUTINGNAME, Icon=x.ICONNAME}).ToList(),
                Menus = menuTree
            };

            var email = HttpContext.User?.Claims.Count() > 0 ? HttpContext.User?.Claims?.FirstOrDefault(x => x.Type == ClaimTypes.GivenName).Value : "";

            var cookieOptions = new CookieOptions
            {
                HttpOnly = true,
                Expires = DateTime.UtcNow.AddDays(7)
            };

            Response.Cookies.Append("token", data.Token, cookieOptions);

            return Ok(data);
        }

        [HttpGet("GetRouteResp")]
        public IActionResult GetRouteResponsibility([FromQuery]string routeName)
        {
            var result = _menuRepo.FindListAllAsync(x=>x.ROUTINGNAME == routeName && x.LOOKUP_ID == 18).Select(x=>x.RSPID).Distinct().ToList();

            return Ok(result);
        }


        [HttpGet]
        public async Task<ActionResult<UserToReturnDto>> GetCurrentUserAsync(string userId)
        {
            var email = HttpContext.User?.Claims.Count() > 0 ? HttpContext.User?.Claims?.FirstOrDefault(x => x.Type == ClaimTypes.GivenName).Value : userId;

            //var claims = ClaimsPrincipal.Current.Identities.First().Claims.ToList();

            var user = await _authService.FindByEmailAsync(email);

            if (user == null) return BadRequest("User not found");

            var userRoles = _authService.GetRolesAsync(Convert.ToInt64(user.BM_UserID)).Result;

            var userMenus = _menuRepo.FindListAllAsync(x => x.LOOKUP_ID == 18 && x.USERID == user.BM_UserID);
            var allData = _menuRepo.FindListAllAsync(x => x.LOOKUP_ID == 18 && x.USERID == user.BM_UserID).ToList();

            var applications = (from a in allData
                                select new
                                {
                                    a.APP_NAME,
                                    a.LOOKUP_ID,
                                    id = a.LOOKUP_ID,
                                    text = a.APP_NAME,
                                    a.APP_SHORTCODE,
                                    APP_ID = a.LOOKUP_ID,
                                    a.APP_ICONNAME
                                }).Distinct().ToList();

            var menuGroups = (from mg in allData
                              select new
                              {
                                  mg.MGID,
                                  id = mg.MGID,
                                  text = mg.MGNAME,
                                  mg.MGRUOUTENAME,
                                  mg.SHORTCODE_MG,
                                  mg.MGTOOLTIP,
                                  mg.ICONNAME_MG,
                                  mg.LOOKUP_ID,
                              }).Distinct().ToList();

            var menus = (from m in allData
                         select new
                         {
                             m.MID,
                             id = m.MID,
                             m.ROUTINGNAME,
                             text = m.MENUNAME,
                             m.MENUSHORTNAME,
                             m.MENUTOOLTIP,
                             m.MENUDESCHELP,
                             m.MGID,
                             m.LOOKUP_ID,
                             m.CANINSERT,
                             m.CANUPDATE,
                             m.CANDELETE,
                             m.SERIAL_NO
                         }).Distinct().ToList();





            var menuTree = (from mg in menuGroups
                            select new MenuItem
                            {
                                Id = "_" + mg.id,
                                Text = mg.text,
                                ROUTE_NAME = mg.MGRUOUTENAME,
                                AppRouteName = mg.SHORTCODE_MG,
                                MENUTOOLTIP = mg.MGTOOLTIP,
                                Icon = mg.ICONNAME_MG,
                                expanded = false,
                                Items = (from m in menus
                                         where m.MGID == mg.MGID
                                         select new MenuItem
                                         {
                                             Id = mg.id + "_" + m.id,
                                             Text = m.text,
                                             Type = "MENU",
                                             MENUSHORTNAME = m.MENUSHORTNAME,
                                             MENUTOOLTIP = m.MENUTOOLTIP,
                                             MENUDESCHELP = m.MENUDESCHELP,
                                             ROUTE_NAME = "/" + mg.MGRUOUTENAME + "/" + m.ROUTINGNAME,
                                             CANINSERT = m.CANINSERT,
                                             CANDELETE = m.CANDELETE,
                                             CANUPDATE = m.CANUPDATE,
                                             MenuGroupRouteName = mg.MGRUOUTENAME,
                                             Path = m.ROUTINGNAME,
                                             expanded = false,
                                             SerialNo = m.SERIAL_NO
                                         }).OrderBy(x => x.SerialNo).ToList()
                            }).ToList();

            return new UserToReturnDto
            {
                Email = user.Email,
                BMUserId = user.BM_UserID,
                HrEmpId = user.HR_EmployeeID,
                AppId = 18,//app lookup id
                LogUserID = user.LogUserID,
                Token = _tokenService.GenerateToken(user, userRoles.Select(x=>x.RSPID.ToString()).ToList()),
                Roles = userRoles.Select(x=>x.RSPID.ToString()).ToArray(),
                UserMenus = userMenus.Select(x => new UserMenu { Text = x.MENUNAME, Path = x.ROUTINGNAME, Icon = x.ICONNAME }).ToList(),
                Menus = menuTree
            };
        }

        [HttpGet("hr-employee")]
        [Authorize]
        public async Task<ActionResult<List<HrEmployeeView>>> GetHrEmployee()
        {
            var userId = Convert.ToDecimal(HttpContext.User.FindFirst(x => x.Type == ClaimTypes.GivenName).Value);


            var list = await _authService.GetAllEmployee(userId);

            var toReturn =  _mapper.Map<List<HrEmployee>,List<HrEmployeeView>>(list);


            return Ok(toReturn);
        }


    }
}
