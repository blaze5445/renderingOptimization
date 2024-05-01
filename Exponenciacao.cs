using System;


namespace FermatP
{
    class Exponenciacao
    {
        public Byte Base { get; private set;}
        public Byte Expoente { get; private set; }
        public ulong Potencia { get; private set; }

        public Exponenciacao(Byte _base)
        {
            this.Base = _base;
        }

        public void SetExpoente(Byte _expoente)
        {
            this.Expoente = _expoente;
            this.Potencia = 1;
            CalcPotencia();
        }

        private void CalcPotencia()
        {
            Byte byte0 = 0;
            Byte byte1 = 1;
            Byte _expoente = this.Expoente;

            while (_expoente > byte0)
            {
                this.Potencia = Calculadora.multiplicar(this.Potencia, this.Base);
                _expoente -= byte1;
            }
        }

        public override string ToString()
        {
            return $"{this.Base}^{this.Expoente} = {this.Potencia}";
        }
    }
}
