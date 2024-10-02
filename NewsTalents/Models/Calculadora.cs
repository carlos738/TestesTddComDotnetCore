using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsTalents.Models
{
    public class Calculadora
    {
        private List<string> listaHistorico;
        private string data;

        public Calculadora(string data){
            listaHistorico = new List<string>();
            this.data = data;
        }
        public int somar(int valor1,int valor2){
            int resultado = valor1 + valor2;
            listaHistorico.Insert(0, "Res: " + resultado + "data: " + data );
            return resultado;

        }
        public int subtrair (int valor1,int valor2){
            int resultado = valor1 - valor2;
            listaHistorico.Insert(0, "Res: " + resultado + "data: " + data);
            return resultado;
        }
        public int multiplicar(int valor1,int valor2){
            int resultado = valor1 * valor2;
            listaHistorico.Insert(0, "Res: " + resultado + "data: " + data);
            return resultado;
        }
        public int dividir(int valor1,int valor2){
            int resultado = valor1 / valor2;
            listaHistorico.Insert(0, "Res: " + resultado + "data: " + data);
            return resultado;
        }
        public List<string> historico(){
            List<string> res;
            listaHistorico.RemoveRange(3, listaHistorico.Count - 3);
            return listaHistorico;
        } 
    }
}