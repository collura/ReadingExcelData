using Ler_Planilha_Excel_com_CSharp.Models;
using Ler_Planilha_Excel_com_CSharp.Models.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ler_Planilha_Excel_com_CSharp
{
    class Program
    {
                
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("\nDigite um termo para pesquisa:");
                var valor = Console.ReadLine();

                Console.Clear();
                Console.WriteLine("\nRealizando Pesquisa, aguarde ...");                

                List<Person> Persons = new List<Person>();
                Persons = PersonDirectoryService.getPersons("Select * from [efetivo$] where rg like '%" + valor + "%'" +
                                                          "Or nome like '%" + valor + "%'" +
                                                          "Or cpf like '%" + valor + "%'" +
                                                          "Or nasc like '%" + valor + "%'" +
                                                          "Or re like '%" + valor + "%'").Persons;
                                                          // "Or end like '%" + valor + "%';").Persons;
                if (Persons.Count > 0)
                {
                    Console.Clear();
                    Console.WriteLine("\nResultado da Pesquisa por " + valor + ":");
                    foreach (var i in Persons)
                        Console.WriteLine(String.Format("\n\n- id: {0}\n- nome: {1}\n- Rg: {2}\n- Cpf: {3}\n- Nasc: {4}\n- Re: {5}\n- Endereço: {6}",
                                                        i.Id, i.Nome, i.Rg, i.Cpf, i.Nasc, i.Re, i.End));
                    Persons.Clear();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\nNenhum registro encontrado !");
                }
                Console.WriteLine();
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
