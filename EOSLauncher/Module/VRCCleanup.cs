using System;
using System.IO;
using Microsoft.Win32;

namespace EOSLauncher.Module
{
    internal class VRCCleanup
    {
        public static void Start()
        {
            DeepConsole.Log("This is irreversible and will delete all VRChat Cache / Temp data & Registry things\nPress any key to continue");
            Console.ReadKey();
            DeepConsole.Log("Deleting Easy Anti Cheat Folder");
            DeleteFolder(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\EasyAntiCheat");
            DeepConsole.Log("Unity");
            DeleteFolder(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Unity");
            DeepConsole.Log("Deleting VRChat Local Folder");
            DeleteFolder(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\VRChat");
            DeepConsole.Log("Done\nDeleting VRChat Local Temp Folder");
            DeleteFolder(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Temp\\VRChat");
            DeepConsole.Log("Done\nDeleting VRChat Local Low Folder");
            DeleteFolder(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "Low\\VRChat");
            DeepConsole.Log("Done\nDeleting VRChat Roaming Folder");
            DeleteFolder(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\VRChat");
            DeepConsole.Log("Done\nDeleting VRChat Unity Folder");
            DeleteFolder(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Temp\\DefaultCompany");
            DeepConsole.Log("Done\nDeleting VRChat Unity Folder 2");
            DeleteFolder(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "Low\\DefaultCompany");
            DeepConsole.Log("Done\nDeleting Registry Values");
            DeleteRegistry();
            DeepConsole.Log("Done, Make sure to use your fav HWID spoofer and you should be fairly safe.");
            Console.ReadKey();
        }
        static private void DeleteFolder(string folder)
        {
            try
            {
                DeepConsole.Log(folder);
                Directory.Delete(folder, true);
            }
            catch {}
        }
        static private void DeleteRegistry()
        {
            string keyName = @"Software\VRChat";
            Registry.CurrentUser.DeleteSubKey(keyName, false);
            keyName = @"Software\Unity Technologies";
            Registry.CurrentUser.DeleteSubKey(keyName, false);
        }
    }
}