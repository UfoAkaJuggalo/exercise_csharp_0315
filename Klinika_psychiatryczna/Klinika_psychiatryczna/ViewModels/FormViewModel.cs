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
            Pacjenci = new List<Pacjent>();
        }
        public List<Pacjent> Pacjenci { get; }
    }
}
