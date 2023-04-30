using Artsofte.DAL.Enum;
using Artsofte.DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artsofte.BLL.DTO
{
    public class EmployeeDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        [Range(14, 100, ErrorMessage = "Age must be between 14 and 100.")]
        public int Age { get; set; }
        public GenderEnum Gender { get; set; }
       
        public Guid? DepartamentId { get; set; } 
        public DepartamentDTO? Departament { get; set; }
        public Guid? ProgrammingLanguageId { get; set; }
        public ProgrammingLanguageDTO? ProgrammingLanguage { get; set; }
    }
}
