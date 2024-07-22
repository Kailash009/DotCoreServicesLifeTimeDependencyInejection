using DotCoreServicesLifeTime.Repo.Contract;
using Microsoft.AspNetCore.Mvc;

namespace DotCoreServicesLifeTime.Controllers
{
    public class TestController : Controller
    {
        private readonly ITransientService _transientService1;
        private readonly ITransientService _transientService2;
        private readonly IScopedService _scopedService1;
        private readonly IScopedService _scopedService2;
        private readonly ISingletonService _singletonService1;
        private readonly ISingletonService _singletonService2;
        public TestController(ITransientService transientService1, ITransientService transientService2, IScopedService scopedService1, IScopedService scopedService2, ISingletonService singletonService1, ISingletonService singletonService2)
        {
            _transientService1 = transientService1;
            _transientService2 = transientService2;
            _scopedService1 = scopedService1;
            _scopedService2 = scopedService2;
            _singletonService1 = singletonService1;
            _singletonService2 = singletonService2;
        }

        public IActionResult Index()
        {
            ViewBag.transientService1= _transientService1.GetGuid();
            ViewBag.transientService2 = _transientService2.GetGuid();

            ViewBag.scopedService1 = _scopedService1.GetGuid();
            ViewBag.scopedService2 = _scopedService2.GetGuid();
            
            ViewBag.singletonService1 = _singletonService1.GetGuid();
            ViewBag.singletonService2 = _singletonService2.GetGuid();
            
            
            return View();
        }
    }
}
