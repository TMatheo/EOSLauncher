using System;

namespace EOSLauncher.Module
{
    internal class DeepConsole
    {
        public static void Log(string Content)
        {
            DateTime now = DateTime.Now;
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(now.ToString("HH:mm"));
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("] ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($"{Content}\n");
            Console.ResetColor();
        }
        public static void PrintLogo()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(@"                     
               %@@@@@@@@@@@@@@@@@@@@@@@@                 
             %@@%%%%%%%%%%%@@@@@@@@@@@@@@%               
       %@@@@@@@%%%%%%%%%%%@@@@@@@@@@@@@@@@@@@@@@         
      @@@@@@@@%%%%%%%%%%@@@@@@@@@@@@@@@@@@@@@@@@@        
     @@@@@@@%%%%%%%%%%%@@@@@@@@@@@@@@@@@@@@@@@@@@@@      
    @@@@@@@%%%%%%%%%%%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@     
    @@@@@@%%%%%%%%%%%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@     
     @@@@%%%%%%%%%%%%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@      
      @@%%%%%%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@       
     @@%%%%%%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%      
    @@%%%%%%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@     
   %@%%%%%%%@@@@@@@==@@@@@%=%@@@@@==@@@@@@@@@@@@@@@@     
    @@%%%%%%%@@@@@@@@@@@*=====+@@@@@@@@@@@@@@@@@@@@@     
     @@%%%%%%%@@@@@@@@@=========@@@@@@@@@@@@@@@@@@@      
      @@%%%%%%%%%%%%%%===@@@@@===@@@@@@@@@@@@@@@@        
       @@%%%%%%%%%%%%=====%@%=====@@@@@@@@@@@@@@         
        %@%%%%%%%%%%%=============@@@@@@@@@@@@@          
         %@%%%%%%%%%%%===========@@@@@@@@@@@@@           
          %@@%%%%%%%%%%@=======@@@@@@@@@@@@@@            
           %@@%%%%%%%%%%@@@@@@@@@@@@@@@@@@@%             
            %@@%%%%%%%%%%%@@@@@@@@@@@@@@@@%              
             @@@%%%%%%%%%%%@@@@@@@@@@@@@@%               
               @@@@@@@@@@@@@@@@@@@@@@@@%                 
                                                         ");
            Console.ResetColor();
        }
        public static void SetupSize(int Width,int Height)
        {
            Console.WindowWidth = Width;
            Console.WindowHeight = Height;
        }
        public static void SetTittle(string Name)
        {
            Console.Title = Name;   
        }
    }
}
