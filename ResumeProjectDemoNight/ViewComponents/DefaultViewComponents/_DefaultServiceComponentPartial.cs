using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using ResumeProjectDemoNight.Context;

namespace ResumeProjectDemoNight.ViewComponents.DefaultViewComponents
{
    public class _DefaultServiceComponentPartial:ViewComponent
    {
        private readonly ResumeContext _context;
        public _DefaultServiceComponentPartial(ResumeContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var values=_context.Services.ToList();
            return View(values);
        }
    }
}
