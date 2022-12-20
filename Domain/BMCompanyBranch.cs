using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class BMCompanyBranch
    {
        public int? BM_CompanyID { get; set; }

        public int BM_BranchID { get; set; }

        public string BM_BranchName2 { get; set; }

        public string BM_BranchName1 { get; set; }

        public string BM_BranchName { get; set; }

        public string BM_BranchName_0 { get; set; }

        public string BM_BranchName_1 { get; set; }

        public string BM_BranchName_2 { get; set; }

        public string BM_BranchName_3 { get; set; }

        public string BM_BranchName_4 { get; set; }

        public string BranchLocation { get; set; }

        public string Phone1 { get; set; }

        public string Phone2 { get; set; }

        public string Phone3 { get; set; }

        public string Fax { get; set; }

        public string Email { get; set; }

        public bool? TreatHeadOffice { get; set; }

        public bool? TreatCurrentBranch { get; set; }

        public decimal? Manager_HR_EmployeeID { get; set; }

        public bool? ActiveStatus { get; set; }

        public string RegistrationNo { get; set; }

        public decimal? VATForHirePurchase { get; set; }

        public decimal? VATForGeneralSales { get; set; }

        public decimal? VATForShowroom { get; set; }

        public decimal? VATForPurchase { get; set; }

        public bool? AllowStockValueWAVGPeriodical { get; set; }

        public bool? AllowStockValueWAVGPerpetual { get; set; }

        public bool? AllowStockValueFIFO { get; set; }

        public bool? AllowStockValueLIFO { get; set; }

        public DateTime? FinancialYearFrom { get; set; }

        public DateTime? BooksBegginingFrom { get; set; }

        public string EmailAddress { get; set; }

        public string PINCode { get; set; }

        public string VatTIN { get; set; }

        public string IncomeTexNo { get; set; }

        public byte? Flag { get; set; }

        public bool? Accounts { get; set; }

        public bool? Procurement { get; set; }

        public bool? Production { get; set; }

        public bool? Sales { get; set; }

        public bool? HirePurchase { get; set; }

        public bool? Inventory { get; set; }

        public DateTime? CompanyEstablishedDate { get; set; }

        public bool? LocalDataEntryLocked { get; set; }

        public int? BusinessType_BMItemID { get; set; }

        public string EBS_Code { get; set; }

        public string EBS_LegalEntityCode { get; set; }

        public string EBS_InterCompanyCode { get; set; }

        public decimal? EBS_OU_ID { get; set; }

        public string EBS_OU_Name { get; set; }

        public string Ledger_ID { get; set; }

        public string ShortCode { get; set; }

        public string LegalEntityName { get; set; }

        public string LegalEntityAddress { get; set; }

        public string CorporateOfficeAddress { get; set; }

        public string sap_code { get; set; }

        public string BM_BranchName_PSRF_Short { get; set; }
    }
}
