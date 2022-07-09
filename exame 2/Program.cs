using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exame_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cidade = "";
            Console.WriteLine(" Escolha um número para representar a cidade desejada : \n\n1 – Atibaia\n2 – Bragança Paulista\n3 – Mairiporã\n4 – Nazaré\n5 – Terra Preta\n6 – Extrema\n7 – Vargem\n");
            int codigo = Convert.ToInt32(Console.ReadLine());
            if (codigo < 1 || codigo > 7)
            {
                Console.WriteLine("Número digitado errado tente novamente ");
                Console.ReadKey();
            }
            else
            {
                switch (codigo)
                {
                    case 1:
                        cidade = "Atibaia";
                        break;
                    case 2:
                        cidade = "Bragança paulista ";
                        break;
                    case 3:
                        cidade = "Mairiporã";
                        break;
                    case 4:
                        cidade = "Nazaré";
                        break;
                    case 5:
                        cidade = "Terra Preta";
                        break;
                    case 6:
                        cidade = "Extrema";
                        break;
                    case 7:
                        cidade = "Vargem";
                        break;
                }

                Console.WriteLine("Digite uma data em formato: dd/mm/aaaa. ");

                var datan = Convert.ToDateTime(Console.ReadLine());

                int datames, datadia, dataano;
                datames = datan.Month;
                datadia = datan.Day;
                dataano = datan.Year;
                string mes3 = Dataextenso(datames);
                Console.WriteLine(cidade + " , dia " + datadia + " de " + mes3 + " de " + dataano);
                Console.ReadKey();

            }
        }
        static public string Dataextenso(int mes)
        {
            string mesextenso = null;

            switch (mes)
            {
                case 1:
                    mesextenso = "Janeiro";
                    break;
                case 2:
                    mesextenso = "Fevereiro";
                    break;
                case 3:
                    mesextenso = "Março";
                    break;
                case 4:
                    mesextenso = "Abril";
                    break;
                case 5:
                    mesextenso = "Maio";
                    break;
                case 6:
                    mesextenso = "Junho";
                    break;
                case 7:
                    mesextenso = "Julho";
                    break;
                case 8:
                    mesextenso = "Agosto";
                    break;
                case 9:
                    mesextenso = "Setembro";
                    break;
                case 10:
                    mesextenso = "Outubro";
                    break;
                case 11:
                    mesextenso = "Novembro";
                    break;
                case 12:
                    mesextenso = "Dezembro";
                    break;
            }
            string mes2 = mesextenso;
            return mes2;

        }
    }
}
