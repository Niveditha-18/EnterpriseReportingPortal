using EnterpriseReportingPortal.Models;
using EnterpriseReportingPortal.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EnterpriseReportingPortal.Pages.Reports
{
    [Authorize(Roles = "Admin")]  // Only Admins can access
    public class ReportsModel : PageModel
    {
        private readonly IReportService _reportService;

        public List<Report> Reports { get; set; } = new List<Report>();

        public ReportsModel(IReportService reportService)
        {
            _reportService = reportService;
        }

        public async Task OnGet()
        {
            Reports = await _reportService.GetAllReports();
        }
    }
}