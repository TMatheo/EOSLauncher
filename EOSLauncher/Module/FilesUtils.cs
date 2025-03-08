using System.IO;
using System;
using System.Net;

namespace EOSLauncher.Module
{
    internal class FilesUtils
    {
        public static string FolderName = "Resources";
        public static string CustomEOSPath = "Resources/CustomEOS";
        public static string VRChatPath = "Resources/VRChatPath.txt";
        public static string VRChatInstallPath = "";
        public static string OriginalEOSSDK = "Resources/EOSSDK-Win64-Shipping.dll";
        public static string OriginalEOSSDKURL = "https://github.com/TMatheo/FileHost/raw/refs/heads/main/EOSLauncher/EOSSDK-Win64-Shipping.dll";
        public static void CheckFiles()
        {
            DeepConsole.Log("Checking folder & files...");
            if (!Directory.Exists(FolderName))
            {
                Directory.CreateDirectory(FolderName);
                DeepConsole.Log("Folder created:"+FolderName);
            }
            if (!Directory.Exists(CustomEOSPath))
            {
                Directory.CreateDirectory(CustomEOSPath);
                DeepConsole.Log("Folder created:" + CustomEOSPath);
            }
            if (!File.Exists(OriginalEOSSDK))
            {
                DeepConsole.Log("Downloading original EOSSDK-Win64-Shipping.dll...");
                DownloadFile(OriginalEOSSDKURL, OriginalEOSSDK);
            }
            if (!File.Exists(VRChatPath))
            {
                DeepConsole.Log("Please put your VRChat installation path below.");
                string userInput = Console.ReadLine();
                File.WriteAllText(VRChatPath,userInput);
                DeepConsole.Log("Path saved and loaded.");
                VRChatInstallPath = File.ReadAllText(VRChatPath);
            }
            else
            {
                VRChatInstallPath = File.ReadAllText(VRChatPath);
                DeepConsole.Log("Loaded VRChat installation path.");
            }
            if (!File.Exists(CustomEOSPath+ "/EOSSDK-Win64-Shipping.dll"))
            {
                DeepConsole.Log($"Please put your EOSSDK-Win64-Shipping.dll in '{CustomEOSPath}' and press enter");
                Console.ReadKey();
            }
            DeepConsole.Log("Done checking and loading files.");
            Console.Clear();
        }
        public static void DownloadFile(string fileUrl,string filePath)
        {
            using (WebClient webClient = new WebClient())
            {
                webClient.DownloadFile(fileUrl, filePath);
            }
            DeepConsole.Log("downloaded: " + filePath);
        }
    }
}
