using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_de_Lógica
{
    class Program
    {
        static void Main(string[] args)
        {
            Questao3();
        }
        static void Questao1_2()
        {
            int preposicaoQtd = 0;
            int verbosQtd = 0;
            int verbosPrimeiraPessoaQtd = 0;

            string[] letrasTipoFoo = { "s", "l", "f", "w", "k" };
            string letraD = "d";

            // ler arquivo.
            var texto = new StreamReader(@"App_Data/klingon-textoB.txt").ReadLine();

            foreach (var item in texto.ToString().Split(' '))
            {
                if (item.Count() == 3 && !letrasTipoFoo.Contains(item.Substring(item.Length - 1)) && !letraD.Contains(item.Substring(item.Length - 1)))
                    preposicaoQtd++;

                if (item.Count() >= 8 && letrasTipoFoo.Contains(item.Substring(item.Length - 1)))
                {
                    if (!letrasTipoFoo.Contains(item.Substring(0, 1)))
                        verbosPrimeiraPessoaQtd++;

                    verbosQtd++;
                }

            }

            Console.WriteLine($"Então temos {preposicaoQtd} preposições, {verbosQtd} verbos, sendo {verbosPrimeiraPessoaQtd} em primeira pessoa.");
            Console.ReadKey();
            //Primeira Questão: Preciso fazer a contagem de quantas palavras são preposições, ou seja, tem 3 letras, não terminam em D, F, L, S, W e K.
            //Segunda questão: Preciso fazer a contagem de quantas palavras são verbos, tendo 8 ou mais letras na palavra e terminam apenas em tipo Foo.
            //Terceira questão: Após pegar as palavras verbos da questão dois, é necessário que eu veja quantas delas não começam com tipo Foo

        }
        static void Questao3()
        {
        //    int preposicaoQtd = 0;
            //int verbosQtd = 0;
            //int verbosPrimeiraPessoaQtd = 0;

            string[] alfabetoKlingon = { "k", "b", "w", "r", "q", "d", "n", "f", "x", "j", "m", "l", "v", "h", "t", "c", "g", "z", "p", "s" };

            // ler arquivo.
            var texto = new StreamReader(@"App_Data/klingon-textoB.txt").ReadLine();

            foreach (var item in texto.ToString().Split(' '))
            {
                var teste = item.CompareTo(alfabetoKlingon);

            }

            //Console.WriteLine($"Então temos {preposicaoQtd} preposições, {verbosQtd} verbos, sendo {verbosPrimeiraPessoaQtd} em primeira pessoa.");
            Console.ReadKey();
            //Primeira Questão: Preciso fazer a contagem de quantas palavras são preposições, ou seja, tem 3 letras, não terminam em D, F, L, S, W e K.
            //Segunda questão: Preciso fazer a contagem de quantas palavras são verbos, tendo 8 ou mais letras na palavra e terminam apenas em tipo Foo.
            //Terceira questão: Após pegar as palavras verbos da questão dois, é necessário que eu veja quantas delas não começam com tipo Foo

        }
    }
}
