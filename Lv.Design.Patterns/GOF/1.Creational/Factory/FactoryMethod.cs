using Lv.Design.Patterns.GOF.Creational.Factory.Interfaces;
using Lv.Design.Patterns.GOF.Creational.Factory.Class;
using System;

namespace Lv.Design.Patterns.GOF.Factory
{
    public enum eMontadora
    {
        Nao_Definido = 0,
        Fiat = 1,
        Ford = 2,
        Volkswagen = 3
    }

    public class FactoryMethod
    {
        public IMontadora FactoryMontadora(eMontadora eMontadora) {
            switch (eMontadora)
            {
                case eMontadora.Fiat:
                    return new Fiat();
                case eMontadora.Ford:
                    return new Ford();
                case eMontadora.Volkswagen:
                    return new Volkswagen();
                default:
                    throw new Exception("Montadora não foi definida");
            }
        }
    }
}

