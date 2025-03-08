using System;
using System.IO;

namespace EOSLauncher.Module
{
    internal class VRCUtils
    {
        public static void StartWithEAC()
        {
            if (!File.Exists(FilesUtils.VRChatInstallPath + "VRChat_Data\\Plugins\\x86_64\\EOSSDK-Win64-Shipping.dll"))
            {
                File.Delete(FilesUtils.VRChatInstallPath + "\\VRChat_Data\\Plugins\\x86_64\\EOSSDK-Win64-Shipping.dll");
                DeepConsole.Log("Deleted EOSSDK.");
                File.Copy(FilesUtils.FolderName+ "\\EOSSDK-Win64-Shipping.dll", FilesUtils.VRChatInstallPath + "\\VRChat_Data\\Plugins\\x86_64\\EOSSDK-Win64-Shipping.dll", true);
                DeepConsole.Log("Copied original EOSSDK.");
                ModLoaderUtils.StartWithEAC();
                ProcessUtils.HandleVRCLaunchEAC();
            }
        }
        public static void StartWithoutEAC()
        {
            if (!File.Exists(FilesUtils.VRChatInstallPath + "VRChat_Data\\Plugins\\x86_64\\EOSSDK-Win64-Shipping.dll"))
            {
                File.Delete(FilesUtils.VRChatInstallPath + "\\VRChat_Data\\Plugins\\x86_64\\EOSSDK-Win64-Shipping.dll");
                DeepConsole.Log("Deleted EOSSDK.");
                File.Copy(FilesUtils.FolderName + "\\CustomEOS\\EOSSDK-Win64-Shipping.dll", FilesUtils.VRChatInstallPath + "\\VRChat_Data\\Plugins\\x86_64\\EOSSDK-Win64-Shipping.dll", true);
                DeepConsole.Log("Copied custom EOSSDK.");
                ModLoaderUtils.StartWithoutEAC();
                ProcessUtils.HandleVRCLaunch();
            }
        }
    }
}
