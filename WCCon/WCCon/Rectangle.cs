using System;


namespace WCCon
{
    class Rectangle
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle(int w, int h)
        {
            Width = w;
            Height = h;
        }

        public Rectangle() { }

        public void Draw()
        {
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public override string ToString()
        {
            return string.Format("[Width ={0};Height= {1}]",Width,Height);

        }

        public static implicit operator Rectangle(Square s)
        {
            Rectangle r = new Rectangle(s.Length*2,s.Length);

            return r;
        }
    } 
}
