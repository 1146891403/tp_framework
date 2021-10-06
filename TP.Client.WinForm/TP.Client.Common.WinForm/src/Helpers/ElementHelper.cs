using DevExpress.Utils;
using DevExpress.Utils.Design;
using System;
using System.Drawing;

namespace TP.Client.WinForm.Common.Helpers
{
    public class ElementHelper
    {
        public static Image GetImage(Type typeName, string imageName, ImageSize size)
        {
            if (typeName == null || string.IsNullOrWhiteSpace(imageName)) return null;
            
            return ResourceImageHelper.CreateImageFromResources($"{typeName.Namespace.Replace("Controls", "")}Resources.{imageName}_{GetImageSizeString(size)}.png", typeName.Assembly);
        }
        
        static string GetImageSizeString(ImageSize size)
        {
            if (size == ImageSize.Size16x16) return "16x16";
            return "32x32";
        }
    }
}
