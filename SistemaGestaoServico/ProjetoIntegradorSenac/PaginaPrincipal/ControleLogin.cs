using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ProjetoIntegradorSenac.PaginaPrincipal
{
    internal class ControleLogin
    {
        public static void ExecutarPrograma()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Bem vindo");
            Console.WriteLine("Digite 1 para fazer login ou 2 para se cadastrar");
            var opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    SistemaLogin();
                    break;
                case "2":
                    SistemaCadastro();
                    break;
            }
        }

        private static void SistemaLogin()
        {
            Console.Write("Entrar com usuário >");
            string user = Console.ReadLine();

            if (user == ("admin"))
            {   
                Console.Write("Digite sua senha >");
                string pass = Console.ReadLine();
                if(pass == ("admin"))
                {
                    Console.Clear();
                    MenuPrincipal.ExecutarMenuPrincipal();
                }
            }
            if (user == ("user"))
            {
                Console.Write("Digite sua senha >");
                string pass = Console.ReadLine();
                if (pass == ("user"))
                {
                    Console.Clear();
                    MenuPrincipal.ExecutarMenuPrincipal();
                }
            }
            else
            {
                Console.WriteLine("Usuário não cadastrado");
                Thread.Sleep(200);
                Console.WriteLine("Clique 1 para tentar novamente ou 2 para se cadastrar");
                var opcaoErrorLogin = Console.ReadLine();

                switch (opcaoErrorLogin)
                {
                    case "1":
                        SistemaLogin();
                        break;
                    case "2":
                        SistemaCadastro();
                        break;
                }
            }
        }

        private static void SistemaCadastro()
        {
            Console.WriteLine("Crie a sua conta");
            Console.WriteLine("Digite o seu nome");
            var nomeCadastro = Console.ReadLine();

            Console.WriteLine("Digite o seu email");
            var emailCadastro = Console.ReadLine();

            Console.WriteLine("Digite a sua senha");
            var senhaCadastro = Console.ReadLine();

            // validação de cadastro
        }


    }
}
