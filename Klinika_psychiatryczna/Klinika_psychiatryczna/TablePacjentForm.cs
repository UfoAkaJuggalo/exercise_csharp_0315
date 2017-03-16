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
    public partial class TablePacjentForm : Form
    {
        private FormViewModel viewModel = new FormViewModel();
        public TablePacjentForm()
        {
            InitializeComponent();
            bsPacjenci.DataSource = viewModel.Pacjenci;
        }

        private void buttEdit_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.dataGridView1.CurrentRow.Cells[0].Value.ToString() + " " + this.dataGridView1.CurrentRow.Cells[1].Value.ToString());
        }
    }
}
