using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectIP
{
    class Intrebare
    {
        private string _intrebare;
        private List<string> _raspunsuri;
        private int _indexRaspunsCorect;
        public string GetIntrebare
        {
            get
            {
                return this._intrebare;
            }
        }

       public List<string> GetRaspunsuri
        {
            get
            {
                return this._raspunsuri;
            }
        }

        public string GetRaspunsCorect
        {
            get
            {
                return this._raspunsuri[this._indexRaspunsCorect];
            }
        }

        public int GetIndexRaspunsCorect
        {
            get
            {
                return this._indexRaspunsCorect;
            }
        }

        public Intrebare(string intrebare,string raspuns1,string raspuns2,string raspuns3,string raspuns4,int indexRaspunsCorect)
        {
            this._intrebare = intrebare;
            this._indexRaspunsCorect = indexRaspunsCorect;
            this._raspunsuri = new List<string>();
            this._raspunsuri.Add(raspuns1);
            this._raspunsuri.Add(raspuns2);
            this._raspunsuri.Add(raspuns3);
            this._raspunsuri.Add(raspuns4);
        }
    }
}
