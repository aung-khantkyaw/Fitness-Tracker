using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Fitness_Tracker.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string username { get; set; }

        [Required]
        [StringLength(50)]
        [EmailAddress] 
        public string email { get; set; }

        [Required]
        [StringLength(255)] 
        public string password { get; set; }

        public int? age { get; set; }

        [StringLength(50)]
        public string gender { get; set; }
        public int? weight { get; set; }

        public int? height { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime registration_date { get; set; }

        [Required]
        [StringLength(50)]
        public string role { get; set; } = "Member";
    }
}
