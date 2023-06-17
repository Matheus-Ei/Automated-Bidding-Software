using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace V_1._0
{
    public partial class Form2 : Form
    {
        DB database = new DB();
        public Form2()
        {
            database.datastart();
            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            database.email = textBox1.Text;
            database.senha = textBox2.Text;

            database.datalogin();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
