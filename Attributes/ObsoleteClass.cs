using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    class ObsoleteClass
    {
        [Obsolete("Uzyj metody newMethod")]
        public string OldMethod()
        {
            try
            {
                //proba pol z serv X
                throw new Exception("serv nie odpowiada");
            }
            catch (Exception)
            {
                // logowanie
                
            }
            return nameof(OldMethod);
        }
        public string NewMethod()
        {


            return nameof(NewMethod);
        }
    }
}
