using System.IO;

namespace EOSLauncher.Module
{
    internal class ModLoaderUtils
    {
        public static void StartWithEAC()
        {
            if (File.Exists(FilesUtils.VRChatInstallPath+ "\\winhttp.dll"))
            {
                DeepConsole.Log("Found ModLoader !");
                File.Move(FilesUtils.VRChatInstallPath+ "\\winhttp.dll", FilesUtils.VRChatInstallPath + "\\winhttp_backup.dll");
                DeepConsole.Log("Disabled ModLoader.");
            }
        }
        public static void StartWithoutEAC()
        {
            if (File.Exists(FilesUtils.VRChatInstallPath + "\\winhttp_backup.dll"))
            {
                DeepConsole.Log("Found ModLoader !");
                File.Move(FilesUtils.VRChatInstallPath + "\\winhttp_backup.dll", FilesUtils.VRChatInstallPath + "\\winhttp.dll");
                DeepConsole.Log("Enabled ModLoader.");
            }
        }
    }
}
