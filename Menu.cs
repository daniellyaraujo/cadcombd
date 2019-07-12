using System;
using System.Windows.Forms;

namespace cadastrodeclientesebd
{
    public partial class Menu : Form
    {
        public Menu() 
        {
            InitializeComponent();
        }

        private void btcadclientes_Click(object sender, EventArgs e)
        {
            cadastrocliente clientes = new cadastrocliente();
            clientes.ShowDialog();
        }
    }
}
