using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WiredBrainCoffee.Models;
using WiredBrainCoffee.Services;

namespace WiredBrainCoffee.Pages
{
    public class ConfirmationModel : PageModel
    {
        public string Message { get; set; }
        public void OnGetContact()
        {
            Message = "Your email has been sent.";
        }
        public void OnGetSubscribe()
        {
            Message = "You hace been added to the mailing list.";
        }
    }

}

