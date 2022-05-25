using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectIP
{
    /// <summary>
    /// Clasa de exceptie utilizata la crearea unei intrebari de catre un user cu drepturi de admin. Exceptia este aruncata atunci cand lipseste intrebarea sau unul dintre raspunsuri.
    /// </summary>
    class InregistrareIntrebareException:Exception
    {
        private string _message;
        public InregistrareIntrebareException(string message):base(message)
        {
            this._message = message;
        }
        public string GetMessage
        {
            get
            {
                return this._message;
            }
        }
    }
}
