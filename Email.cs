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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace V_1._0
{
    internal class Email
    {
        //Define as propiedades que serão usadas no método EnvEmail
        public string produtoEM;
        public string empresaemailEM;
        public string empresanomeEM;

        //Método usado para enviar os emails
        public void EnvEmail()
        {
            //Define quais são as caracteristicas da mensagem
            var fromAddress = new MailAddress("mico736mmaa@gmail.com", "Minha Empresa");
            var toAddress = new MailAddress("t4igacomercial@gmail.com", empresanomeEM); //lembrar de substituir o email por empresaemailEM
            const string fromPassword = "lqwhhqpsqeiucgqx";
            string subject = "Consulta de preços referente ao produto " + produtoEM;
            string body = "Olá " + empresanomeEM + ", Nos somos a Minha empresa, estamos enviando esse email para solicitar um orçamento referente ao preço do produto " + produtoEM + ", Qual seria o preço?";

            //Conecta com o provedor de email por meio do smtpclient
            SmtpClient smtp = new SmtpClient();
            smtp.UseDefaultCredentials = false;
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(fromAddress.Address, fromPassword);

            //Associa a mensagema a o email que ira enviar e aos emails que irao receber
            MailMessage message = new MailMessage(fromAddress, toAddress);
            message.Subject = subject;
            message.Body = body;

            //Tenta enviar o email, se der errado ele da uma mensagem de erro no console dizendo o erro
            try
            {
                smtp.Send(message);
            }

            catch (Exception x)
            {
                Console.WriteLine("Deu Errado e o Motivo é:" + x);
                string X = x.ToString();
                MessageBox.Show(X);
            }
        }
    }
}

