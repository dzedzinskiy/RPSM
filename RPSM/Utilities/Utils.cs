using System;
using System.Drawing;
using System.IO;
using System.Windows.Media.Imaging;

namespace RPSM.Utilities
{
    internal class Utils
    {
        internal const string Alphabeth = "ABCDEFGHIJKLMNOPQRSTJVWXYZ";
        internal WebFormsHelpers WebFormsHelpers { get; set; }
        internal GraphGenerator GraphGenerator { get; set; }
        public decimal ConvertToDecimal(object value)
        {
            if (value == null) return 0;

            return Convert.ToDecimal(value);
        }

        public Bitmap ByteArrayToBitmap(byte[] array)
        {
            return BitmapImage2Bitmap(ImageFromBuffer(array));
        }

        public Bitmap BitmapImage2Bitmap(BitmapImage bitmapImage)
        {
            // BitmapImage bitmapImage = new BitmapImage(new Uri("../Images/test.png", UriKind.Relative));

            using (MemoryStream outStream = new MemoryStream())
            {
                BitmapEncoder enc = new BmpBitmapEncoder();
                enc.Frames.Add(BitmapFrame.Create(bitmapImage));
                enc.Save(outStream);
                System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(outStream);

                return new Bitmap(bitmap);
            }
        }
        public BitmapImage ImageFromBuffer(Byte[] bytes)
        {
            if (bytes == null || bytes.Length == 0) return null;
            var image = new BitmapImage();
            using (var mem = new MemoryStream(bytes))
            {
                mem.Position = 0;
                image.BeginInit();
                image.CreateOptions = BitmapCreateOptions.PreservePixelFormat;
                image.CacheOption = BitmapCacheOption.OnLoad;
                image.UriSource = null;
                image.StreamSource = mem;
                image.EndInit();
            }
            image.Freeze();
            return image;
        }
        
    }
}
