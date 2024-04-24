using System.ComponentModel.DataAnnotations;

namespace Valor.Models
{
    public class Operator
    {
        public int Operator_ID { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Operator_FirstName { get; set; } = string.Empty;

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Operator_LastName { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

       
        public List<Well> Wells {get; set;} = new List<Well>(); // One Operator can have many Wells  
        public Well? Well {get; set;}// Navigation Property
    }
}