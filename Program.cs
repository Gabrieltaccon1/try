using System;
using System.Globalization;


namespace Try_cath_finally
{
    class Program
    {
        static void Main(string[] args)
        {
            //

            string retorno = "";



            do
            {

                try
                {

                    double notaA, notaB, notaC, media;



                    Console.WriteLine("DIGITE A PRIMEIRA NOTA");
                    notaA = double.Parse(Console.ReadLine());
                    while (notaA < 0 || notaA > 10)
                    {
                        Console.WriteLine("A NOTA É COMPOSTA POR UM VALOR ENTRE 0 e 10");
                        notaA = int.Parse(Console.ReadLine());
                    }

                    Console.WriteLine("DIGITE A segunda NOTA");
                    notaB = double.Parse(Console.ReadLine());
                    while (notaB < 0 || notaB > 10)
                    {
                        Console.WriteLine("A NOTA É COMPOSTA POR UM VALOR ENTRE 0 e 10");
                        notaB = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("DIGITE A terceira NOTA");
                    notaC = double.Parse(Console.ReadLine());
                    while (notaC < 0 || notaC > 10)
                    {

                        Console.WriteLine("A NOTA É COMPOSTA POR UM VALOR ENTRE 0 e 10");
                        notaC = int.Parse(Console.ReadLine());
                    }

                    media = ((notaA * 2.0 + notaB * 3.0 + notaC * 5.0) / 10.0);

                    Console.WriteLine("MEDIA = " + media.ToString("F1", CultureInfo.InvariantCulture));

                }

                catch (FormatException ex)
                {
                    Console.WriteLine("A NOTA É COMPOSTA APENAS POR VALORES NUMERICOS!");
                }

                Console.WriteLine("\n DESEJA INICIAR UMA NOVA CONSULTA? SIM / NÃO ");
                retorno = Console.ReadLine();

            } while (retorno == "SIM" || retorno == "sim");


        }
    }
}


