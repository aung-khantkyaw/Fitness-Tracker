using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Fitness_Tracker.Models
{
    public class ActivityType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string activity { get; set; }

        [Required]
        [StringLength(100)]
        public string metric_one { get; set; }

        [Required]
        [StringLength(100)]
        public string metric_two { get; set; }

        [Required]
        [StringLength(100)]
        public string metric_three { get; set; }
    }
}
