using Microsoft.AspNetCore.Mvc;
using ResumeProjectDemoNight.Context;

namespace ResumeProjectDemoNight.ViewComponents.AdminViewComponents
{
    public class _AdminNotificationComponentPartial : ViewComponent
    {
        private readonly ResumeContext _context;

        public _AdminNotificationComponentPartial(ResumeContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.TotalProjects = _context.Portfolios.Count();
            ViewBag.UnreadMessages = _context.Messages.Where(x => !x.IsRead).Count();

            return View();
        }
    }
}