using EnterpriseReportingPortal.Models;

namespace EnterpriseReportingPortal.Services
{
    public interface IReportService
    {
        Task<List<Report>> GetAllReports();
        Task AddReport(Report report);
    }
}