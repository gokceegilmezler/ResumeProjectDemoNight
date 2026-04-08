using Microsoft.AspNetCore.Mvc;
using ResumeProjectDemoNight.Context;

namespace ResumeProjectDemoNight.Controllers
{
    public class DefaultController : Controller
    {
        private readonly ResumeContext _context;

        public DefaultController(ResumeContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var about=_context.Abouts.FirstOrDefault();
            var socialMedia=_context.SocialMedias.FirstOrDefault();
            var skill=_context.Skills.FirstOrDefault();
            var experience=_context.Experiences.FirstOrDefault();
            var service=_context.Services.FirstOrDefault();
            var testimonial=_context.Testimonials.FirstOrDefault();
            var portfolio=_context.Portfolios.FirstOrDefault();

            ViewBag.About=about;
            ViewBag.SocialMedias=socialMedia;
            ViewBag.Skills=skill;
            ViewBag.Experiences=experience;
            ViewBag.Service=service;
            ViewBag.Portfolio=portfolio;
            ViewBag.Testimonials=testimonial;
            return View();
        }
    }
}
