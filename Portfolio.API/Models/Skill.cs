using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.API.Models
{
    public class Skill
    {
        [Key]
        public Guid SkillId { get; set; }
        [Required]
        public String Name { get; set; }
        [Required]
        public String Image { get; set; }
    }
}
