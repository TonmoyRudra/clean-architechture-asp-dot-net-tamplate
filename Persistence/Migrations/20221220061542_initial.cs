using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "BM_CompanyBranch",
            //    columns: table => new
            //    {
            //        BM_BranchID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        BM_CompanyID = table.Column<int>(type: "int", nullable: true),
            //        BM_BranchName2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        BM_BranchName1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        BM_BranchName = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        BM_BranchName_0 = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        BM_BranchName_1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        BM_BranchName_2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        BM_BranchName_3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        BM_BranchName_4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        BranchLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Phone1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Phone2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Phone3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Fax = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        TreatHeadOffice = table.Column<bool>(type: "bit", nullable: true),
            //        TreatCurrentBranch = table.Column<bool>(type: "bit", nullable: true),
            //        Manager_HR_EmployeeID = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
            //        ActiveStatus = table.Column<bool>(type: "bit", nullable: true),
            //        RegistrationNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        VATForHirePurchase = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
            //        VATForGeneralSales = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
            //        VATForShowroom = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
            //        VATForPurchase = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
            //        AllowStockValueWAVGPeriodical = table.Column<bool>(type: "bit", nullable: true),
            //        AllowStockValueWAVGPerpetual = table.Column<bool>(type: "bit", nullable: true),
            //        AllowStockValueFIFO = table.Column<bool>(type: "bit", nullable: true),
            //        AllowStockValueLIFO = table.Column<bool>(type: "bit", nullable: true),
            //        FinancialYearFrom = table.Column<DateTime>(type: "datetime2", nullable: true),
            //        BooksBegginingFrom = table.Column<DateTime>(type: "datetime2", nullable: true),
            //        EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        PINCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        VatTIN = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        IncomeTexNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Flag = table.Column<byte>(type: "tinyint", nullable: true),
            //        Accounts = table.Column<bool>(type: "bit", nullable: true),
            //        Procurement = table.Column<bool>(type: "bit", nullable: true),
            //        Production = table.Column<bool>(type: "bit", nullable: true),
            //        Sales = table.Column<bool>(type: "bit", nullable: true),
            //        HirePurchase = table.Column<bool>(type: "bit", nullable: true),
            //        Inventory = table.Column<bool>(type: "bit", nullable: true),
            //        CompanyEstablishedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //        LocalDataEntryLocked = table.Column<bool>(type: "bit", nullable: true),
            //        BusinessType_BMItemID = table.Column<int>(type: "int", nullable: true),
            //        EBS_Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        EBS_LegalEntityCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        EBS_InterCompanyCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        EBS_OU_ID = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
            //        EBS_OU_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Ledger_ID = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        ShortCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        LegalEntityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        LegalEntityAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        CorporateOfficeAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        sap_code = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        BM_BranchName_PSRF_Short = table.Column<string>(type: "nvarchar(max)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_BM_CompanyBranch", x => x.BM_BranchID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "BM_ConcurrentRequest",
            //    columns: table => new
            //    {
            //        PID = table.Column<long>(type: "bigint", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Application = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        RequestName = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        RequestParameter = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        ProcessStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        ExecutableString = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        ProcessStartTime = table.Column<DateTime>(type: "datetime2", nullable: true),
            //        ProcessEndTime = table.Column<DateTime>(type: "datetime2", nullable: true),
            //        ErrorSummary = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        IsActive = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        CreatedByUserID = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
            //        CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        LastUpdateByUserID = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
            //        LastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //        Remarks = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        NotifyUser = table.Column<int>(type: "int", nullable: true),
            //        UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        UserEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        RequestClassName = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        TargetProcessManager = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        RequestType = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        ReferenceID = table.Column<int>(type: "int", nullable: true),
            //        ReferenceDetails = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        OutputFilePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        OutputFileURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        OutputText = table.Column<string>(type: "nvarchar(max)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_BM_ConcurrentRequest", x => x.PID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "BM_SecUser",
            //    columns: table => new
            //    {
            //        BM_UserID = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
            //        UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Phone1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Phone2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        MobileNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        HR_DeptID = table.Column<int>(type: "int", nullable: true),
            //        HR_DesgID = table.Column<int>(type: "int", nullable: true),
            //        LoanAdvanceStart = table.Column<bool>(type: "bit", nullable: true),
            //        LoanAdvanceFinalized = table.Column<bool>(type: "bit", nullable: true),
            //        LogUserID = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        ConfirmPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //        LastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //        Inactive = table.Column<bool>(type: "bit", nullable: true),
            //        BM_BranchID = table.Column<int>(type: "int", nullable: true),
            //        Flag = table.Column<byte>(type: "tinyint", nullable: true),
            //        PunchCardNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Sex_BM_ItemID = table.Column<int>(type: "int", nullable: true),
            //        Relegion_BM_ItemID = table.Column<int>(type: "int", nullable: true),
            //        Priority = table.Column<int>(type: "int", nullable: true),
            //        Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        EmailPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        EmailForward = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        IP = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        MACAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        SignaturePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        EmailCreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //        EmailDeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //        HR_EmployeeID = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
            //        PasswordVerified = table.Column<int>(type: "int", nullable: true),
            //        AcceptPolicy = table.Column<int>(type: "int", nullable: true),
            //        AcceptERPAgreement = table.Column<int>(type: "int", nullable: true),
            //        FailedAttempts = table.Column<int>(type: "int", nullable: true),
            //        FailedAttemptsTime = table.Column<DateTime>(type: "datetime2", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_BM_SecUser", x => x.BM_UserID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "HR_Employee",
            //    columns: table => new
            //    {
            //        HR_EmployeeID = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
            //        BM_BranchID = table.Column<int>(type: "int", nullable: false),
            //        HR_EmployeeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Under_Acc_HeadFirstLvlName = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
            //        Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Phone1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Phone2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        MobileNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        JoinDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //        Mgr = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Active = table.Column<bool>(type: "bit", nullable: true),
            //        Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        HR_DeptID = table.Column<int>(type: "int", nullable: true),
            //        HR_DesgID = table.Column<int>(type: "int", nullable: true),
            //        BasicSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
            //        Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        ConfirmPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //        LastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //        Flag = table.Column<byte>(type: "tinyint", nullable: true),
            //        Village = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        PO = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        PS = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        District = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        UnderHR_EmployeeID = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
            //        UnderHR_EmployeeIDLast = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
            //        Alias = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Father_HushandName = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        MotherName = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        DateOfBirthV = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        NationalityInv_CountryID = table.Column<int>(type: "int", nullable: true),
            //        RelagionBM_ItemID = table.Column<int>(type: "int", nullable: true),
            //        PresentMailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Comments = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        ProfessionalQualification = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        TrainingInBrief = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        ExtraCurricularActivities = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        MaritalStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        MaritalStatusBM_ItemID = table.Column<int>(type: "int", nullable: true),
            //        SpeakFluencyInLanInv_CountryID = table.Column<int>(type: "int", nullable: true),
            //        SpeakFluencyPerfoBM_ItemID = table.Column<int>(type: "int", nullable: true),
            //        ApplicationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //        PicturePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        DateOfJoining = table.Column<DateTime>(type: "datetime2", nullable: true),
            //        ConfirmationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //        ConfirmationDateApprox = table.Column<DateTime>(type: "datetime2", nullable: true),
            //        RetireDateApproximate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //        CauseOfSeparation = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        CauseOfSeparationBM_ItemID = table.Column<int>(type: "int", nullable: true),
            //        RetireDateActual = table.Column<DateTime>(type: "datetime2", nullable: true),
            //        Inactive = table.Column<bool>(type: "bit", nullable: true),
            //        GrandeBM_ItemIDUsers = table.Column<int>(type: "int", nullable: true),
            //        AppStatusBM_ItemIDUsers = table.Column<int>(type: "int", nullable: true),
            //        MinimumDaysOfConfirmation = table.Column<int>(type: "int", nullable: true),
            //        SpouseName = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        ContractualDateFrom = table.Column<DateTime>(type: "datetime2", nullable: true),
            //        ContractualDateTo = table.Column<DateTime>(type: "datetime2", nullable: true),
            //        BloodBM_ItemID = table.Column<int>(type: "int", nullable: true),
            //        PlaceOfPostingBM_ItemIDUsers = table.Column<int>(type: "int", nullable: true),
            //        TotalPayableAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
            //        FinalPayment = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
            //        ForfeitureAC = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
            //        ClosingBalance = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
            //        Rtd = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
            //        ProcessForLPR = table.Column<bool>(type: "bit", nullable: true),
            //        LPRPaymentID = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Acc_BankID = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
            //        Acc_ForfeitureAccountID = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
            //        PassportNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        VoterIDNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        ReportToHR_EmployeeID = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
            //        SalaryAccountAcc_BankID = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
            //        BankAccountNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        EmployeeFileLocationBM_ItemIDUsers = table.Column<int>(type: "int", nullable: true),
            //        Acc_RetiredMembersAccountID = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
            //        SalarySheetSerialNo = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
            //        CorporateTitleBM_ItemIDUsers = table.Column<int>(type: "int", nullable: true),
            //        GenderBM_ItemID = table.Column<int>(type: "int", nullable: true),
            //        DistrictBM_ItemIDUsers = table.Column<int>(type: "int", nullable: true),
            //        GratuatyEnable = table.Column<bool>(type: "bit", nullable: true),
            //        GratuatyAfterYear = table.Column<int>(type: "int", nullable: true),
            //        SalaryScaleBM_ItemIDUsers = table.Column<int>(type: "int", nullable: true),
            //        Extension = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        PictureNameForWeb = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        PersonalEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Nominee = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Languages = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        EmpCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        DottedLineHR_EmployeeID = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
            //        DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
            //        EBS_CostCenterID = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
            //        EBS_EmployeeCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        EBS_LocationID = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
            //        MobileLimit = table.Column<double>(type: "float", nullable: true),
            //        InternetLimit = table.Column<double>(type: "float", nullable: true),
            //        MobileBillType = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        InternetBillType = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        InternetOperatorBM_ItemID = table.Column<int>(type: "int", nullable: true),
            //        JobLevelBM_ItemIDUsers = table.Column<int>(type: "int", nullable: true),
            //        eTIN = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        CardNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        HoldSalary = table.Column<bool>(type: "bit", nullable: true),
            //        HoldSalaryReason = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Currency = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        FunctionalLevelBM_ItemID = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
            //        WPPF_EligibleAs = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        HR_BandID = table.Column<int>(type: "int", nullable: true),
            //        HR_GradeID = table.Column<int>(type: "int", nullable: true),
            //        ReportTo2_EmployeeID = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
            //        DottedLine2_EmployeeID = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
            //        AdditionalReportTo1_EmployeeID = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
            //        AdditionalReportTo2_EmployeeID = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
            //        HRRoleId = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
            //        HRMappedRoleId = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
            //        SF_ID = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
            //        FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        sap_bu_code = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        sap_func_code = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        sap_subFunc_code = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        sap_area_code = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        sap_subArea_code = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        sap_support_code = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        suspensionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //        NoBonus = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_HR_Employee", x => x.HR_EmployeeID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "UM_MENU_ACCESS_V",
            //    columns: table => new
            //    {
            //        RSPID = table.Column<long>(type: "bigint", nullable: false),
            //        RSPNAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        RSPDESC = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        LOOKUP_ID = table.Column<long>(type: "bigint", nullable: false),
            //        APP_NAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        APP_SHORTCODE = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        APP_ICONNAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        AGID = table.Column<long>(type: "bigint", nullable: false),
            //        AGNAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        AGDESCHELP = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        MGID = table.Column<long>(type: "bigint", nullable: false),
            //        MGNAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        SHORTCODE_MG = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        ICONNAME_MG = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        MGTOOLTIP = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        MGRUOUTENAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        MGSERIALNO = table.Column<int>(type: "int", nullable: true),
            //        MID = table.Column<long>(type: "bigint", nullable: false),
            //        MENUNAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        MENUTOOLTIP = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        MENUSHORTNAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        MENUDESCHELP = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        ROUTINGNAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        ICONNAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        SERIAL_NO = table.Column<long>(type: "bigint", nullable: true),
            //        CANVIEW = table.Column<int>(type: "int", nullable: false),
            //        CANINSERT = table.Column<int>(type: "int", nullable: false),
            //        CANUPDATE = table.Column<int>(type: "int", nullable: false),
            //        CANDELETE = table.Column<int>(type: "int", nullable: false),
            //        USERID = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
            //        LOGINNAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        ADDRESSMENAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        LOGINID = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        EMAIL = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        EMP_ID = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
            //        INACTIVE_USER = table.Column<bool>(type: "bit", nullable: true),
            //        INACTIVE_RSP_ASSIGNMENT = table.Column<bool>(type: "bit", nullable: true),
            //        INCATIVE_ACCESS_GP = table.Column<bool>(type: "bit", nullable: true),
            //        INCATIVE_RSP = table.Column<bool>(type: "bit", nullable: true),
            //        INACTIVE_MENU = table.Column<bool>(type: "bit", nullable: true),
            //        INACTIVE_MENUGROUP = table.Column<bool>(type: "bit", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //    });

            //migrationBuilder.CreateTable(
            //    name: "UM_RESPONSIBILITYASSIGN",
            //    columns: table => new
            //    {
            //        RSPAGID = table.Column<long>(type: "bigint", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        USERID = table.Column<long>(type: "bigint", nullable: false),
            //        RSPID = table.Column<long>(type: "bigint", nullable: false),
            //        REMARKS = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        CREATED_BY = table.Column<long>(type: "bigint", nullable: true),
            //        CREATION_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        LAST_UPDATE_BY = table.Column<long>(type: "bigint", nullable: true),
            //        LAST_UPDATE_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
            //        IS_INACTIVE = table.Column<bool>(type: "bit", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_UM_RESPONSIBILITYASSIGN", x => x.RSPAGID);
            //    });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BM_CompanyBranch");

            migrationBuilder.DropTable(
                name: "BM_ConcurrentRequest");

            migrationBuilder.DropTable(
                name: "BM_SecUser");

            migrationBuilder.DropTable(
                name: "HR_Employee");

            migrationBuilder.DropTable(
                name: "UM_MENU_ACCESS_V");

            migrationBuilder.DropTable(
                name: "UM_RESPONSIBILITYASSIGN");
        }
    }
}
