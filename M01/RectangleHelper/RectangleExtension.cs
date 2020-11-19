using System;
using System.Runtime.CompilerServices;

namespace RectangleHelper
{
    public static class RectangleExtension
    {
        //int
        public static int Perimeter(this int width, int length)
        {
            int p = 0;

            if (width > 0 && length > 0)
            {
                p = (2 * length) + (2 * width);
            }
            return p;
        }

        public static int Square(this int width, int length)
        {
            int square = 0;

            if (width > 0 && length > 0)
            {
                square = length * width;
            }
            return square;
        }
        //double
        public static double Perimeter(this double width, double length)
        {
            double p = 0;

            if (width > 0 && length > 0)
            {
                p = (2 * length) + (2 * width);
            }
            return p;
        }

        public static double Square(this double width, double length)
        {
            double square = 0;

            if (width > 0 && length > 0)
            {
                square = length * width;
            }
            return square;
        }

        //float
        public static float Perimeter(this float width, float length)
        {
            float p = 0;

            if (width > 0 && length > 0)
            {
                p = (2 * length) + (2 * width);
            }
            return p;
        }

        public static float Square(this float width, float length)
        {
            float square = 0;

            if (width > 0 && length > 0)
            {
                square = length * width;
            }
            return square;
        }
    }
}
