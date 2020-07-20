using Microsoft.AspNetCore.Server.IIS.Core;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class ExtensionMethods
    {
        public static String GetPNGString(this Image image)
        {
            return image.GetImageString("data:image/png;base64,{0}");
        }

        public static String GetImageString(this Image image, String format)
        {
            if (image is null)
                return null;

            if (format is null)
                throw new ArgumentNullException("Format string can't be null");

            ImageConverter ic = new ImageConverter();
            byte[] byteArray = (byte[])ic.ConvertTo(image, typeof(byte[]));
            String result = String.Format(format, Convert.ToBase64String(byteArray));
            return result;
        }
    }
}
