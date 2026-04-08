using Microsoft.AspNetCore.Mvc;
using ResumeProjectDemoNight.Context;

namespace ResumeProjectDemoNight.Controllers
{
    public class MessageController : Controller
    {
        private readonly ResumeContext _context;

        public MessageController(ResumeContext context)
        {
            _context = context;
        }

        public IActionResult MessageList()
        {
            var values=_context.Messages.ToList();
            return View(values);
        }

        public IActionResult Delete(int id)
        {
            var value = _context.Messages.Find(id);
            if (value != null)
            {
                _context.Messages.Remove(value);
                _context.SaveChanges();
            }
            return RedirectToAction("MessageList");
        }

        public IActionResult Details(int id)
        {
            var value = _context.Messages.Find(id);
            if (value != null)
            {
                value.IsRead = true;
                _context.SaveChanges();
                return View(value);
            }
            return RedirectToAction("MessageList");
        }
    }
}
