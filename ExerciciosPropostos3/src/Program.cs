using System;
using System.Globalization;

namespace ExerciciosPropostos3 {
    class Program {
        static void Main(string[] args) {

            /* EXERCÍCIO 1:
            int senha;
            Console.WriteLine("Insira a senha: ");
            senha = int.Parse(Console.ReadLine());
            while(senha != 2002) {
                Console.WriteLine("Senha inválida");
                Console.WriteLine("Insira a senha: ");
                senha = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso permitido");*/

            /* EXERCÍCIO 2:
            string[] valores = Console.ReadLine().Split(' ');
            int x = int.Parse(valores[0]);
            int y = int.Parse(valores[1]);
            while (x != 0 && y != 0) {
                if (x > 0 && y > 0) {
                    Console.WriteLine("Primeiro Quadrante");
                }
                else if (x < 0 && y > 0) {
                    Console.WriteLine("Segundo Quadrante");
                }
                else if (x < 0 && y < 0) {
                    Console.WriteLine("Terceiro Quadrante");
                }
                else {
                    Console.WriteLine("Quarto Quadrante");
                }
                valores = Console.ReadLine().Split(' ');
                x = int.Parse(valores[0]);
                y = int.Parse(valores[1]);
            }*/

            /* EXERCÍCIO 3:
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;
            int tipo;
            Console.WriteLine("Informe o tipo de combustível abastecido (1 = ÁLCOOL, 2 = GASOLINA, 3 = DIESEL, 4 = SAIR");
            tipo = int.Parse(Console.ReadLine());
            while (tipo != 4) {
                if(tipo == 1) {
                    alcool++;
                }else if(tipo == 2) {
                    gasolina++;
                }else if(tipo == 3) {
                    diesel++;
                }
                Console.WriteLine("Insira um código válido: ");
                tipo = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Álcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);*/
        }
    }
}