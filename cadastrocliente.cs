using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cadastrodeclientesebd
{
    public partial class cadastrocliente : Form
    {
        public cadastrocliente()
        {
            InitializeComponent();
        }

        private void tbclientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbclientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bdSistemaGeralDataSet);

        }

        private void cadastrocliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdSistemaGeralDataSet.tbclientes'. Você pode movê-la ou removê-la conforme necessário.
            this.tbclientesTableAdapter.Fill(this.bdSistemaGeralDataSet.tbclientes);

        }

        private void tbclientesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
