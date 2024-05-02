using System;
using System.Collections.Generic;

namespace FermatP
{
    class Equacao
    {

        public Exponenciacao A { get; private set; }
        public Exponenciacao B { get; private set; }
        public Exponenciacao C { get; private set; }
        public Byte ExpoenteGeral { get; private set; }
        public ulong SomaDasPotencias { get; private set; }
        public bool ResultaEmNove { get; private set; }

        public Equacao (Byte _baseA, Byte _baseB, Byte _baseC)
        {
            this.A = new Exponenciacao(_baseA);
            this.B = new Exponenciacao(_baseB);
            this.C = new Exponenciacao(_baseC);
        }

        public void SetExpoente(Byte _expoente)
        {
            this.ExpoenteGeral = _expoente;
            RecalcularPotencias();
        }

        private void RecalcularPotencias()
        {
            A.SetExpoente(this.ExpoenteGeral);
            B.SetExpoente(this.ExpoenteGeral);
            C.SetExpoente(this.ExpoenteGeral);
            SomarPotencias();
            VerificarSeResultaEmNove();
        }

        private void SomarPotencias()
        {
            SomaDasPotencias = Calculadora.somarPotencias(new List<ulong> { A.Potencia, B.Potencia, C.Potencia });
        }
        private void VerificarSeResultaEmNove()
        {
            string algarismos = "" + this.SomaDasPotencias;
            while (algarismos.Length > 1)
            {
                algarismos = Calculadora.somarAlgarismos(algarismos.ToCharArray());
            }

            Console.WriteLine(algarismos);
            this.ResultaEmNove = algarismos.Equals("9");
        }

        public override string ToString()
        {
            return $"Soma das potências: {this.SomaDasPotencias}" +
                $"\n A: {this.A}" +
                $"\n B: {this.B}" +
                $"\n C: {this.C}" +
                $"\nResulta em nove? {this.ResultaEmNove}";
        }

    }
}
