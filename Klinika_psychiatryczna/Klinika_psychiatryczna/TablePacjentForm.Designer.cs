namespace Klinika_psychiatryczna
{
    partial class TablePacjentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttAdd = new System.Windows.Forms.Button();
            this.buttEdit = new System.Windows.Forms.Button();
            this.buttDel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pDOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsPacjenci = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPacjenci)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(537, 445);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(537, 445);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.Controls.Add(this.buttAdd, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.buttEdit, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.buttDel, 5, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 388);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(531, 54);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // buttAdd
            // 
            this.buttAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttAdd.Location = new System.Drawing.Point(82, 5);
            this.buttAdd.Name = "buttAdd";
            this.buttAdd.Size = new System.Drawing.Size(100, 42);
            this.buttAdd.TabIndex = 0;
            this.buttAdd.Text = "Dodaj";
            this.buttAdd.UseVisualStyleBackColor = true;
            // 
            // buttEdit
            // 
            this.buttEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttEdit.Location = new System.Drawing.Point(214, 5);
            this.buttEdit.Name = "buttEdit";
            this.buttEdit.Size = new System.Drawing.Size(100, 42);
            this.buttEdit.TabIndex = 1;
            this.buttEdit.Text = "Edytuj";
            this.buttEdit.UseVisualStyleBackColor = true;
            this.buttEdit.Click += new System.EventHandler(this.buttEdit_Click);
            // 
            // buttDel
            // 
            this.buttDel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttDel.Location = new System.Drawing.Point(346, 5);
            this.buttDel.Name = "buttDel";
            this.buttDel.Size = new System.Drawing.Size(100, 42);
            this.buttDel.TabIndex = 2;
            this.buttDel.Text = "Skasuj";
            this.buttDel.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pNameDataGridViewTextBoxColumn,
            this.pLastNameDataGridViewTextBoxColumn,
            this.pDOBDataGridViewTextBoxColumn,
            this.pCityDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bsPacjenci;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(531, 379);
            this.dataGridView1.TabIndex = 1;
            // 
            // pNameDataGridViewTextBoxColumn
            // 
            this.pNameDataGridViewTextBoxColumn.DataPropertyName = "PName";
            this.pNameDataGridViewTextBoxColumn.HeaderText = "PName";
            this.pNameDataGridViewTextBoxColumn.Name = "pNameDataGridViewTextBoxColumn";
            this.pNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pLastNameDataGridViewTextBoxColumn
            // 
            this.pLastNameDataGridViewTextBoxColumn.DataPropertyName = "PLastName";
            this.pLastNameDataGridViewTextBoxColumn.HeaderText = "PLastName";
            this.pLastNameDataGridViewTextBoxColumn.Name = "pLastNameDataGridViewTextBoxColumn";
            this.pLastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pDOBDataGridViewTextBoxColumn
            // 
            this.pDOBDataGridViewTextBoxColumn.DataPropertyName = "PDOB";
            this.pDOBDataGridViewTextBoxColumn.HeaderText = "PDOB";
            this.pDOBDataGridViewTextBoxColumn.Name = "pDOBDataGridViewTextBoxColumn";
            this.pDOBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pCityDataGridViewTextBoxColumn
            // 
            this.pCityDataGridViewTextBoxColumn.DataPropertyName = "PCity";
            this.pCityDataGridViewTextBoxColumn.HeaderText = "PCity";
            this.pCityDataGridViewTextBoxColumn.Name = "pCityDataGridViewTextBoxColumn";
            this.pCityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsPacjenci
            // 
            this.bsPacjenci.DataSource = typeof(Klinika_psychiatryczna.Models.Pacjent);
            // 
            // TablePacjentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 445);
            this.Controls.Add(this.panel1);
            this.Name = "TablePacjentForm";
            this.Text = "Pacjenci Kliniki";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPacjenci)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button buttAdd;
        private System.Windows.Forms.Button buttEdit;
        private System.Windows.Forms.Button buttDel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bsPacjenci;
        private System.Windows.Forms.DataGridViewTextBoxColumn pNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pDOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pCityDataGridViewTextBoxColumn;
    }
}