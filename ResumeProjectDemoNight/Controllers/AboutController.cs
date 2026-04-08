using Microsoft.AspNetCore.Mvc;
using ResumeProjectDemoNight.Context;
using ResumeProjectDemoNight.Entities;

namespace ResumeProjectDemoNight.Controllers
{
    public class AboutController : Controller
    {
        private readonly ResumeContext _context;

        public AboutController(ResumeContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult AboutList()
        {
            var values=_context.Abouts.FirstOrDefault();
            return View(values);
        }
        [HttpPost]
        public IActionResult AboutList(About p)
        {
            _context.Abouts.Update(p);
            _context.SaveChanges();
            return RedirectToAction("AboutList");
        }
    }
}
