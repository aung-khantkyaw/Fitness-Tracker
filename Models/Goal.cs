using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_Tracker.Models
{
    public class Goal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string username { get; set; }

        [Required]
        public int goal { get; set; }

        [Required]
        [StringLength(50)]
        public string start_date { get; set; }

        [Required]
        [StringLength(50)]
        public string end_date { get; set; }

        [Required]
        [StringLength(50)]
        public string is_achieve { get; set; } = "Inprogress";
    }
}
