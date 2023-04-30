using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Artsofte.DAL.Enum;

namespace Artsofte.DAL.Models
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        [Range(14, 100, ErrorMessage = "Age must be between 14 and 100.")]
        public int Age { get; set; }
        public GenderEnum Gender { get; set; }
        public Guid? DepartamentId { get; set; }
        public Departament? Departament { get; set; }
        public Guid? ProgrammingLanguageId { get; set; }
        public ProgrammingLanguage? ProgrammingLanguage { get; set; }
    }
}
