using Klinika_psychiatryczna.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klinika_psychiatryczna.ViewModels
{
    public class FormViewModel
    {
        public FormViewModel()
        {
            Pacjenci = new List<Pacjent>()
            {
                new Pacjent {PName = "Stefan", PLastName = "12", PDOB = "12-12-1976", PCity = "23" }
            };
        }
        public List<Pacjent> Pacjenci { get; }
    }
}
