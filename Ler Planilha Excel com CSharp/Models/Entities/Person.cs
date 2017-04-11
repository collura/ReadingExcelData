using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ler_Planilha_Excel_com_CSharp.Models
{
    public class Person
    {
        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _nome;
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        
        private string _rg;
        public string Rg
        {
            get { return _rg; }
            set { _rg = value; }
        }
        
        private string _cpf;
        public string Cpf
        {
            get { return _cpf; }
            set { _cpf = value; }
        }


        private string _nasc;
        public string Nasc
        {
            get { return _nasc; }
            set { _nasc = value; }
        }

        private string _re;
        public string Re
        {
            get { return _re; }
            set { _re = value; }
        }

        private string _end;
        public string End
        {
            get { return _end; }
            set { _end = value; }
        }

    }    
}
