using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ResumeProjectDemoNight.Context;
using ResumeProjectDemoNight.Entities;

namespace ResumeProjectDemoNight.Controllers
{
    public class SocialMediaController : Controller
    {
        private readonly ResumeContext _context;

        public SocialMediaController(ResumeContext context)
        {
            _context = context;
        }

        public IActionResult SocialMediaList()
        {
            var values=_context.SocialMedias.ToList();
            return View(values);
        }

        
        public IActionResult DeleteSocialMedia(int id)
        {
            var values = _context.SocialMedias.Find(id);
            _context.SocialMedias.Remove(values);
            _context.SaveChanges();
            return RedirectToAction("SocialMediaList");
        }

        [HttpGet]
        public IActionResult UpdateSocialMedia(int id)
        {
            var values = _context.SocialMedias.Find(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateSocialMedia(SocialMedia socialMedia) 
        {
            _context.SocialMedias.Update(socialMedia);
            _context.SaveChanges();
            return RedirectToAction("SocialMediaList");
        }
            
    }
}
