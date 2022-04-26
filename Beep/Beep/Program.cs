//using System;

//namespace Beep
//{ //C:\Users\Desen10\source\repos
//    public class MainClass
//    {
//        //definição de frequencia  que será escolhida pelo user;
//        public static int EscolhaFrequencia()
//        {
//            int frequencia;
//            Console.WriteLine("Escolha a frequnência do Beep (hertz): ");
//            string frequenciaS = Console.ReadLine();

//            //TryParse converte string em numero inteiro de 32 bits
//            if (!Int32.TryParse(frequenciaS, out frequencia))
//            {
//                return 800;
//            }
//            else
//            {
//                return frequencia;
//            }
//        }

//        //definicao da duracao do beep
//        public static int EscolhaDuracao()
//        {
//            //declara a variável que irá guardar o valor
//            int Duracao;
//            Console.WriteLine("Escolha a duração do Beep: ");
//            string DuracaoS = Console.ReadLine(); // o uso do Console.ReadLine, é para que o programa execute até está faixa

//            //validação dos argumenos recebidos, e definição da condição;
//            if (!Int32.TryParse(DuracaoS, out Duracao))
//            {
//                return 200;
//            }
//            else
//            {
//                return Duracao;
//            }
//        }

//        //define uma constante Void que permite
//        public static void Constate(int frequencia, int duracao)
//        {
//            Console.WriteLine("Pressione CTRL + C para Sair... ");

//            while (true)
//            {
//                Console.Beep(frequencia, duracao);
//            }
//        }

//        public static void Teclar(int frequencia, int duracao)
//        {
//            Console.WriteLine("Oressuibe X ou CTRL + C para sair... ");

//            //tefcla que será digitada pelo usuario
//            ConsoleKeyInfo keyInfo;

//            do
//            {   //guarda na variavel e le a tecla digitada
//                keyInfo = Console.ReadKey();
//                Console.Beep(frequencia, duracao);
//            }
//            // define uma conição se a chave for diferente da deinida "X" ( vai ler primeiro, e depois verifica se a tecla está correta)
//            while (keyInfo.Key != ConsoleKey.X);
//        }
    

//    //Tudo acima foi feito em escopo Global; Agora vai entrar no Programa; 
//    //tudo deve estar dentro da classe MainClass
//        public static void Main(string[]args)
//        {
//            //definição das variváveis que serão usadas no programa
//            string versao = "1.0";
//            string escolha;
//            int frequencia, duracao;

//            //texto que irá aprecer na tela do usuário;
//            Console.WriteLine("================================================================");
//            Console.WriteLine("Beep. Programa que Bipa! Exercicio em C# -> Versão: " + versao);
//            Console.WriteLine("================================================================");

//            Console.WriteLine("Escolha o modo do programa: ");
//            Console.WriteLine("----------------------------------------------------------------");
//            Console.WriteLine("(1) Modo toque - Bipa quando tecla for pressionada.");
//            Console.WriteLine("(2) Modo toque - Bipa constantemente até que feche o programa\n");

//            Console.WriteLine("Escolha o modo (Qualquer opção para sair): ");
//            escolha = Console.ReadLine();

//            if (escolha == "1")
//            {
//                frequencia = EscolhaFrequencia();
//                duracao = EscolhaDuracao();
//                Teclar(frequencia, duracao);
//            }
//            else if (escolha == "2")
//            {
//                frequencia = EscolhaFrequencia();
//                duracao = EscolhaDuracao();
//                Constate(frequencia, duracao);
//            }
//            else
//            {
//                Console.WriteLine("Saindo...");
//            }
//        }
//    }
//}

using System;

namespace BeepBeep
{
	public class MainClass
	{
		public static int ChooseFreq()
		{
			int freq;
			Console.Write("Escolha a frequência do beep (hertz): ");
			string freqS = Console.ReadLine();

			if (!Int32.TryParse(freqS, out freq))
			{
				return 800;
			}
			else
			{
				return freq;
			}
		}

		public static int ChooseDur()
		{
			int dur;
			Console.Write("Escolha a duração do beep (milissegundos): ");
			string durS = Console.ReadLine();

			if (!Int32.TryParse(durS, out dur))
			{
				return 200;
			}
			else
			{
				return dur;
			}
		}

