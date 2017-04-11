using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ler_Planilha_Excel_com_CSharp.Models.Services
{
    public class PersonDirectoryService
    {
        private static OleDbConnection connect = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source =C:\Users\Betto\Desktop\BDTesteExcel.xlsx;Extended Properties='Excel 12.0 Xml;HDR=Yes';");  
        public static PersonDirectory getPersons(string stringSql) {

            PersonDirectory personDirectory = new PersonDirectory();
            string sql = stringSql;
            OleDbCommand command = new OleDbCommand(sql, connect);

            try
            {            
                connect.Open();
                OleDbDataReader rd = command.ExecuteReader();

                while (rd.Read())
                {
                    personDirectory.Persons.Add(new Person()
                    {
                        Id = Convert.ToInt32(rd["id"]),
                        Nome = rd["nome"].ToString(),
                        Rg = rd["rg"].ToString(),
                        Cpf =rd["cpf"].ToString(),
                        Nasc = rd["nasc"].ToString().Replace("00:00:00", ""),
                        Re = rd["re"].ToString(),
                        End = rd["end"].ToString()
                    });
                }
                return personDirectory;
            }
            catch (Exception e) {
                Console.WriteLine("Ocorreu o Seguinte erro ao tentar a consulta na base de dados:\n" + e.Message);
                return personDirectory;
            }
            finally {            
                connect.Close();               
            }
        }
    }
}
