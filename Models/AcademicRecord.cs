namespace EnterpriseReportingPortal.Models
{
    public class AcademicRecord
    {
        public int AcademicRecordId { get; set; }

        public string StudentName { get; set; } = "";

        public string Course { get; set; } = "";

        public string Grade { get; set; } = "";

        public int DepartmentId { get; set; }
    }
}