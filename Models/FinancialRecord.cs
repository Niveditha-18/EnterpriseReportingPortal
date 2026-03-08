namespace EnterpriseReportingPortal.Models
{
    public class FinancialRecord
    {
        public int FinancialRecordId { get; set; }

        public decimal Budget { get; set; }

        public decimal Expenses { get; set; }

        public decimal GrantAmount { get; set; }

        public int DepartmentId { get; set; }
    }
}