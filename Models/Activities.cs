using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_Tracker.Models
{
    public class Activities
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string activity_name { get; set; }

        [Required]
        [StringLength(50)]
        public int metric_one_value { get; set; }

        [Required]
        [StringLength(50)]
        public int metric_two_value { get; set; }

        [Required]
        [StringLength(50)]
        public int metric_three_value { get; set; }

        [Required]
        public int burn_cal { get; set; }

        [DataType(DataType.Date)]
        public DateTime date { get; set; }

        [Required]
        [StringLength(50)]
        public string username { get; set; }

        [Required]
        public int goal_id { get; set; }
    }
}
