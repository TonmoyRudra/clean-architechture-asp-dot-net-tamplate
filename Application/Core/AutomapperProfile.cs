using Application.Dtos;
using AutoMapper;
using Domain;

namespace Application.Core
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            // CreateMap<TaxCarEntitlement, UserCarEntitlementDto>()
            //     .ForMember(d => d.UserName, o => o.MapFrom(s =>
            //         s.BMSecUser.UserName));


            // CreateMap<UserCarEntitlementDto, TaxCarEntitlement>();
            //     //.ForMember(dest=>dest.EntitledFrom, o => o.MapFrom(src=>DateTime.Parse(src.EntitledFrom)));


            // CreateMap<TaxCertificateView, TaxCertificateReportDataSet>();


            // //
            // CreateMap<TaxManualCalculatedAmount, UserTaxManualCalculatedAmountDto>()
            //     .ForMember(d => d.PayItemName, o => o.MapFrom(s =>s.TaxPayItem.TaxPayItemName))
            //     .ForMember(d => d.UserName, o => o.MapFrom(s =>s.BMSecUser.UserName));


            // CreateMap<TaxAllowanceSetup, AllowanceSetupDto>()
            //    .ForMember(d => d.FYName, o => o.MapFrom(s => s.TaxFinancialYear.FY_Title));

            // CreateMap<TaxChallanWPPFMaster, TaxChallanWPPFMasterDto>()
            //   .ForMember(d => d.FYName, o => o.MapFrom(s => s.TaxFinancialYear.FY_Title));


            CreateMap<HrEmployee, HrEmployeeView>()
                .ForMember(dest => dest.EmpID, o => o.MapFrom(src => src.HR_EmployeeID))
                .ForMember(dest => dest.EmployeeName, o => o.MapFrom(src => src.HR_EmployeeName));

            // CreateMap<TaxCertificateView, NonMgtEmployeeView>()
            //     .ForMember(dest => dest.EmpID, o => o.MapFrom(src => src.HR_EmployeeID))
            //     .ForMember(dest => dest.ETIN, o => o.MapFrom(src => src.ETIN))
            //     .ForMember(dest => dest.EmployeeName, o => o.MapFrom(src => src.HR_EmployeeName));


            // CreateMap<TaxExcludeFromAutoUpdatePayroll, ExcludeToPayrollEmployeeView>()
            //.ForMember(dest => dest.EmpID, o => o.MapFrom(src => src.EmpID))
            //.ForMember(dest => dest.ETIN, o => o.MapFrom(src => src.HrEmployee.eTIN))
            //.ForMember(dest => dest.EmployeeName, o => o.MapFrom(src => src.HrEmployee.HR_EmployeeName));


            // CreateMap<BMConcurrentRequest, BMConcurrentRequestVM>();


            //CreateMap<UserTaxManualCalculatedAmountDto, TaxManualCalculatedAmount>();
        }
    }
}
