using exam180723.Entities;
using exam180723.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace exam180723.Controllers
{
    public class ContactController : Controller
    {
        private readonly Context _context;
        public ContactController(Context context)
        {
            _context = context;
        }
        async public Task<IActionResult> Index()
        {
            var model = _context.Contacts.ToList<Contact>();
            return View(model);
        }

        [HttpGet]
        async public Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        async public Task<IActionResult> Create(ContactViewModel data)
        {
            if (ModelState.IsValid)
            {
                var contact = new Contact { Name = data.Name, Number = data.Number, GroupName = data.GroupName, HireDate = data.HireDate, Birthday = data.Birthday };
                _context.Contacts.Add(contact);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Error");
        }
        async public Task<IActionResult> SoftByName()
        {
            var model = _context.Contacts.OrderByDescending(x => x.Name).ToList<Contact>();
            return RedirectToAction("Index",model);
        }
        [HttpPost]
        async public Task<IActionResult> Search(string data)
        {
            var model = _context.Contacts.FirstOrDefaultAsync(m=>m.Name==data);
            return RedirectToAction("Index",model);
        }

        [ResponseCache(Duration = 0, Location =ResponseCacheLocation.None, NoStore =true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
