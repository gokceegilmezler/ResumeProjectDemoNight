using Microsoft.AspNetCore.Mvc;
using ResumeProjectDemoNight.Context;

namespace ResumeProjectDemoNight.ViewComponents.DefaultViewComponents
{
    public class _DefaultContactComponentPartial:ViewComponent
    {
        private readonly ResumeContext _context;

        public _DefaultContactComponentPartial(ResumeContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {            
            return View(); 
        }
    }
}
