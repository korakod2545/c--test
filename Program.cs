using System;

namespace New_folder
{
    struct Area
    {
        public int height;
        public int width;

        public Area(int height, int width)
        {
            this.height = height;
            this.width = width;
        }
        public int ProcessArea()
        {
            return this.height * this.width;
        }
    }
    class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine(" ..... Compare Area Square ...... ");
            Area[] area = new Area[2];
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Square ( {0} )  ", i + 1);
                Console.Write("Input height : ");
                area[i].height = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input width : ");
                area[i].width = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Area : " + area[i].ProcessArea());
                Console.WriteLine("-------------");
            }
            if (area[0].ProcessArea() > area[1].ProcessArea())
            {
                Console.WriteLine("Square[1] Area more then Square[2] : " + (area[0].ProcessArea() - area[1].ProcessArea()));

            }
            else if (area[0].ProcessArea() < area[1].ProcessArea())
            {
                Console.WriteLine("Square[1] Area less than Square[2] : " + (area[1].ProcessArea() - area[0].ProcessArea()));

            }
            else
            {
                Console.WriteLine("Square[1] Area equal to  Square[2] ");

            }

            Console.ReadKey(true);
        }
    }
}