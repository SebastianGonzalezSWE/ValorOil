using System.ComponentModel.DataAnnotations;

namespace Valor.Models
{
    public class Report
    {
     
        public int Report_ID {get; set;}

        public int Well_ID {get; set;} // FK Report to Well
        public Well? Well {get; set;}// Navigation Property
    }
}
