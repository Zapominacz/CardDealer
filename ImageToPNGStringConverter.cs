using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace CardDealer
{
    public static class ImageToPNGStringConverter
    {
        public static String GetPNGString(Image image)
        {
            if (image is null)
                return null;

            ImageConverter ic = new ImageConverter();
            byte[] byteArray = (byte[])ic.ConvertTo(image, typeof(byte[]));
            String result = String.Format("data:image/png;base64,{0}", Convert.ToBase64String(byteArray));
            return result;
        }
    }
}
