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
                EdycjaPacjenta dialog = new EdycjaPacjenta();
                dialog.viewModel.PName = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                dialog.viewModel.PLastName = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                dialog.viewModel.PDOB = Convert.ToDateTime(this.dataGridView1.CurrentRow.Cells[2].Value);
                dialog.viewModel.PCity = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                dialog.ShowDialog();
                if (dialog.viewModel != null)
                {
                    viewModel.Pacjenci[dataGridView1.CurrentCell.RowIndex].PName = dialog.viewModel.PName;
                    viewModel.Pacjenci[dataGridView1.CurrentCell.RowIndex].PLastName = dialog.viewModel.PLastName;
                    viewModel.Pacjenci[dataGridView1.CurrentCell.RowIndex].PDOB = dialog.viewModel.PDOB;
                    viewModel.Pacjenci[dataGridView1.CurrentCell.RowIndex].PCity = dialog.viewModel.PCity;
                    bsPacjenci.DataSource = null;
                    bsPacjenci.DataSource = viewModel.Pacjenci;

                }
        }

        private void buttAdd_Click(object sender, EventArgs e)
        {
            EdycjaPacjenta dialog = new EdycjaPacjenta();
            dialog.ShowDialog();
            if (dialog.viewModel != null) {
                viewModel.Pacjenci.Add(new Models.Pacjent { PName = dialog.viewModel.PName, PLastName = dialog.viewModel.PLastName, PDOB = dialog.viewModel.PDOB, PCity = dialog.viewModel.PCity });
                bsPacjenci.DataSource = null;
                bsPacjenci.DataSource = viewModel.Pacjenci;
            }
        }

        private void buttDel_Click(object sender, EventArgs e)
        {
            if ((dataGridView1.CurrentCell != null) && (dataGridView1.CurrentCell.RowIndex > -1))
            {
                viewModel.Pacjenci.RemoveAt(dataGridView1.CurrentCell.RowIndex);
                bsPacjenci.DataSource = null;
                bsPacjenci.DataSource = viewModel.Pacjenci;

            }
        }
    }
}
