using System;
namespace challenge_1
{
    public class Elevador
    {
        private int andarAtual;
        public int AndarAtual{set; get;}
        //-----------------------------------
        private int andares = 5;
        public int Andares{set; get;}
        //-------------------------------------

        private int capacidaElevador = 8;
        public int CapacidaElevador{set; get;}
        //--------------------------------------

        private int pessoasPresente = 6;
        public int PessoasPresente{set; get;}
        //---------------------------------------


        public void Inializar( ){}

        public void Entrar(){}

        public void Sair(){}

        public void VerificarAndar(){
            Console.ForegroundColor=ConsoleColor.Magenta;
            Console.WriteLine("Qual andar?");
            Console.ForegroundColor=ConsoleColor.Yellow;
            Console.WriteLine("[5]");
            Console.WriteLine("[4]");
            Console.WriteLine("[3]");
            Console.WriteLine("[2]");
            Console.WriteLine("[1]");
            Console.WriteLine("[0]");
            Console.ForegroundColor=ConsoleColor.Green;
            int andar2 = int.Parse(Console.ReadLine());
           switch (andar2)
           {
               case 0:
               Console.WriteLine("Você está no " + andar2);
                   break;
                case 1:
               Console.WriteLine("Você está no " + andar2);
                   break;
                 case 2:
               Console.WriteLine("Você está no " + andar2);
                   break;
                case 3:
               Console.WriteLine("Você está no " + andar2);
                   break;
                case 4:
               Console.WriteLine("Você está no " + andar2);
                   break;
                case 5:
               Console.WriteLine(" voce está no 3" + andar2);
                   break;
                   
               default:  Console.ForegroundColor=ConsoleColor.Red;
                         Console.WriteLine("Este predio só tem 5 andares :) ");
                         Console.WriteLine("Escolha outro andar");
                   break;
           }
           
       }

        public void andar(){
                do
                {
            Console.ForegroundColor=ConsoleColor.Magenta;
            Console.WriteLine("Qual andar?");
            Console.ForegroundColor=ConsoleColor.Yellow;
            Console.WriteLine("[5]");
            Console.WriteLine("[4]");
            Console.WriteLine("[3]");
            Console.WriteLine("[2]");
            Console.WriteLine("[1]");
            Console.WriteLine("[0]");
            int andar = int.Parse(Console.ReadLine());
            Console.ForegroundColor=ConsoleColor.Green;
            switch (andar)
            {
                
                case 0:
                Console.WriteLine("Terreo");
                  VerificarAndar();
                    break;

                     case 1:
                Console.WriteLine("Primeiro Andar");
                VerificarAndar();
                    break;

                     case 2:
                Console.WriteLine("Segundo Andar");
                  VerificarAndar();
                 
                    break;

                     case 3:
                Console.WriteLine("Terceiro Andar");
                  VerificarAndar();
                 
                    break;

                     case 4:
                Console.WriteLine("Quarto Andar");
                  VerificarAndar();
                 
                    break;

                     case 5:
                Console.WriteLine("Quinto Andar");
                  VerificarAndar();
                 
                    break;
                 Console.ForegroundColor=ConsoleColor.Red;
                default: Console.WriteLine("Este predio só tem 5 andares :) ");
                         Console.WriteLine("Escolha outro andar");

                    break;
               
            
            
        }
        } while (true);
        }//fim

       



    }
    }