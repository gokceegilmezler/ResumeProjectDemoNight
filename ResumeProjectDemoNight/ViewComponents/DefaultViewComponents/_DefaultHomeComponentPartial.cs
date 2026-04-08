using Microsoft.AspNetCore.Mvc;
using ResumeProjectDemoNight.Context;

namespace ResumeProjectDemoNight.ViewComponents.DefaultViewComponents
{
    public class _DefaultHomeComponentPartial:ViewComponent
    {
        private readonly ResumeContext _context;

        public _DefaultHomeComponentPartial(ResumeContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var about = _context.Abouts.FirstOrDefault();
            var socialMedia = _context.SocialMedias.ToList();

            ViewBag.About = about;
            ViewBag.SocialMedia = socialMedia;
            return View();
        }
    }
}
