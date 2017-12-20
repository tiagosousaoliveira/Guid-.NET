using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilizacaoGUIDmodificado
{
    class Program
    {
        static void Main(string[] args)
        {

            var user = new User
            {
                _Id = ModificacaoGuid.modficandoguid(),
                datacadastro = DateTime.Now,
                nome = "Usuario TESte"

            };

            Console.WriteLine("Nome Do Usuario : " + user.nome);
            Console.WriteLine("Data de Cadastro : " + user.datacadastro);
            Console.WriteLine("Este é O Guid tipo X: " + user._Id);
            Console.ReadLine();

            //Dessa Forma o Guid terá que ser convertido em String para ter um padrão maior de combinações 
            //e a Chave _id Tera que receber essa String.

        }
    }
}
