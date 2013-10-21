using System;


namespace WCCon
{
    class Square
    {
        public int Length { get; set; }

        public Square(int l)
        {
            Length = l;
        }
    
        public Square(){}

        public void Draw()
        {
            for (int i = 0; i < Length; i++)
            {
                for (int j = 0; j < Length; j++)
                {
                    Console.Write("*");
                }
                
                Console.WriteLine();
            }
        }

        public override string ToString()
        {
            return string.Format("[Length ={0}]", Length);
         
        }

        public static explicit operator Square(Rectangle r)
        {
            Square s = new Square(r.Height);

            return s;
        }
    }
}
