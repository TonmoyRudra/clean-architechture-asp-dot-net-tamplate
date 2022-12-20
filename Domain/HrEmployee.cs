using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class HrEmployee
    {
        public decimal HR_EmployeeID { get; set; }

        public int BM_BranchID { get; set; }

        public string HR_EmployeeName { get; set; }

        public decimal? Under_Acc_HeadFirstLvlName { get; set; }

        public string Address { get; set; }

        public string Phone1 { get; set; }

        public string Phone2 { get; set; }

        public string MobileNo { get; set; }

        public DateTime? JoinDate { get; set; }

        public string Mgr { get; set; }

        public bool? Active { get; set; }

        public string Email { get; set; }

        public int? HR_DeptID { get; set; }

        public int? HR_DesgID { get; set; }

        public decimal? BasicSalary { get; set; }

        public string Password { get; set; }

        public string ConfirmPassword { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? LastUpdateDate { get; set; }

        public byte? Flag { get; set; }

        public string Village { get; set; }

        public string PO { get; set; }

        public string PS { get; set; }

        public string District { get; set; }

        public decimal? UnderHR_EmployeeID { get; set; }

        public decimal? UnderHR_EmployeeIDLast { get; set; }

        public string Alias { get; set; }

        public string Father_HushandName { get; set; }

        public string MotherName { get; set; }

        public string DateOfBirthV { get; set; }

        public int? NationalityInv_CountryID { get; set; }

        public int? RelagionBM_ItemID { get; set; }

        public string PresentMailAddress { get; set; }

        public string Comments { get; set; }

        public string ProfessionalQualification { get; set; }

        public string TrainingInBrief { get; set; }

        public string ExtraCurricularActivities { get; set; }

        public string MaritalStatus { get; set; }

        public int? MaritalStatusBM_ItemID { get; set; }

        public int? SpeakFluencyInLanInv_CountryID { get; set; }

        public int? SpeakFluencyPerfoBM_ItemID { get; set; }

        public DateTime? ApplicationDate { get; set; }

        public string PicturePath { get; set; }

        public DateTime? DateOfJoining { get; set; }

        public DateTime? ConfirmationDate { get; set; }

        public DateTime? ConfirmationDateApprox { get; set; }

        public DateTime? RetireDateApproximate { get; set; }

        public string CauseOfSeparation { get; set; }

        public int? CauseOfSeparationBM_ItemID { get; set; }

        public DateTime? RetireDateActual { get; set; }

        public bool? Inactive { get; set; }

        public int? GrandeBM_ItemIDUsers { get; set; }

        public int? AppStatusBM_ItemIDUsers { get; set; }

        public int? MinimumDaysOfConfirmation { get; set; }

        public string SpouseName { get; set; }

        public DateTime? ContractualDateFrom { get; set; }

        public DateTime? ContractualDateTo { get; set; }

        public int? BloodBM_ItemID { get; set; }

        public int? PlaceOfPostingBM_ItemIDUsers { get; set; }

        public decimal? TotalPayableAmount { get; set; }

        public decimal? FinalPayment { get; set; }

        public decimal? ForfeitureAC { get; set; }

        public decimal? ClosingBalance { get; set; }

        public decimal? Rtd { get; set; }

        public bool? ProcessForLPR { get; set; }

        public string LPRPaymentID { get; set; }

        public decimal? Acc_BankID { get; set; }

        public decimal? Acc_ForfeitureAccountID { get; set; }

        public string PassportNo { get; set; }

        public string VoterIDNo { get; set; }

        public decimal? ReportToHR_EmployeeID { get; set; }

        public decimal? SalaryAccountAcc_BankID { get; set; }

        public string BankAccountNo { get; set; }

        public int? EmployeeFileLocationBM_ItemIDUsers { get; set; }

        public decimal? Acc_RetiredMembersAccountID { get; set; }

        public decimal? SalarySheetSerialNo { get; set; }

        public int? CorporateTitleBM_ItemIDUsers { get; set; }

        public int? GenderBM_ItemID { get; set; }

        public int? DistrictBM_ItemIDUsers { get; set; }

        public bool? GratuatyEnable { get; set; }

        public int? GratuatyAfterYear { get; set; }

        public int? SalaryScaleBM_ItemIDUsers { get; set; }

        public string Extension { get; set; }

        public string PictureNameForWeb { get; set; }

        public string PersonalEmail { get; set; }

        public string Nominee { get; set; }

        public string Languages { get; set; }

        public string EmpCode { get; set; }

        public decimal? DottedLineHR_EmployeeID { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public decimal? EBS_CostCenterID { get; set; }

        public string EBS_EmployeeCode { get; set; }

        public decimal? EBS_LocationID { get; set; }

        public double? MobileLimit { get; set; }

        public double? InternetLimit { get; set; }

        public string MobileBillType { get; set; }

        public string InternetBillType { get; set; }

        public int? InternetOperatorBM_ItemID { get; set; }

        public int? JobLevelBM_ItemIDUsers { get; set; }

        public string eTIN { get; set; }

        public string CardNo { get; set; }

        public bool? HoldSalary { get; set; }

        public string HoldSalaryReason { get; set; }

        public string Currency { get; set; }

        public decimal? FunctionalLevelBM_ItemID { get; set; }

        public string WPPF_EligibleAs { get; set; }

        public int? HR_BandID { get; set; }

        public int? HR_GradeID { get; set; }

        public decimal? ReportTo2_EmployeeID { get; set; }

        public decimal? DottedLine2_EmployeeID { get; set; }

        public decimal? AdditionalReportTo1_EmployeeID { get; set; }

        public decimal? AdditionalReportTo2_EmployeeID { get; set; }

        public decimal? HRRoleId { get; set; }

        public decimal? HRMappedRoleId { get; set; }

        public decimal? SF_ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string sap_bu_code { get; set; }

        public string sap_func_code { get; set; }

        public string sap_subFunc_code { get; set; }

        public string sap_area_code { get; set; }

        public string sap_subArea_code { get; set; }

        public string sap_support_code { get; set; }

        public DateTime? suspensionDate { get; set; }

        public int? NoBonus { get; set; }
        //public TaxExcludeFromAutoUpdatePayroll TaxExcludeFromAutoUpdatePayroll { get; set; }
    }
}
