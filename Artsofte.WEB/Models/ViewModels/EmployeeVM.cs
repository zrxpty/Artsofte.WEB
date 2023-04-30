using Artsofte.DAL.Enum;
using Artsofte.DAL.Models;
using System.ComponentModel.DataAnnotations;

namespace Artsofte.WEB.Models.ViewModels
{
    public class EmployeeVM
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        [Range(14, 100, ErrorMessage = "Age must be between 14 and 100.")]
        public int Age { get; set; }
        public GenderEnum Gender { get; set; }
        public DepartamentVM Departament { get; set; }
        public ProgrammingLanguageVM ProgrammingLanguage { get; set; }
    }
}
