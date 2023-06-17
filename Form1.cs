using Microsoft.SqlServer.Dac.Model;
using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace V_1._0
{
    public partial class Form1 : Form
    {
        DB database = new DB();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void B_Enviar_Click(object sender, EventArgs e)
        {
            if (ML_Região.GetItemChecked(0)) 
            {
                if (ML_Produto.GetItemChecked(0))
                {
                    database.valor_consult = "Cama de aves";
                    database.dataconsultemail();
                }
            }
        }

        private void ML_Produto_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void ML_Região_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void L_NovoOrçamento_Click(object sender, EventArgs e)
        {
        }
    }
}
