using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace Frete
{
    public class CalculadorDeFrete
    {
        /// <summary>
        /// Calculo de frete para uma compra
        /// Vamos criar um programa que receba a distância entre o distribuidor e o local de entrega e calcule o valor do frete, sendo que para km é cobrado R$ 0,10 
        /// A cada 200 km, deve adicionar uma taxa de R$ 1,00A cada 1000 km, deve adicionar uma taxa de R$ 10,00
        /// Agora precisamos calcular o frete baseado no preço da encomenda
        /// O valor do frete não altera para produtos com até 5kg
        /// Multiplicar o valor do frete para produtos entre 5kg até 25kg em 5x
        /// Multiplicar o valor do frete para produtos entre 25kg até 75kg em 3x

        /// </summary>
        /// <param name="distancia"></param>
        /// <param name="peso"></param>
        /// <returns></returns>
        public double CalcularFrete(int distancia, int peso)
        {
            double CustoPorKm = 0.1, valorCauculo, custoPor200 = 1, custoPor1000 = 10;
            valorCauculo = distancia * CustoPorKm;

            valorCauculo += Math.Floor(distancia / 200.0) * custoPor200;
            valorCauculo += Math.Floor(distancia / 1000.0) * custoPor1000;
           if (peso >= 5 && peso <= 25 ) 
            {
                valorCauculo *= 5;
            }  else if (peso > 25 && peso <= 75) 
            {
               valorCauculo *= 3;
            }
            return valorCauculo;
        }
    }
}