		public static void KeyboardMode()
		{
			Console.WriteLine("\nTeclas QWERTYUIOP possuem variação de 500 hertz!");
			Console.WriteLine("As demais teclas de caracteres possuem variações de 200 hertz!");
			Console.WriteLine("Pressione ESC ou CTRL + C para sair...\n");

			ConsoleKeyInfo keyinfo;
			string keyInput;

			do
			{
				keyinfo = Console.ReadKey();
				keyInput = keyinfo.KeyChar.ToString();
				switch (keyInput)
				{
					// Variações de 500 hertz
					// ===================
					case "q":
						Console.Beep(500, 100);
						break;
					case "w":
						Console.Beep(1000, 100);
						break;
					case "e":
						Console.Beep(1500, 100);
						break;
					case "r":
						Console.Beep(2000, 100);
						break;
					case "t":
						Console.Beep(2500, 100);
						break;
					case "y":
						Console.Beep(3000, 100);
						break;
					case "u":
						Console.Beep(3500, 100);
						break;
					case "i":
						Console.Beep(4000, 100);
						break;
					case "o":
						Console.Beep(4500, 100);
						break;
					case "p":
						Console.Beep(5000, 100);
						break;
					// Variações de 200 hertz (pulando as variações de 500)
					// ============================================
					case "a":
						Console.Beep(200, 100);
						break;
					case "s":
						Console.Beep(400, 100);
						break;
					case "d":
						Console.Beep(600, 100);
						break;
					case "f":
						Console.Beep(800, 100);
						break;
					case "g":
						Console.Beep(1200, 100);
						break;
					case "h":
						Console.Beep(1400, 100);
						break;
					case "j":
						Console.Beep(1600, 100);
						break;
					case "k":
						Console.Beep(1800, 100);
						break;
					case "l":
						Console.Beep(2200, 100);
						break;
					case "ç":
						Console.Beep(2400, 100);
						break;
					case "z":
						Console.Beep(2600, 100);
						break;
					case "x":
						Console.Beep(2800, 100);
						break;
					case "c":
						Console.Beep(3200, 100);
						break;
					case "v":
						Console.Beep(3400, 100);
						break;
					case "b":
						Console.Beep(3600, 100);
						break;
					case "n":
						Console.Beep(3800, 100);
						break;
					case "m":
						Console.Beep(4200, 100);
						break;
					// Qualquer outra tecla usa a frequência padrão
					// =====================================
					default:
						Console.Beep(800, 100);
						break;
				}
				Console.Write("\r");
			}
			while (keyinfo.Key != ConsoleKey.Escape);
		}

		public static void ConstantMode(int freq, int dur)
		{
			Console.WriteLine("Pressione CTRL + C para sair...");

			while (true)
			{
				Console.Beep(freq, dur);
			}
		}

		public static void TouchMode(int freq, int dur)
		{
			Console.WriteLine("Pressione X ou CTRL + C para sair...\n");

			ConsoleKeyInfo keyinfo;
			do
			{
				keyinfo = Console.ReadKey();
				Console.Beep(freq, dur);
				Console.Write("\r");
			}
			while (keyinfo.Key != ConsoleKey.X);
		}

		public static void Main()
		{
			string version = "1.2";
			string choose;
			int freq, dur;

			Console.WriteLine("=======================================");
			Console.WriteLine("Beep: O programa que bipa! - Versão " + version);
			Console.WriteLine("=======================================\n");

			Console.WriteLine("Escolha o modo do programa:");
			Console.WriteLine("---------------------------");
			Console.WriteLine("(1) Modo Toque - Bipa quando tecla for pressionada");
			Console.WriteLine("(2) Modo Constante - Bipa constantemente até o programa ser fechado");
			Console.WriteLine("(3) Modo Teclado - Cada tecla bipa com diferentes frequências\n");

			Console.Write("Escolha o modo (qualquer outra opção para sair): ");
			choose = Console.ReadLine();

			if (choose == "1")
			{
				freq = ChooseFreq();
				dur = ChooseDur();
				TouchMode(freq, dur);
			}
			else if (choose == "2")
			{
				freq = ChooseFreq();
				dur = ChooseDur();
				ConstantMode(freq, dur);
			}
			else if (choose == "3")
			{
				KeyboardMode();
			}
			else
			{
				Console.WriteLine("Saindo...");
			}
		}
	}
}