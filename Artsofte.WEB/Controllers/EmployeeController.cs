using Artsofte.BLL.DTO;
using Artsofte.BLL.Interfaces;
using Artsofte.DAL.Models;
using Artsofte.WEB.Models;
using Artsofte.WEB.Models.ViewModels;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Diagnostics;

namespace Artsofte.WEB.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ILogger<EmployeeController> _logger;
        private readonly IEmployeeService _employeeService;
        private readonly IMapper _mapper;
        private readonly IProgrammingLanguageService _programmingLanguageService;
        private readonly IDepartamentService _departamentService;

        public EmployeeController(IDepartamentService departamentService, IProgrammingLanguageService programmingLanguageService, IMapper mapper, ILogger<EmployeeController> logger, IEmployeeService employeeService)
        {
            _departamentService = departamentService;
            _programmingLanguageService = programmingLanguageService;
            _mapper = mapper;
            _employeeService= employeeService;
            _logger = logger;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var employees = _employeeService.GetAll();
            if (employees == null)
            {
                
                return View();
            }
            ViewBag.Employee = _mapper.Map<ICollection<EmployeeVM>>(employees);
            return View();
        }


        

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            return View(new EmployeeVM());
        }

        [HttpPost]
        public async Task<IActionResult> Add(IFormCollection form, EmployeeVM employeeVM)
        {
            if (!ModelState.IsValid)
            {
                return View(employeeVM);
            }

            await _employeeService.AddAsync(_mapper.Map<EmployeeDTO>(employeeVM));
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _employeeService.DeleteAsync(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            ViewBag.Departament = _departamentService.GetAll();
            ViewBag.ProgrammingLanguage = _programmingLanguageService.GetAll();
            return View(_mapper.Map<EmployeeVM>(await _employeeService.GetAsync(x => x.Id == id)));
        }
        [HttpPost]
        public async Task<IActionResult> Edit(EmployeeVM employeeVM)
        {
            await _employeeService.UpdateAsync(_mapper.Map<EmployeeDTO>(employeeVM));
            return RedirectToAction("Index");
        }



    }
}