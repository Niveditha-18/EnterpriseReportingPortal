namespace EnterpriseReportingPortal.Models
{
    public class Report
    {
        public int ReportId { get; set; }

        public string Title { get; set; } = "";

        public DateTime CreatedDate { get; set; }

        public int DepartmentId { get; set; }

        public Department? Department { get; set; }
    }
}