using System;
using EOSLauncher.Module;

namespace EOSLauncher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DeepConsole.SetTittle("EOSLauncher - v1.0");
            FilesUtils.CheckFiles();
            DeepConsole.SetupSize(55,33);
            ShowMenu();
        }
        static void ShowMenu()
        {
            while (true)
            {
                DeepConsole.PrintLogo();
                DeepConsole.Log("===============================");
                DeepConsole.Log("-        EOS Launcher         -");
                DeepConsole.Log("===============================");
                DeepConsole.Log("1. Launch Game with Anti-Cheat");
                DeepConsole.Log("2. Launch Game without Anti-Cheat");
                DeepConsole.Log("3. Exit");
                DeepConsole.Log("Select an option: ");

                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        VRCUtils.StartWithEAC();
                        break;
                    case "2":
                        VRCUtils.StartWithoutEAC();
                        break;
                    case "3":
                        DeepConsole.Log("Exiting...");
                        return;
                    default:
                        DeepConsole.Log("Invalid option. Press any key to try again...");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
