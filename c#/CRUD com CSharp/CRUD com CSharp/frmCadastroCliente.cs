using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_com_CSharp
{
    public partial class frmCadastroCliente : Form
    {
        string connectionString = @"Server=.\sqlexpress;Database=bdcadastro;Trusted_Connection=True;";
        bool novo;
        public frmCadastroCliente()
        {
            InitializeComponent();
        }

        private void frmCadastroCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
