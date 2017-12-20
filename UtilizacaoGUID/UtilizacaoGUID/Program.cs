using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilizacaoGUID
{
    class Program
    {
        static void Main(string[] args)
        {

            var user = new User
            {
                _id = Guid.NewGuid(),
                nome = "Usuario Teste",
                dataderegistro = DateTime.Now
            };

            Console.WriteLine("Dados do Usuario");
            Console.WriteLine("Nome do Usuario : " + user.nome + "\n");
            Console.WriteLine("Data do Cadastro: " + user.dataderegistro + "\n");
            Console.WriteLine("Guid do Usuario : " + user._id + "\n");

            Console.ReadKey();

        }
    }
}
