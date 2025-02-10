using System.Threading.Channels;

namespace Taferas
{
    class Tarefas
    {
        // public diz respeito se outros métodos poderão agir dentro, além disso, poder alterar os atributos
        // static diz respeito se a minha classe deverá ser instanciada

        //Isso aqui é um método
        public static void ImprimirCabecalho()
        {
            Console.WriteLine("Tarefas:");
        }

        static void Main()
        {
            while (true)
            {
                Console.WriteLine("\n=======================");
                Console.WriteLine("Gerador de Senhas");
                Console.WriteLine("=======================");
                Console.WriteLine("1 - ===================");
                Console.WriteLine("2 - ===================");
                Console.WriteLine("3 - ====================");
                Console.WriteLine("4 - ====================");
                Console.WriteLine("5 - =======================");
                
                string opcao = Console.ReadLine();

                if (opcao == "1")
                {
                    Console.Write("Digite o tamanho da senha: ");
                    int tamanho = int.Parse(Console.ReadLine());

                    Console.Write("Digite o tipo de senha (numeros, letras, especiais): ");
                    string tipo = Console.ReadLine().ToLower();

                    string senha = GerarSenha(tamanho, tipo);
                    Console.WriteLine($"Senha Gerada: {senha}");
                }
                else if (opcao == "2")
                {
                    Console.Write("Deseja salvar a senha atual em backup? (s/n): ");
                    string salvar = Console.ReadLine().ToLower();

                    if (salvar == "s")
                    {
                        Console.WriteLine("Senha salva no backup.");
                        SalvarBackup(senha);
                    }
                    else
                    {
                        Console.WriteLine("Nenhuma senha foi salva.");
                    }
                }
                else if (opcao == "3")
                {
                    RecuperarBackup();
                }
                else if (opcao == "4")
                {
                    Console.WriteLine("Saindo...");
                    break;
                }
                else
                {
                    Console.WriteLine("Opção inválida, tente novamente.");
                }
            }

        }
    }