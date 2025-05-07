using BttLab01.Models;
using Microsoft.AspNetCore.Mvc;

namespace BttLab01.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            List<Account> accounts = new List<Account>()
            {
                new Account()
                {
                    id = 1,
                    Name="Bùi Thành Trung",
                    Email="buitrung4212@gmail.com",
                    Phone="0969021769",
                    Address="Hà Nội",
                    Avatar= Url.Content("~/Avatar/03.jpg"),
                    Gender=1,
                    Bio="My name is small",
                    Birthday= new DateTime(2005,5,11)
                },
                new Account()
                {
                    id = 2,
                    Name="Trường Giang",
                    Email="giang@gmail.com",
                    Phone="0986456789",
                    Address="Hà Nội",
                    Avatar= Url.Content("~/Avatar/04.jpg"),
                    Gender=1,
                    Bio="My name is small",
                    Birthday= new DateTime(1998,7,15)
                },
                new Account()
                {
                    id = 3,
                    Name="Hoàng Thúy",
                    Email="thuy@gmail.com",
                    Phone="0986456789",
                    Address="Hà Nội",
                    Avatar= Url.Content("~/Avatar/05.jpg"),
                    Gender=1,
                    Bio="My name is small",
                    Birthday= new DateTime(1998,7,15)
                },
            };
            ViewBag.Accounts = accounts;
            return View();
        }
        [Route("ho-so-cua-toi", Name = "profile")]
        public IActionResult Profile(int id)
        {
            List<Account> accounts = new List<Account>()
            {
                new Account()
                {
                    id = 1,
                    Name = "Bùi Thành Trung",
                    Email = "buitrung4212@gmail.com",
                    Phone = "0969021769",
                    Address = "Hà Nội",
                    Avatar = Url.Content("~/Avatar/03.jpg"),
                    Gender = 1,
                    Bio = "My name is small",
                    Birthday = new DateTime(2005, 5, 11)
                },
                new Account()
                {
                    id = 2,
                    Name = "Trường Giang",
                    Email = "giang@gmail.com",
                    Phone = "0986456789",
                    Address = "Hà Nội",
                    Avatar = Url.Content("~/Avatar/04.jpg"),
                    Gender = 1,
                    Bio = "My name is small",
                    Birthday = new DateTime(1998, 7, 15)
                },
                new Account()
                {
                    id = 3,
                    Name = "Hoàng Thúy",
                    Email = "thuy@gmail.com",
                    Phone = "0986456789",
                    Address = "Hà Nội",
                    Avatar = Url.Content("~/Avatar/05.jpg"),
                    Gender = 1,
                    Bio = "My name is small",
                    Birthday = new DateTime(1998, 7, 15)
                },
            };
            Account account = accounts.FirstOrDefault(ac => ac.id == id);
            // gửi đối tượng account qua view
            ViewBag.account = account;
            return View();
        }
    }
}
