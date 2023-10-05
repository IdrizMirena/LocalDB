using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;

namespace Datababse_System_School
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
        // Materialskin.Con . materialform
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabelaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tabelaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.tabelaTableAdapter.Fill(this.database1DataSet.Tabela);

        }
    }
}
