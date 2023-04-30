using Artsofte.BLL.DTO;
using Artsofte.BLL.Interfaces;
using Artsofte.BLL.Services;
using Artsofte.WEB.Models.ViewModels;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace Artsofte.WEB.Controllers
{
    public class DepartamentController : Controller
    {
        private readonly ILogger<DepartamentController> _logger;
        private readonly IMapper _mapper;
        private readonly IDepartamentService _departamentService;

        public DepartamentController(IDepartamentService departamentService, IMapper mapper, ILogger<DepartamentController> logger)
        {
            _departamentService = departamentService;
            _mapper = mapper;     
            _logger = logger;
        }
        public IActionResult Index()
        {
            ViewBag.Departament = _departamentService.GetAll();
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Add()
        {
            return View(new DepartamentVM());
        }
        
        [HttpPost]
        public async Task<IActionResult> Add(DepartamentVM departament)
        {
            await _departamentService.AddAsync(_mapper.Map<DepartamentDTO>(departament));
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _departamentService.DeleteAsync(id);
            return RedirectToAction("Index");
        }
        public IActionResult GetDepartments(string? term)
        {
            if (string.IsNullOrEmpty(term))
            {
                return Json(_departamentService.GetAll().ToList());
            }
            var departments = _departamentService.GetAll()
                .Where(d => d.Name.ToLower().StartsWith(term.ToLower()))
                .Select(d => new { label = d.Name, value = d.Id })
                .ToList();

            return Json(departments);
        }
    }
}
