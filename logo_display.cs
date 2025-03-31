using System;
using System.Drawing;
using System.IO;
namespace part_one
{
    public class logo_display
    {
        public logo_display()
        {

            //get full location of the project 
            string full_location = AppDomain.CurrentDomain.BaseDirectory;

            //replacing the bin\\Debug\\
            string new_location = full_location.Replace("bin\\Debug\\", "");

            //then combine the path
            string full_path = Path.Combine(new_location, "cyber.png");

            //time to use ascii

            //creating bitmap class
            Bitmap image = new Bitmap(full_path);

            //then set the size 
            image = new Bitmap(image, new Size(150, 120));

            //outer and inner loop
            //these loops are the ones printing the logo
            for (int height = 0; height < image.Height; height++)
            {
                for (int width = 0; width < image.Width; width++)
                {
                    Color pixelColor = image.GetPixel(width, height);
                    int gray = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                    char asciiChar = gray > 200 ? '.' : gray > 150 ? '*' : gray > 100 ? 'o' : gray > 50 ? '#' : '@';

                    Console.Write(asciiChar);
                }
                Console.WriteLine();
            }


        }
    }
}