using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bin2Dec.Clases
{
    class conversiones
    {
        public int Binario_Decimal(long Binario)
        {
            int numero = 0;
            int digito = 0;
            const int Divisor = 10;

            for(long i = Binario, j = 0; i > 0; i /= Divisor, j++)
            {
                digito = (int)i % Divisor;
                if (digito != 1 && digito != 0)
                {
                    return -1;
                }
                numero += digito * (int)Math.Pow(2, j);
            }
            return numero;
        }
    }
}
