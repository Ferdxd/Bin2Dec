using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bin2Dec.Clases
{
    class Validaciones
    {

        public bool maxDigitos(string cadena)
        {
            if (cadena.Length <= 8)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool validacionCaracteresBin2(string cadena)
        {
            bool validar=true;
            for(int i = 0; i < cadena.Length; i++)
            {
                if (cadena[i] == '0'|cadena[i]=='1')
                {
                    validar = true;
                
                }
                else
                {
                    validar = false;
                    break;
                }
            
            }
            return validar;
        }
    }
}
