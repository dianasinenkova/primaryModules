using System;
using System.Runtime.CompilerServices;

namespace RectangleHelper
{
    public static class RectangleExtension
    {
        //int
        public static int Perimeter(int width, int length)
        {
            int p = 0;

            if (width > 0 && length > 0)
            {
                p = (2 * length) + (2 * width);
            }
            return p;
        }

        public static int Square(int width, int length)
        {
            int square = 0;

            if (width > 0 && length > 0)
            {
                square = length * width;
            }
            return square;
        }
        //double
        public static double Perimeter(double width, double length)
        {
            double p = 0;

            if (width > 0 && length > 0)
            {
                p = (2 * length) + (2 * width);
            }
            return p;
        }

        public static double Square(double width, double length)
        {
            double square = 0;

            if (width > 0 && length > 0)
            {
                square = length * width;
            }
            return square;
        }

        //float
        public static float Perimeter(float width, float length)
        {
            float p = 0;

            if (width > 0 && length > 0)
            {
                p = (2 * length) + (2 * width);
            }
            return p;
        }

        public static float Square(float width, float length)
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
