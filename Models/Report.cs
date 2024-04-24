using System.ComponentModel.DataAnnotations;

namespace Valor.Models
{
    public class Report
    {
     
        public int ReportID {get; set;}
        public string ReportParagraph {get; set;}

        
        public int WellID {get; set;} //FK
        public Well? Well {get; set;}//Navigation
    
    }
}
