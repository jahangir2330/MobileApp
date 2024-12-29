using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace AppConfig.HelperClasses
{
    public static class ImageHelper
    {
        public static string BitmapToBase64(Bitmap bitmap)
        {
            // Convert the Bitmap to a MemoryStream
            using (MemoryStream ms = new MemoryStream())
            {
                // Save the Bitmap to the MemoryStream in the desired image format
                bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg); // You can use other formats like PNG or GIF

                // Convert the MemoryStream to a byte array
                byte[] imageBytes = ms.ToArray();

                // Convert the byte array to a base64 string
                string base64String = Convert.ToBase64String(imageBytes);

                return base64String;
            }
        }
        //public static string Random(this string chars, int length = 8)
        //{
        //    var randomString = new StringBuilder();
        //    var random = new Random();

        //    for (int i = 0; i < length; i++)
        //        randomString.Append(chars[random.Next(chars.Length)]);

        //    return randomString.ToString();
        //}

    }
}
