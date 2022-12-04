using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace ImageTest
{
    class GrayscaleColors
    {
        static void Main(string[] args)
        {
            using Bitmap image = new Bitmap("..\\..\\..\\image.jpg");

            for (int y = 0; y < image.Height; ++y)
            {
                for (int x = 0; x < image.Width; ++x)
                {
                    Color pixel = image.GetPixel(x, y);

                    int pixelGrayScaleColor = (int) Math.Round(0.3 * pixel.R + 0.59 * pixel.G + 0.11 * pixel.B);

                    Color newPixel = Color.FromArgb(pixelGrayScaleColor, pixelGrayScaleColor, pixelGrayScaleColor);

                    image.SetPixel(x, y, newPixel);
                }
            }

            image.Save("..\\..\\..\\out.jpg", ImageFormat.Jpeg);
        }
    }
}