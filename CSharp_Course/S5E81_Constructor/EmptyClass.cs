using System;

namespace S5E81_Constructor
{
    // Example of using "this" Key-word

    public class Point2D
    {
        private int x;

        private int y;


        public Point2D(int x, int y) //Constructor (ctor)
        {
            this.x = x;
            this.y = y;
        }
    }
}
