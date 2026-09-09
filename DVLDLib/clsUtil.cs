using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDLib
{
    public static class clsUtil
    {
        private static void _DeleteOldImage(string oldImage)
        {
            if (!string.IsNullOrEmpty(oldImage) && File.Exists(oldImage) && Path.GetDirectoryName(oldImage) == "M:\\Dvld images\\DestenationImges")
            {
                try
                {
                    File.Delete(oldImage);
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.Message);
                }
            }
        }
        public static string GenerateUniqueFileName(string oldFileName, string destinationDirectory)
        {
            string extension = Path.GetExtension(oldFileName);
            string uniqueFileName = destinationDirectory + Guid.NewGuid().ToString() + extension;
            return uniqueFileName;
        }
        public static string CopyImageIntoDestinationFile(string sourceImage, string destinationDirectory)
        {
            string SourcePath = destinationDirectory;
            string DestinationPath = "";

            if (!string.IsNullOrEmpty(SourcePath) && File.Exists(SourcePath))
            {
                if (sourceImage == SourcePath)
                    return destinationDirectory;

                DestinationPath = GenerateUniqueFileName(SourcePath, @"M:\Dvld images\DestenationImges\");

                File.Copy(SourcePath, DestinationPath);
                destinationDirectory = DestinationPath;
                _DeleteOldImage(sourceImage);
            }
            else
                _DeleteOldImage(sourceImage);


            return DestinationPath;
        }
    }
}
