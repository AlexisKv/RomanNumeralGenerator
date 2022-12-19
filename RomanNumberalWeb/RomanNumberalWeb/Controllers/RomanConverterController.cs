using Microsoft.AspNetCore.Mvc;
using RomanNumeral.Core.Models;
using RomanNumeral.Core.Services;
using RomanNumeral.Data;

namespace RomanNumberalWeb.Controllers
{
    public class RomanConverterController : Controller
    {
        private ILogsServices _logsServices;
        private IRomanNumeralGenerator _romanNumeralGenerator;

        public RomanConverterController(RomanNumberalWebContext context, ILogsServices logsServices,
            IRomanNumeralGenerator romanNumeralGenerator)
        {
            _logsServices = logsServices;
            _romanNumeralGenerator = romanNumeralGenerator;
        }

        // // GET: RomanConverter
        public async Task<IActionResult> Index()
        {
              return View( _logsServices.GetAll());
        }


        // GET: RomanConverter/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RomanConverter/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TimeCreated,Input,Output")] Logs logs)
        {
            if (ModelState.IsValid)
            {
                _logsServices.Create(logs);
                return RedirectToAction(nameof(Index));
            }
            return View(logs);
        }
        
  
        // GET: RomanConverter/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var logs =  _logsServices.GetById(id);
            if (logs == null)
            {
                return NotFound();
            }

            return View(logs);
        }

        // POST: RomanConverter/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var logs = _logsServices.GetById(id);
            if (logs != null)
            {
                _logsServices.Delete(logs);
            }
            
            return RedirectToAction(nameof(Index));
        }
        
        
        public ContentResult Romain(string number)
        {
            int intNum = Int32.Parse(number);
            var convertedNum =  _romanNumeralGenerator.Generate(intNum);
            
            _logsServices.Log(number, convertedNum);
            return Content($"{convertedNum}");
        }
    }
}
