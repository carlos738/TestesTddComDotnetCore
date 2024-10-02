using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewsTalents.Models;
using Xunit;

namespace TestNewsTalents
{
    public class CalculadoraTests
    {
        public Calculadora construirClasse(){
            string data = "01/10/2024";
            Calculadora calc = new Calculadora(data);
            return calc;
        }
        [Theory]
        [InlineData(4,3,7)]
        [InlineData(12.4,12,24.4)]
        [InlineData(7,2,9)]
        public void TestSomar(int valor1,int valor2,int resultado){
            Calculadora calc  = construirClasse();
            int resultadoCalculadora = calc.somar(valor1,valor2);
            Assert.Equal(resultado, resultadoCalculadora);
        }
        [Theory]
        [InlineData(34,10,340)]
        [InlineData(2,4,8)]
        [InlineData(5,5,25)]
        public void Testmultiplicar(int valor1,int valor2,int resultado){
            Calculadora calc = construirClasse();
            int resultadoCalculadora = calc.multiplicar(valor1,valor2);
            Assert.Equal(resultado,resultadoCalculadora);
        }
        [Theory]
        [InlineData(2,4,-2)]
        [InlineData(24,10,14)]
        [InlineData(32,16,16)]
        public void TestSubtrair(int valor1,int valor2,int resultado){
            Calculadora calc = construirClasse();
            int resultadoCalculadora = calc.subtrair(valor1,valor2);
            Assert.Equal(resultado,resultadoCalculadora);
        }
        [Theory]
        [InlineData(24,4,6)]
        [InlineData(5,5,1)]
        [InlineData(34,3,102)]
        public void TestDividir(int valor1,int valor2,int resultado){
            Calculadora calc = construirClasse();
            int resultadoCalculadora = calc.dividir(valor1,valor2);
            Assert.Equal(resultado,resultadoCalculadora);
        }
        [Fact]
        public void TestarDivisaoPorZero(){
            Calculadora calc = construirClasse();
            Assert.Throws<DivideByZeroException>(()=> calc.dividir(7, 0));

            
        }
        [Fact]
        public void TestarHistorico(){
            Calculadora calc = construirClasse();

            calc.somar(2,1);
            calc.somar(23,61);
            calc.somar(2,18);
            calc.somar(9,11);
            
            calc.subtrair(2,0);
            calc.subtrair(23,19);
            calc.subtrair(23,98);
            calc.subtrair(12,8);
            


            var lista = calc.historico();

            Assert.NotEmpty(calc.historico());
            Assert.Equal(3,lista.Count);

        }
        

    }
}