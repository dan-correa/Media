using System;

namespace Media
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota=0, media=0, media_aprovacao = 0;
            int avaliacoes=0, contador=0;
                               
            Console.WriteLine("Vamos Calcular a média");
            Console.WriteLine("Digite a média para aprovacao dessa matéria");
            media_aprovacao = int.Parse(Console.ReadLine());
            Console.WriteLine("Número de avaliações");
            avaliacoes = int.Parse(Console.ReadLine());

            while(contador < avaliacoes)
            {
             
                Console.WriteLine("Insira a nota da avaliação {0} de {1}, sendo que a avaliação zero é a primeira avaliação", contador, avaliacoes);
                nota = double.Parse(Console.ReadLine()) + nota;
                contador = contador + 1;

            }


            Console.WriteLine(nota);    
            media = nota / avaliacoes;

            if (media >= media_aprovacao)
                {
                Console.WriteLine("A média para aprovacao é {0} e sua média foi {1}, logo você foi aprovado", media_aprovacao, media);
                }
            else
                {
                Console.WriteLine("A média para aprovação é {0} e sua média foi {1}, logo você foi repovado", media_aprovacao, media);
                }


        }
    }
}
