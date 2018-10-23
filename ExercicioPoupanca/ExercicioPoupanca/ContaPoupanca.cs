using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPoupanca
{
    class ContaPoupanca
    {
        
        
            // Atributos da Classe ContaPoupanca

            private static double TaxaDeJurosAnual;
            private double saldoPoupanca;

            // Construtor da Classe

            public ContaPoupanca()
            {
                TaxaDeJurosAnual = 0;
                saldoPoupanca = 0;
            }

            // Assinatura da Classe

            public ContaPoupanca(double saldoPoupanca)
            {
                this.saldoPoupanca = saldoPoupanca;
                TaxaDeJurosAnual = 0;
            }

            // Método CalcularJuromensal

            public double CalcularJuromensal()
            {
                double juroMensal = ((saldoPoupanca * TaxaDeJurosAnual) / 12) + saldoPoupanca;
                return juroMensal;
            }

            // Método para Alterar a taxaDeJurosAnual

            public static void AlterarTaxaDeJuros(double taxaDeJuros)
            {
                TaxaDeJurosAnual = taxaDeJuros;
            }

            // Configurar saldoPoupanca

            public double saldo
            {
                get
                {
                    return saldoPoupanca;
                }
                set
                {
                    saldoPoupanca = value;
                }
            }

            // Configurar taxaDeJurosAnual

            public static double taxaDeJuros
            {
                get
                {
                    return taxaDeJuros;
                }
                set
                {
                    taxaDeJuros = value;
                }
            }
        }
    }


