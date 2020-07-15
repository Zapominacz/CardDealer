using Microsoft.AspNetCore.Server.IIS.Core;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace CardDealer
{
    public static class ImageToStringConverter
    {
        public static String GetPNGString(Image image)
        {
            return GetImageString(image, "data:image/png;base64,{0}");
        }

        public static String GetImageString(Image image, String format)
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
