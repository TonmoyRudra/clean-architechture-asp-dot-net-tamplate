namespace API.Dtos
{
    public class UserToReturnDto
    {
        public string LogUserID { get; set; }
        public decimal BMUserId { get; set; }
        public decimal? HrEmpId { get; set; }
        public int AppId { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }
        public string[] Roles { get; set; }
        public int[] RoleIds { get; set; }
        public List<UserMenu> UserMenus { get; set; }
        public List<MenuItem> Menus { get; set; }
    }

    public class UserMenu
    { 
        public string Text { get; set; } 
        public string Path { get; set; } 
        public string Icon { get; set; } 
    }

    public class Menu
    {
        public long Id { get; set; }
        public string Text { get; set; }
        public string Path { get; set; }
        public string Icon { get; set; }
        public List<MenuItem> Items { get; set; }
    }

    public class MenuItem
    {
        public string Id { get; set; }
        public string Text { get; set; }
        public string Icon { get; set; }
        public string Type { get; set; }
        public string MENUSHORTNAME { get; set; }
        public string MENUTOOLTIP { get; set; }
        public string MENUDESCHELP { get; set; }
        public string ROUTE_NAME { get; set; }
        public int CANINSERT { get; set; }
        public int CANDELETE { get; set; }
        public int CANUPDATE { get; set; }
        public string AppRouteName { get; set; }
        public string MenuGroupRouteName { get; set; }
        public string Path { get; set; }
        public bool expanded { get; set; }
        public long? SerialNo { get; set; }
        public List<MenuItem> Items { get; set; }
    }
}
