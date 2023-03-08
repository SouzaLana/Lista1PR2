using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1PR2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ativ. 1

            //int num, cm, mlm;

            //Console.WriteLine("Digite um valor em metro: ");
            //num = int.Parse(Console.ReadLine());

            //cm = num * 100;
            //mlm = num * 1000;

            //Console.WriteLine(num + " metros é igual a " + cm + " centímetro e " + mlm + " milímetros.");
            //Console.ReadKey();


            //Ativ. 2
            //a

            //float f, c;

            //Console.WriteLine("digite o valor em graus fahrenheit: ");
            //f = int.Parse(Console.ReadLine());

            //c = (f - 32.0f) * (5.0f / 9.0f);

            //Console.WriteLine("o valor em graus celsius é " + c);
            //Console.ReadKey();


            //b

            //int f, C;

            //Console.WriteLine("Digite um valor em graus Fahrenheit: ");
            //f = int.Parse(Console.ReadLine());

            //C = (f - 32) * (5 / 9);

            //Console.WriteLine("O valor em graus Celsius é " + C);
            //Console.ReadKey();

            //O resultado é zero porque na hora de fazer a multiplicação, ele não usa os números depois da vírgula, somente os que vem antes que, nesse caso, é zero. Ele só uma os números que vem antes da vírgula porque int só trabalho números inteiros e não usa números quebrados.


            //Ativ. 3

            //float peso, alt, IMC;

            //Console.WriteLine("Digite o peso: ");
            //peso = float.Parse(Console.ReadLine());
            //Console.WriteLine("Digite a altura: ");
            //alt = float.Parse(Console.ReadLine());

            //IMC = peso / (alt * alt);

            //Console.WriteLine("O IMC é " + IMC);
            //Console.ReadKey();


            //Ativ. 4

            //float n1, n2, n3, p1, p2, p3, mp;

            //Console.WriteLine("Digite o primeiro número: ");
            //n1 = float.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o segundo número: ");
            //n2 = float.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o terceiro número: ");
            //n3 = float.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o valor do primeiro peso: ");
            //p1 = float.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o valor do segundo peso: ");
            //p2 = float.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o valor do terceiro peso: ");
            //p3 = float.Parse(Console.ReadLine());

            //mp = ((n1 * p1) + (n2 * p2) + (n3 * p3)) / (p1 + p2 + p3);

            //Console.WriteLine("O resultado da média pondera é " + mp);
            //Console.ReadKey();


            //Ativ. 5

            //float m, g = 10.0f, p;

            //Console.WriteLine("Digite o valor da massa: ");
            //m = float.Parse(Console.ReadLine());

            //p = m * g;

            //Console.WriteLine("O valor do peso é " + p);
            //Console.ReadKey();


            //Ativ. 6

            //float sal, aum, nsal;

            //Console.WriteLine("Digite o valor do salário: ");
            //sal = float.Parse(Console.ReadLine());

            //aum = sal * 0.25f;
            //nsal = sal + aum;

            //Console.WriteLine("O novo salário é de " + nsal);
            //Console.ReadKey();


            //Ativ. 7

            //float real, dol, cot;

            //Console.WriteLine("Digite o valor do dinheiro em real: ");
            //real = float.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o valor da cotação do dolar: ");
            //cot = float.Parse(Console.ReadLine());

            //dol = real / cot;

            //Console.WriteLine("O valor em dolar é de US$ " + dol);
            //Console.ReadKey();



            //Ativ. 8

            //int num, suc, ant, soma;

            //Console.WriteLine("Digite um número inteiro: ");
            //num = int.Parse(Console.ReadLine());

            //suc = num + 1;
            //ant = num - 1;
            //soma = suc + ant;

            //Console.WriteLine("A soma do sucessor com o antecessor do número " + num + " é " + soma);
            //Console.ReadKey();


            //Ativ. 9

            //int num, pri, seg, ter, quar;
            //Console.WriteLine("Digite um número de 4 dígitos: ");
            //num = int.Parse(Console.ReadLine());

            //pri = num / 1000;
            //seg = num / 100 - pri * 10;
            //ter = num / 10 - pri * 100 - seg * 10;
            //quar = num - pri * 1000 - seg * 100 - ter * 10;

            //Console.WriteLine(pri);
            //Console.WriteLine(seg);
            //Console.WriteLine(ter);
            //Console.WriteLine(quar);
            //Console.ReadKey();


            //Ativ. 10

            //float sub1 = 2.8f / 100, sub2 = 14 / 100, cai1 = 3.4f / 100, cai2 = 8.5f / 100, val;

            //val = 1000.00f - cai1 + sub1 + sub2 - cai2;

            //Console.WriteLine("O valor atual dos investimentos de Marquesito é " + val);
            //Console.ReadLine();


            //Ativ. 11

            //int num, qua, cubo;

            //Console.WriteLine("Digite um número: ");
            //num = int.Parse(Console.ReadLine());

            //qua = num * num;
            //cubo = num * num * num;

            //Console.WriteLine("O quadrado do número " + num + " é " + qua + " e o cubo é " + cubo);
            //Console.ReadKey();


            //Ativ. 12

            //string pss;
            //float peso, alt;

            //Console.WriteLine("Digite se é homem ou se é mulher: ");
            //pss = (Console.ReadLine());
            //Console.WriteLine("Digite a altura: ");
            //alt = float.Parse(Console.ReadLine());

            //if (pss == "homem")
            //{
            //    peso = (72.7f * alt) - 58;
            //    Console.WriteLine("O peso ideal é " + peso);
            //}
            //else
            //{
            //    peso = (62.1f * alt) - 44.7f;
            //    Console.WriteLine("O peso ideal é " + peso);
            //}
            //Console.ReadKey();


            //Ativ. 13

            //O GIT é um sistema de controle de versão que serve para controlar o histórico de alterações de arquivos e, principalmente, de projetos de desenvolvimento de software.
            //O GITHUB é uma plataforma de hospedagem de código-fonte e arquivos com controle de versão usando o GIT.

            //Comandos do GIT:

            //git clone - serve para copiar o código fonte de um projeto que está em um repositório e o salva (uma cópia) em seu computador;
            //git status - dá informações sobre a branch e os arquivos;
            //git pull - para obter atualizações de um repositório remoto e aplicar as alterações mais recentes em seu espaço de trabalho local;
            //git branch - para criar, listar e excluir as branches;
            //git push - faz o uplad das alterações, que já estão em um commit, no repositório remoto;
            //git add - para incluir as alterações de arquivos em nosso próximo commit;
            //git commit - salva as alterações no espaço de trabalho local;
            //git reverse - para desfazer nosso commits;
            //git merge - integra sua branch na branch de desenvolvimento ou na branch principal;
            //git checkout - para trocar de uma branch para outra e para fazer o checkout de arquivos e commits.   

        }
    }
}
