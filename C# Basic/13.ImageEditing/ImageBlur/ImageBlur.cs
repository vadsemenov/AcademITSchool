using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace ImageBlur
{
    internal class ImageBlur
    {
        private static readonly double[,] BlurFilter =
        {
            {1.0 / 9, 1.0 / 9, 1.0 / 9},
            {1.0 / 9, 1.0 / 9, 1.0 / 9},
            {1.0 / 9, 1.0 / 9, 1.0 / 9}
        };

        private static readonly double[,] PressFilter =
        {
            {0, 1, 0},
            {-1, 0, 1},
            {0, -1, 0}
        };

        private static readonly double[,] SharpFilter =
        {
            {0, -1, 0},
            {-1, 5, -1},
            {0, -1, 0}
        };

        static void Main(string[] args)
        {
            using Bitmap sourceImage = new Bitmap("..\\..\\..\\image.jpg");

            using Bitmap destinationImage = new Bitmap(sourceImage.Width, sourceImage.Height);

            ApplyFilter(BlurFilter, sourceImage, destinationImage);

            destinationImage.Save("..\\..\\..\\out.jpg", ImageFormat.Jpeg);
        }

        private static void ApplyFilter(double[,] filter, Bitmap sourceImage, Bitmap destinationImage)
        {
            int filterHalfHeight = filter.GetLength(0) / 2;
            int filterHalfWidth = filter.GetLength(1) / 2;

            int yUpperLimit = sourceImage.Height - filterHalfHeight;
            int xUpperLimit = sourceImage.Width - filterHalfWidth;

            for (int y = filterHalfHeight; y < yUpperLimit; ++y)
            {
                for (int x = filterHalfWidth; x < xUpperLimit; ++x)
                {
                    Color pixel = GetModifiedPixel(sourceImage, filter, x, y);

                    destinationImage.SetPixel(x, y, pixel);
                }
            }
        }

        private static Color GetModifiedPixel(Bitmap image, double[,] filter, int x, int y)
        {
            double redComponent = 0;
            double greenComponent = 0;
            double blueComponent = 0;

            int filterWidth = filter.GetLength(1);
            int filterHeight = filter.GetLength(0);

            int filterHalfHeight = filterHeight / 2;
            int filterHalfWidth = filterWidth / 2;

            for (int i = 0; i < filterHeight; i++)
            {
                int neighborPixelY = y + i - filterHalfHeight;

                for (int j = 0; j < filterWidth; j++)
                {
                    int neighborPixelX = x + j - filterHalfWidth;

                    Color sourcePixel = image.GetPixel(neighborPixelX, neighborPixelY);

                    redComponent += sourcePixel.R * filter[i, j];
                    greenComponent += sourcePixel.G * filter[i, j];
                    blueComponent += sourcePixel.B * filter[i, j];
                }
            }

            return Color.FromArgb(
                NormalizeComponent(redComponent),
                NormalizeComponent(greenComponent),
                NormalizeComponent(blueComponent));
        }

        private static int NormalizeComponent(double component)
        {
            if (component >= 255)
            {
                return 255;
            }

            if (component <= 0)
            {
                return 0;
            }

            return (int)Math.Round(component, MidpointRounding.AwayFromZero);
        }
    }
}