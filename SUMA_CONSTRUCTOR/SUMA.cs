using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUMA_CONSTRUCTOR
{
    internal class SUMA
    { //campos, propiedades, como es 
        private float n1, n2;
        //constructor
        public SUMA(float n1, float n2)
        {
            this.n1 = n1;
            this.n2 = n2;
        }
        public float sumar()
        {
            return (n1 + n2);
        }
    }
}
 