using System.ComponentModel.DataAnnotations;

namespace Valor.Models
{
    public class Well
    {
        public int Well_ID { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Well_Name { get; set; } = string.Empty;

        [Required]
        public decimal Storage_Capacity { get; set; }

         [Required]
        public decimal Flow_Rate { get; set; }

        public List<Report> Reports {get; set;} = new List<Report>(); // One Well can have many reports  
        public Report? Report {get; set;}// Navigation Property
     
    }
}