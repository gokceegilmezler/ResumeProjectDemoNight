using Microsoft.AspNetCore.Mvc;
using ResumeProjectDemoNight.Context;

namespace ResumeProjectDemoNight.Controllers
{
    public class DashboardController : Controller
    {
        private readonly ResumeContext _context;

        public DashboardController(ResumeContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.TotalProjects = _context.Portfolios.Count();
            ViewBag.TotalMessages = _context.Messages.Count();
            ViewBag.UnreadMessages = _context.Messages.Where(x => !x.IsRead).Count();
            ViewBag.TotalTestimonials = _context.Testimonials.Count();
            ViewBag.TotalExperiences = _context.Experiences.Count();
            ViewBag.TotalSkills = _context.Skills.Count();

            // Hakkımda özeti
            var about = _context.Abouts.FirstOrDefault();
            ViewBag.About = about;

            // Son 5 mesaj
            var recentMessages = _context.Messages
                .OrderByDescending(x => x.SendDate)
                .Take(5)
                .ToList();
            ViewBag.RecentMessages = recentMessages;

            return View();
        }
    }
}
