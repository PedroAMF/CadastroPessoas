using System;

namespace CadastroPessoas {
    class Program {
        static void Main (string[] args) {

            Pessoas[] inserirPessoa = new Pessoas[5];
            var indicePessoa = 0;

            string escolhaUsuario = ObterOpcaoUsuario ();

            while (escolhaUsuario.ToUpper () != "X") {
                switch (escolhaUsuario) {
                    case "1":
                        //TODO: Inserir nova Pessoa
                        Pessoas novo = new Pessoas ();
                        Console.WriteLine ("Informe o nome:");

                        novo.Nome = Console.ReadLine ();

                        Console.WriteLine ("Informe o endereço:");
                        novo.Endereco = Console.ReadLine ();

                        Console.WriteLine ("Informe o telefone:");

                        int telefone;

                        while (!int.TryParse (Console.ReadLine (), out telefone)) {
                            Console.WriteLine ("Por favor digite o número de telefone correto");
                        }
                        novo.Telefone = telefone;
                        inserirPessoa[indicePessoa] = novo;
                        indicePessoa++;

                        break;
                    case "2":
                        //TODO: Listar Pessoas
                        foreach (var a in inserirPessoa) {
                            if (a != null) {
                                if (!string.IsNullOrEmpty (a.Nome)) {
                                    Console.WriteLine ($"Nome: {a.Nome}\n Endereço: {a.Endereco}\n Telefone: {a.Telefone}\n");
                                }
                            } else {
                                break;
                            }
                        }
                        break;
                    default:
                        throw new ArgumentOutOfRangeException ("Valor informado não correspondente");
                }

                escolhaUsuario = ObterOpcaoUsuario ();
            }
        }

        private static string ObterOpcaoUsuario () {
            Console.WriteLine ();
            Console.WriteLine ("Informe a opção desejada:");
            Console.WriteLine ("1- Inserir Pessoa");
            Console.WriteLine ("2- Listar Pessoas");
            Console.WriteLine ("X- Sair");
            Console.WriteLine ();

            string escolhaUsuario = Console.ReadLine ();
            Console.WriteLine ();
            return escolhaUsuario;
        }
    }
}