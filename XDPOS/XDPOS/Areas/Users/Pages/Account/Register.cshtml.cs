using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using XDPOS.Areas.Users.Models;

namespace XDPOS.Areas.Users.Pages.Account
{
    public class RegisterModel : PageModel
    {
        public void OnGet()
        {
        }
        //Vamos a tener acceso a InputmodelRegister por medio de una interfaz
        [BindProperty]
        public inputModel Input {get; set;}
        public class inputModel : InputModelRegister
        {

        }
    }
}
