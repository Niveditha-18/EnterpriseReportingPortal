using Microsoft.EntityFrameworkCore;
using EnterpriseReportingPortal.Data;
using EnterpriseReportingPortal.Models;
using Microsoft.Extensions.Logging;

namespace EnterpriseReportingPortal.Services
{
    public class ReportService : IReportService
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<ReportService> _logger; // Step 1: Declare logger

        // Constructor now takes ILogger
        public ReportService(ApplicationDbContext context, ILogger<ReportService> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<List<Report>> GetAllReports()
        {
            // Step 2: Log information
            _logger.LogInformation("Fetching reports from the database...");

            var reports = await _context.Reports
                .Include(r => r.Department)
                .ToListAsync();

            _logger.LogInformation("Fetched {Count} reports successfully.", reports.Count);

            return reports;
        }

        public async Task AddReport(Report report)
        {
            _logger.LogInformation("Adding a new report: {Title}", report.Title);

            _context.Reports.Add(report);
            await _context.SaveChangesAsync();

            _logger.LogInformation("Report added successfully with ID: {ReportId}", report.ReportId);
        }
    }
}