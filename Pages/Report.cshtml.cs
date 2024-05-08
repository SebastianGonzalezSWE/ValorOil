using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Valor.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace ValorOil.Pages;
public class ReportModel : PageModel
{
    private readonly ValorContext _context;
    private readonly ILogger<ReportModel> _logger;
    
    public List<Report> Reports { get; set;} = default!;
    
    
    public ReportModel(ValorContext context, ILogger<ReportModel> logger)
    {
        _context = context;
        _logger = logger;
    }

    public SelectList ReportsDropDown { get; set; } = default!;
    
    [BindProperty]
    [Display(Name = "ReportID")]
    public int? SReportID { get; set; } = default!;
    public Report SReport { get; set; } = default!;
    
    public void OnGet()
    {
        Reports = _context.Reports.ToList();
        
        ReportsDropDown = new SelectList(Reports, "ReportID","ReportParagraph");

        
    }

    public void OnPost()
    {   SReport = _context.Reports.FirstOrDefault(p=>p.ReportID == SReportID.Value);
         _logger.LogInformation($"You selected Report:#{SReport?.ReportID} Paragraph:{SReport?.ReportParagraph}");
    }

    

}