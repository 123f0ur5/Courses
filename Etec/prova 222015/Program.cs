namespace prova
{
    internal class Program
    {
        /*static List<string> fruta = new List<string>();
        static List<string> legume = new List<string>();
        static List<string> verdura = new List<string>();
        */
        static int contfruta = 0, contlegume = 0, contverdura = 0;
        static string[] fruta = new string[5];
        static string[] legume = new string[5];
        static string[] verdura = new string[5];
        static void Main(string[] args)
        {
            string resp;


            do
            {
                Console.WriteLine("Deseja cadastrar um produto? (S/N)");
                resp = Console.ReadLine().ToUpper();

                if (resp == "S")
                {
                    Console.WriteLine("Deseja cadastrar uma (F)ruta, (L)egume ou (V)erdura?");
                    string opcao = Console.ReadLine().ToUpper();

                    switch (opcao)
                    {
                        case "F":
                            cadFruta();
                            break;
                        case "L":
                            cadLegume();
                            break;
                        case "V":
                            cadVerdura();
                            break;
                        default:
                            Console.WriteLine("Opção não encontrada");
                            break;
                    }

                    /*if (opcao == "F" && fruta.Count() <= 4)
                    {
                        cadFruta();
                    }
                    else if (opcao == "L" && legume.Count() <= 4)
                    {
                        cadLegume();
                    }
                    else if (opcao == "V" && verdura.Count() <= 4)
                    {
                        cadVerdura();
                    }
                    else
                    {
                        Console.WriteLine("Opção não encontrada");
                    }*/
                }
            } while (resp == "S");

            /*if (fruta.Count() > 0) { 
                Console.WriteLine("Frutas Cadastradas: ");
                fruta.ForEach(Console.WriteLine);
            }
            if (legume.Count() > 0)
            {
                Console.WriteLine("Legumes Cadastrados: ");
                legume.ForEach(Console.WriteLine);
            }
            if (verdura.Count() > 0)
            {
                Console.WriteLine("Verduras Cadastradas: ");
                verdura.ForEach(Console.WriteLine);
            }*/
            Console.WriteLine("Frutas: ");
            for(int i = 0; i < contfruta; i++)
            {
                Console.WriteLine(fruta[i]);
            }
            Console.WriteLine("Legumes: ");
            for (int i = 0; i < contlegume; i++)
            {
                Console.WriteLine(legume[i]);
            }
            Console.WriteLine("Verduras: ");
            for (int i = 0; i < contverdura; i++)
            {
                Console.WriteLine(verdura[i]);
            }

            Console.ReadKey();
        }
        static void cadFruta()
        {
            if (contfruta <= 4)
            {
                Console.Write("Digite o nome da fruta: ");
                string nfruta = Console.ReadLine();

                fruta[contfruta] = nfruta;
                contfruta++;
            } else
            {
                Console.WriteLine("Array cheio");
            }
        }

        static void cadVerdura()
        {
            if (contverdura <= 4) { 
                Console.Write("Digite o nome da verdura: ");
                string nverdura = Console.ReadLine();

                verdura[contverdura] = nverdura;
                contverdura++;
            } else
            {
                Console.WriteLine("Array cheio");
            }
        }

        static void cadLegume()
        {
            if (contlegume <= 4) { 
                Console.Write("Digite o nome do legume: ");
                string nlegume = Console.ReadLine();

                legume[contlegume] = nlegume;
                contlegume++;
            } else
            {
               Console.WriteLine("Array cheio");
            }
        }
    }
}