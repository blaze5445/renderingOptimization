using System;
using System.Collections.Generic;
using System.Text;

namespace FermatP
{
    static class Calculadora
    {
        //Próximo Passo: Criar overrides para aceitar outros tipos de inteiros como int16, int32...
        public static ulong somarPotencias(List<ulong> listaPotencias)
        {
            ulong somaDasPotencias = 0;
            foreach(ulong potencia in listaPotencias)
            {
                somaDasPotencias += potencia;
            }
            return somaDasPotencias;
        }

        public static string somarAlgarismos(char[] algarismos)
        {
            int somaDosAlgarismos = 0;

            foreach(char c in algarismos)
            {
                somaDosAlgarismos += (int)Char.GetNumericValue(c);
            }
            
            return "" + somaDosAlgarismos;
        }

        public static ulong multiplicar(ulong _potencia, Byte _base)
        {
            return _potencia * _base;
        }
    }
}
