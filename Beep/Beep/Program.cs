using System;

namespace Beep
{ //C:\Users\Desen10\source\repos
    public class MainClass
    {
        //definição de frequencia  que será escolhida pelo user;
        public static int EscolhaFrequencia()
        {
            int frequencia;
            Console.WriteLine("Escolha a frequnência do Beep (hertz): ");
            string frequenciaS = Console.ReadLine();

            //TryParse converte string em numero inteiro de 32 bits
            if (!Int32.TryParse(frequenciaS, out frequencia))
            {
                return 800;
            }
            else
            {
                return frequencia;
            }
        }

        //definicao da duracao do beep
        public static int EscolhaDuracao()
        {
            //declara a variável que irá guardar o valor
            int Duracao;
            Console.WriteLine("Escolha a duração do Beep: ");
            string DuracaoS = Console.ReadLine(); // o uso do Console.ReadLine, é para que o programa execute até está faixa

            //validação dos argumenos recebidos, e definição da condição;
            if (!Int32.TryParse(DuracaoS, out Duracao))
            {
                return 200;
            }
            else
            {
                return Duracao;
            }
        }
        
        //define uma constante Void que permite
        public static void Constate(int frequencia, int duracao)
        {
            Console.WriteLine("Pressione CTRL + C para Sair... ");

            while (true)
            {
                Console.Beep(frequencia, duracao);
            }
        }

        public static void Teclar(int frequencia, int duracao)
        {
            Console.WriteLine("Oressuibe X ou CTRL + C para sair... ");

            //tefcla que será digitada pelo usuario
            ConsoleKeyInfo keyInfo;

            do
            {   //guarda na variavel e le a tecla digitada
                keyInfo = Console.ReadKey();
                Console.Beep(frequencia, duracao);
            }
            // define uma conição se a chave for diferente da deinida "X" ( vai ler primeiro, e depois verifica se a tecla está correta)
            while (keyInfo.Key != ConsoleKey.X);
        }


        //Tudo acima foi feito em escopo Global; Agora vai entrar no Programa; 
        //tudo deve estar dentro da classe MainClass
        public static void Main(string[] args)
        {
            //definição das variváveis que serão usadas no programa
            string versao = "1.0";
            string escolha;
            int frequencia, duracao;

            //texto que irá aprecer na tela do usuário;
            Console.WriteLine("================================================================");
            Console.WriteLine("Beep. Programa que Bipa! Exercicio em C# -> Versão: " + versao);
            Console.WriteLine("================================================================");

            Console.WriteLine("Escolha o modo do programa: ");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("(1) Modo toque - Bipa quando tecla for pressionada.");
            Console.WriteLine("(2) Modo toque - Bipa constantemente até que feche o programa\n");

            Console.WriteLine("Escolha o modo (Qualquer opção para sair): ");
            escolha = Console.ReadLine();

            if (escolha == "1")
            {
                frequencia = EscolhaFrequencia();
                duracao = EscolhaDuracao();
                Teclar(frequencia, duracao);
            }
            else if (escolha == "2")
            {
                frequencia = EscolhaFrequencia();
                duracao = EscolhaDuracao();
                Constate(frequencia, duracao);
            }
            else
            {
                Console.WriteLine("Saindo...");
            }
        }
    }
}