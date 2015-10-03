using System;
namespace practise
{
    class BOX
    {
        int hight;
        int width;
        public BOX(int h, int w)
        {
            this.hight = h;
            this.width = w;

        }
        public int multi()
        {
            return this.hight * this.width;
        }
    }

    class Display
    {
       public static void Main (string[] args)
        {
            BOX h = new BOX(2, 3);
            BOX w = new BOX(3, 4);
            Console.WriteLine("The area Of the Box 1 is: " + h.multi());
            Console.WriteLine("The area Of the Box 2 is: " + w.multi());
        }
    }
}
