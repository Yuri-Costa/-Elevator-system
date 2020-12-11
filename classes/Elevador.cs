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
            Console.ForegroundColor=ConsoleColor.Red;
            int andar2 = int.Parse(Console.ReadLine());
           switch (andar2)
           {
               case 0:
               Console.WriteLine("opa! voce ja esta no terreo");
                   break;
                case 1:
               Console.WriteLine("opa! voce ja esta no primeiro andar");
                   break;
                 case 2:
               Console.WriteLine("opa! voce ja esta no segundo andar");
                   break;
                case 3:
               Console.WriteLine("opa! voce ja esta no terceiro andar");
                   break;
                case 4:
               Console.WriteLine("opa! voce ja esta no quarto andar");
                   break;
                case 5:
               Console.WriteLine("opa! voce ja esta no quinto andar");
                   break;
                   
               default:  Console.ForegroundColor=ConsoleColor.Cyan;
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
                 Console.ForegroundColor=ConsoleColor.Cyan;
                default: Console.WriteLine("Este predio só tem 5 andares :) ");
                         Console.WriteLine("Escolha outro andar");

                    break;
               
            
            
        }
        } while (true);
        }//fim

       



    }
    }