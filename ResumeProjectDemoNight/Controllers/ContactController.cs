using Microsoft.AspNetCore.Mvc;
using ResumeProjectDemoNight.Entities;
using ResumeProjectDemoNight.Context;

namespace ResumeProjectDemoNight.Controllers
{
    public class ContactController:Controller
    {
        private readonly ResumeContext _context;

        public ContactController(ResumeContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult SendMessage(Message message)
        {
            message.SendDate = DateTime.Now;
            message.IsRead = false;

            _context.Messages.Add(message);
            _context.SaveChanges();

            return RedirectToAction("Index", "Default");
        }
    }
}

