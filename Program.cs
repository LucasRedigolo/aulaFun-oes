using System;

namespace aulaFun_oes
{
    class Program
    {
        static void Main (string [] args) {

            Console.WriteLine("Digite o primeiro valor");
            int valora = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor");
            int valorb = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Digite o tipo de operação");
            string operacao = Console.ReadLine();

            int resultado = Calculadora(valora, valorb, operacao);
            if(resultado != int.MinValue)
                Console.WriteLine("O resultado é :" + resultado); 

        }
        static int Calculadora(int a, int b, string tipo){

        int valor = 0;

           try{
              
            switch(tipo){
                case "+":
                    valor = a + b;
                    break;
                case "-":
                    valor = a - b;
                    break;
                case "*":
                    valor = a * b;
                    break;
                case "/":
                    valor = a / b;
                    break;
            }

            return valor;

           }
           
           catch(Exception ex)
           
           {
               System.Console.WriteLine(ex.Data);
               System.Console.WriteLine(ex.Message); // mostra o erro para o usuario

               return int.MinValue;
           }
        }

    }
}    