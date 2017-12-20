using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilizacaoGuid_e_Persistindo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var user = new User
            {
                _id = Guid.NewGuid(),  // Se o responsavel pela Criação do Guid for o Entity o mesmo não deverá ser incluso Aqui.
                nome = "Usuario Teste",
                datacadastro = DateTime.Now
            };

            // Mostra de Forma Simples os dados 
            Console.WriteLine("Dados = " + user.nome);
            Console.WriteLine("Dados = " + user.datacadastro);
            Console.WriteLine("Dados = " + user._id);

            Console.WriteLine(Environment.NewLine); // Pula uma linha

            //Busca os Dados Gravados no Banco de Dados e Escreve na Tela
            using (DataContext context = new DataContext()) 
            {
                context.User.Add(user);
                context.SaveChanges();

                foreach (var users in context.User)
                {
                    Console.WriteLine(String.Format("{0}\n,{1}\n,{2}", user.nome,user.datacadastro, user._id));
                }
            }
        }

    }
}
