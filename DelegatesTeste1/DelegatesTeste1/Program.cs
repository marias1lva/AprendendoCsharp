using System;
using DelegatesTeste1.Services;
namespace DelegatesTeste1 {

    // Definião de um delegate chamado BinaryNumericOperation 
    delegate double BinaryNumericOperation(double n1, double n2); // Ele espera dois parâmetros do tipo double e retorna um double
    class Program {
        static void Main(string[] args) {
            double a = 10;
            double b = 12;

            // Atribuindo o método Sum (da classe CalculationService) ao delegate 'op'
            BinaryNumericOperation op = CalculationService.Sum; // 'op' agora pode ser usado para invocar a função Sum
            //double result = op(a, b);
            double result = op.Invoke(a, b); // Invocação do método associado ao delegate usando 'Invoke'
            Console.WriteLine("SUM = " + result); // Exibe a soma de a e b

            // Atribuindo o método Max (da classe CalculationService) ao delegate 'op'
            op = CalculationService.Max; // 'op' agora aponta para uma função que retorna o maior valor entre dois números
            //result = op(a, b);
            result = op.Invoke(a, b); // Invoca o método Max usando o delegate
            Console.WriteLine("MAX = " + result); // Exibe o maior número entre a e b


            /* Abaixo, temos chamadas diretas dos métodos CalculateService, sem o uso de delegates. 
               Esse trecho está comentado, mas serve como comparação para entender o propósito dos delegates

            double result = CalculationService.Sum(a, b);
            Console.WriteLine("SUM = " + result);
            Console.WriteLine();

            result = CalculationService.Max(a, b);
            Console.WriteLine("MAX = " + result);
            Console.WriteLine();

            result = CalculationService.Square(a);
            Console.WriteLine("SQUARE = " + result);
            Console.WriteLine(); */
        }
    }
}

/*         
            - op = CalculationService.Square;
            result = op(a);
            Console.WriteLine("SQUARE = " + result);
            
            NÃO FUNCIONA, qualquer método atribuído a 'op' deve aceitar dois parâmetros do tipo double. Porém, O método Square aceita apenas um parâmetro, 
            mas o delegate BinaryNumericOperation exige dois. Por isso, ocorre um erro de incompatibilidade de assinatura.

            
            - 'Invoke' = embora seja possível chamar diretamente com 'op(a, b)', 'Invoke' torna o processo explícito
*/