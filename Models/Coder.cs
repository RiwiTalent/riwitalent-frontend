using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using riwi.Models;

namespace riwi.Models
{
    public class Coder
    {
        public string? Id { get; set; }
        public string? FirstName { get; set; }
        public string? SecondName { get; set; }
        public string? FirstLastName { get; set; }
        public string? SecondLastName { get; set; }
        public string? Email { get; set; }
        public string? Photo { get; set; }
        public int Age { get; set; }
        public string? Status { get; set; }
        public DateTime Created_At { get; set; }
        public string? Stack { get; set; }
        // public string? ProfessionalDescription { get; set; }

        // public StandarRiwi? StandarRiwi { get; set; }
        public List<Skill>? Skills { get; set; }
        public LanguageSkill? LanguageSkills { get; set; }
    }

}