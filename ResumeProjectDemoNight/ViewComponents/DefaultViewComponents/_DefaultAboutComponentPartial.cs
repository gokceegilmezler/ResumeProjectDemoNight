using Microsoft.AspNetCore.Mvc;
using ResumeProjectDemoNight.Context;

namespace ResumeProjectDemoNight.ViewComponents.DefaultViewComponents
{
    public class _DefaultAboutComponentPartial:ViewComponent
    {
        private readonly ResumeContext _context;

        public _DefaultAboutComponentPartial(ResumeContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var about=_context.Abouts.FirstOrDefault();
            var skill=_context.Skills.ToList();

            ViewBag.TotalProjects = _context.Portfolios.Count();
            ViewBag.TotalMessages = _context.Messages.Count();
            ViewBag.TotalTestimonials = _context.Testimonials.Count();
            ViewBag.TotalExperiences = _context.Experiences.Count();

            ViewBag.About = about;
            ViewBag.Skill = skill;          
            return View();
        }
    }
}
