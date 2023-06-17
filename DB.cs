using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Net;
using System.Net.Mail;

namespace V_1._0
{
    internal class DB
    {
        //Conecta com o Banco de Dados.
        public void datastart()
        {
            //Tenta conectar, se não der certo ele mostra uma caixa de erro dizendo que não deu certo.
            try
            {
                string connectionString = "Data Source=JORGE;Initial Catalog=DB1;;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                Console.WriteLine("Conexão Bem Sussedida");
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao se conectar no banco de dados \n" + "Verifique os dados informados");
            }
        }


        //Usa uma tabela dentro do banco de dados para fazer um sistema de login
        public string email;
        public string senha;

        public void datalogin()
        {
            //tenta conectar, se não der certo ele mostra uuma mensagem de erro.
            try
            {
                string connectionString = "Data Source=JORGE;Initial Catalog=DB1;;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                Console.WriteLine("Conexão Bem Sussedida");

                // Executa uma consulta na tabela referente a senha e o email
                string a = "SELECT senha, email FROM identify";
                SqlCommand command = new SqlCommand(a, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string senha1 = reader.GetString(0);
                    string email1 = reader.GetString(1);
                    //se a senha e o email forem os corretos ele permite entrar, se não ele mostra uma caixa de erro dizendo que não esta certo
                    if(email1 == email)
                    {
                        if (senha1 == senha)
                        {
                            MessageBox.Show("Você Entrou!");
                            Form1 Form11 = new Form1();
                            Form11.Show();
                        }
                        else
                        {
                            MessageBox.Show("Email ou Senha Incorretos");
                        }
                    }
                    else
                    {
                    }
                }
                reader.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao tentar consultar!");
            }
        }

        //Faz uma consulta no banco de dados
        public string valor_consult;
        public void dataconsultemail()
        {   
            //Tenta conectar com o banco de dados, caso não consiga mostra uma mensagem de erro
            try
            {
                string connectionString = "Data Source=JORGE;Initial Catalog=DB1;;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                Console.WriteLine("Conexão Bem Sussedida");

                // Executa uma consulta
                string ab = "SELECT nome, email, produto FROM product WHERE produto = '" + valor_consult + "'";
                SqlCommand command = new SqlCommand(ab, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string nome = reader.GetString(0);
                    string email = reader.GetString(1);
                    string produto = reader.GetString(2);

                    Console.WriteLine("Nomes: '"+ nome + "'");
                    Console.WriteLine("Produto: '" + produto + "'");
                    Console.WriteLine("Emails: '" + email + "'");

                    //Invoca a classe email e define as propiedades e usa o método envemail para enviar um email
                    Email envemail = new Email();
                    envemail.empresaemailEM = email;
                    envemail.empresanomeEM = nome;
                    envemail.produtoEM = produto;
                    envemail.EnvEmail();
                }
                reader.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao tentar consultar!");
            }
        }
    }
}
