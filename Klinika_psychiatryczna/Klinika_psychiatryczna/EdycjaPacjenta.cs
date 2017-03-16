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
        public PacjentDetailsFormModel viewModel = new PacjentDetailsFormModel();
        public EdycjaPacjenta()
        {
            InitializeComponent();
        }
        public void UpdateForm()
        {
            txtName.Text = viewModel.PName;
            txtSurname.Text = viewModel.PLastName;
            dateDOB.Value = viewModel.PDOB;
            txtCity.Text = viewModel.PCity;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            viewModel = null;
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            viewModel.PName = txtName.Text;
            viewModel.PLastName = txtSurname.Text;
            viewModel.PDOB = dateDOB.Value;
            viewModel.PCity = txtCity.Text;
            Close();
        }

        private void EdycjaPacjenta_Shown(object sender, EventArgs e)
        {
            if (viewModel.PDOB.Year > 1800)
            {
                UpdateForm();
            }
        }
    }
}
