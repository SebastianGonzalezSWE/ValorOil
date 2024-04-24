using System.ComponentModel.DataAnnotations;

namespace Valor.Models
{
    public class Well
    {
        public int WellID { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Well_Name { get; set; } = string.Empty;

        [Required]
        public decimal Storage_Capacity { get; set; }

         [Required]
        public decimal Flow_Rate { get; set; }

        public int OperatorID {get; set;} //FK
        public Operator? Operator {get; set;}//Navigation

         public List<Report> Reports {get; set;} = new List<Report>(); // One Well can have many Reports
    }
}