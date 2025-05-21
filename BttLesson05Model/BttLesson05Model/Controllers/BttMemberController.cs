using BttLesson05Model.Models.DataModels;
using Microsoft.AspNetCore.Mvc;

namespace BttLesson05Model.Controllers
{
    public class BttMemberController : Controller
    {
        private static List<BttMember> bttListMember = new List<BttMember>()
        {
            new BttMember
            {
                BttMemberId = "2310900108",
                BttUserName = "ThanhTrung",
                BttPassword = "123456@",
                BttFullName = "Bùi Thành Trung",
                BttEmail = "buitrung4212@gmail.com"
            },
            new BttMember
            {
                BttMemberId = "M002",
                BttUserName = "user2",
                BttPassword = "pass2",
                BttFullName = "Tran Thi B",
                BttEmail = "user2@example.com"
            },
            new BttMember
            {
                BttMemberId = "M003",
                BttUserName = "user3",
                BttPassword = "pass3",
                BttFullName = "Le Van C",
                BttEmail = "user3@example.com"
            },
            new BttMember
            {
                BttMemberId = "M004",
                BttUserName = "user4",
                BttPassword = "pass4",
                BttFullName = "Pham Thi D",
                BttEmail = "user4@example.com"
            },
            new BttMember
            {
                BttMemberId = "M005",
                BttUserName = "user5",
                BttPassword = "pass5",
                BttFullName = "Hoang Van E",
                BttEmail = "user5@example.com"
            }
        };
        public IActionResult BttIndex()
        {
            return View(bttListMember);
        }
    }
}
