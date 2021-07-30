using System;

namespace função_while
{
    class Program
    {
        static void Main(string[] args)
        {
                                //Console.WriteLine("Aprendendo WHILE");
            
            //Console.WriteLine("Digite um número:");
            //int numero = int.Parse(Console.ReadLine());//Aqui define o valor da variavel numero

            //int contador = 0;//Aqui define o valor incial da variavel contador

            //Console.WriteLine("----------------------------------------------------------------");

            //WHILE repete enquanto a condição for verdadeira
            //while (contador <= numero)    //contador é menor ou igual a numero (que é definido pelo usuario, por ex: 10, então como é verdadeiro ira repetir)
            //{
                //Console.WriteLine(contador);
                //contador = contador +1;           //incremento (aqui ele pega o valor dele e soma mais um toda vez que for repetido, ou seja, enquanto a condição for verdadeira)


            //};//fim do while
            
                                //EXEMPLO "DO WHILE"
             //   string resposta = "";
            //  do{
            //     Console.WriteLine("Digite seu email");
            //     resposta = Console.ReadLine();

            // }while(resposta != "eu@gmail.com"); //se o email for diferente ele vai continuar pedindo e-mail

            //     Console.WriteLine("E-mail confirmado");


            Console.WriteLine("Digite a idade do apresentador Faustão");

            int idade = int.Parse(Console.ReadLine());
            while(idade != 71)
            {
                Console.WriteLine("Errouu!");
                Console.WriteLine("Tente de novo, não desista!");
                idade = int.Parse(Console.ReadLine());
                
            }
                Console.WriteLine("Acertou! Parabéns!!!"); //a mensagem só aparece caso ele complete e saia da repetição, enquanto for falso ele vai ficar em looping até acertar, e só após isso ele verá esse codigo


        }
    }
}
