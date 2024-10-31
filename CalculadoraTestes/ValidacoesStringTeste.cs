using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculadora.Services;

namespace CalculadoraTestes
{
    public class ValidacoesStringTeste
    {
        private ValidacoesString _validacoes;
        public ValidacoesStringTeste()
        {
           _validacoes = new ValidacoesString();
        }

        [Fact]
        public void DeveContar3CaracteresEmOlarERetornar3()
        {
            //Arange
            string texto = "Ola";

            //Act
            int resultado = _validacoes.ContarCaracteres(texto);

            //Assert
            Assert.Equal(3, resultado);
        }
    } 
}