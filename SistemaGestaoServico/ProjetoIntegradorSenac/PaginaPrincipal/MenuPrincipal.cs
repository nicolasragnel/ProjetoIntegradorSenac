using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIntegradorSenac.PaginaPrincipal
{
    class MenuPrincipal
    {
        public static void ExecutarMenuPrincipal()
        {
            Console.WriteLine("Bem vindo");
            Console.WriteLine("Digite o número correspondente a opção desejada");
            Console.WriteLine("1 -> Comprar um dos nossos serviços ");
            Console.WriteLine("2 -> Alterar serviço");
            Console.WriteLine("3 -> Cancelar Serviço");
            var opcaoServico = Console.ReadLine();

            switch (opcaoServico)
            {
                case "1":
                    GestaoServicos.CompraServico.ListarServicos();
                    break;
                case "2":
                    // abrir menu de alteração
                    break;
                case "3":
                    // cancelar serviço
                    break;
            }
        }
    }
}
