using Microsoft.AspNetCore.Mvc;

namespace BOOKSHIPBACKEND.Models
{
    public class UserInfoClass : Controller
    {
     public char UserName { get; set; }
     public char Password { get; set; }
    }
}
