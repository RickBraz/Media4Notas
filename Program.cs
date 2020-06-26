using System;

namespace Media4Notas
{
    class Program
    {
        static void Main(string[] args)
        {
     /*  [console: Media4Notas] Receba 4 notas, com somente uma casa decimal.
     Valide se todas estão entre 0.0 e 10.0.
     Se alguma delas não estiver, exiba "Digite somente notas entre 0 e 10.".
     Caso todas as notas sejam válidas, calcule a média aritmética das notas.
     Exiba uma mensagem no seguinte padrão: "Você ficou com média 7,5. Resultado: Aprovado".

Resultados possíveis:

"Reprovado" para médias menores que 5.0
"Em recuperação" para médias entre 5.0 e 6.0
"Aprovado", para médias acima de 6.0*/
            
            Console.WriteLine("Media4Notas, digite 4 numeros");
            Console.Write("Digite o primeiro numero: ");
            decimal a = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite o segundo numero: ");
            decimal b = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite o terceiro numero: ");
            decimal c = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite o quarto numero: ");
            decimal d = Convert.ToDecimal(Console.ReadLine());
            decimal media = a + b + c + d;
            decimal mediafinal = media / 4;
            
            if (a <= 0 || a >= 10 ||
                b <= 0 || b >= 10 ||
                c <= 0 || c >= 10 ||
                d <= 0 || d >= 10) 
              {
                Console.WriteLine("Digite somente numeros entre 0 e 10");
              }
               
            else if (mediafinal <= 5 )
          {
             Console.WriteLine($" media {mediafinal:N1} Reprovado");
          }
           
          else if (media >= 4 || media <= 7)
          {
              Console.WriteLine($" media {mediafinal:N1} Recuperaçao");
          }
          else 
          {
              Console.WriteLine($" media {mediafinal:N1}  Aprovado");
          }
        }
    }
}
