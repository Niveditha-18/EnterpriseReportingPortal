namespace EnterpriseReportingPortal.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; } = "";
        public ICollection<Report> Reports { get; set; } = new List<Report>();
    }
}
