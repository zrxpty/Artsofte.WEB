using Artsofte.BLL.DTO;
using Artsofte.BLL.Interfaces;
using Artsofte.BLL.Services;
using Artsofte.DAL.Models;
using Artsofte.WEB.Models.ViewModels;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace Artsofte.WEB.Controllers
{
    public class ProgrammingLanguageController : Controller
    {
        private readonly ILogger<ProgrammingLanguageController> _logger;
        private readonly IMapper _mapper;
        private readonly IProgrammingLanguageService _programmingLanguageService;
        
        public ProgrammingLanguageController(IMapper mapper, ILogger<ProgrammingLanguageController> logger, IProgrammingLanguageService programmingLanguage)
        {
            _mapper = mapper;
            _logger = logger;
            _programmingLanguageService= programmingLanguage;
        }
        
        public IActionResult Index()
        {
            ViewBag.ProgrammingLanguage = _programmingLanguageService.GetAll();
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            return View(new ProgrammingLanguageVM());
        }

        [HttpPost]
        public async Task<IActionResult> Add(ProgrammingLanguageVM programmingLanguageVM)
        {
            await _programmingLanguageService.AddAsync(_mapper.Map<ProgrammingLanguageDTO>(programmingLanguageVM));
            return RedirectToAction("Index");
        }


        public IActionResult GetPL(string term)
        {
            if (string.IsNullOrEmpty(term))
            {
                return Json(_programmingLanguageService.GetAll().ToList());
            }
            var progLang = _programmingLanguageService.GetAll()
                .Where(d => d.Name.ToLower().StartsWith(term))
                .Select(d => new { label = d.Name, value = d.Id })
                .ToList();

            return Json(progLang);
        }
        [HttpGet]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _programmingLanguageService.DeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}
