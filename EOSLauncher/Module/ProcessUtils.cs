using System;
using System.Diagnostics;
using System.IO;

namespace EOSLauncher.Module
{
    internal class ProcessUtils
    {
        public static void HandleVRCLaunch()
        {
            DeepConsole.Log("Starting VRChat...");
            DeepConsole.Log2("Do you want to start in VR mode? (y/n): ");
            string userInput = Console.ReadLine()?.Trim().ToLower();
            string arguments = userInput == "y" ? "" : "--no-vr";
            StartPro(FilesUtils.VRChatInstallPath, "VRChat.exe", arguments);
            Process.GetCurrentProcess().Kill();
        }
        public static void HandleVRCLaunchEAC()
        {
            DeepConsole.Log("Starting VRChat...");
            DeepConsole.Log2("Do you want to start in VR mode? (y/n): ");
            string userInput = Console.ReadLine()?.Trim().ToLower();
            string arguments = userInput == "y" ? "" : "--no-vr";
            StartPro(FilesUtils.VRChatInstallPath, "start_protected_game.exe", arguments);
            Process.GetCurrentProcess().Kill();
        }
        public static void StartPro(string path, string exename, string arguments)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = Path.Combine(path, exename),
                Arguments = arguments,
                UseShellExecute = true
            });
        }
    }
}
