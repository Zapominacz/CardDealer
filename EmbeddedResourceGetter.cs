using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace CardDealer
{
    static public class EmbeddedResourceGetter
    {
        public static Image GetImage(string resourceName)
        {
            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Image image;
            using (Stream myStream = myAssembly.GetManifestResourceStream(resourceName))
            {
                if (myStream == null)
                    image = null;
                else
                    image = Image.FromStream(myStream);
            }
            return image;
        }
    }
}
