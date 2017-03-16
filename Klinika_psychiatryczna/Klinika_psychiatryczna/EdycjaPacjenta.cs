using Klinika_psychiatryczna.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klinika_psychiatryczna
{
    public partial class EdycjaPacjenta : Form
    {
        public EdycjaPacjenta()
        {
            InitializeComponent();
        }
        public EdycjaPacjenta(PacjentDetailsFormModel pacjentData)
        {
            this.txtName.Text = pacjentData.PName;
            this.txtSurname.Text = pacjentData.PLastName;
            this.txtDOB.Text = pacjentData.PDOB;
            this.txtCity.Text = pacjentData.PCity;
            InitializeComponent();
        }
    }
}
