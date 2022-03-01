using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TestReactBlazor.Pages
{
    public class ReactModel : PageModel
    {
        public static string strTexto1 { get; set; } = "Hola";
        public static string strTexto2 { get; set; } = "Mundo";

        public void OnGet()
        {
            
        }
        public static string ObtenerHolaMundo()
        {
            return $"{strTexto1} {strTexto2}";
        }
    }
}
