using System;


namespace _3._1
{
    //图形的接口
   public interface Shape
    {   
        public double GetArea();
        public bool Judge(); 
    }

    //长方形类
    class Rectangle : Shape
    {
        private double Length { get; set; }
        private double Width { get; set; }

        public Rectangle() { }
        public Rectangle(double Length,double Width) 
        {
            this.Length = Length;
            this.Width = Width;
        }
        public double GetArea()
        {   if (Judge())
            {
                return Length * Width;
            }
            else
            {
                Console.WriteLine("图形不合法，该长方形面积将不会计入总面积");
                    return 0;
            }
            
        }

        public bool Judge()
        {
            if (Length <= 0 || Width <= 0) { return false; }
            else if (Length <= Width) { return false; } 
            else { return true; }

        }
}
    
    //正方形的类
    class Square : Shape
    {
        private double Side { get; set; }

        public Square(){}
        public Square(double Side)
        {
            this.Side = Side;
        }

        public double GetArea()
        {   if (Judge())
            {
                return Side * Side;
            }
            else
            {
                Console.WriteLine("图形不合法，该正方形面积将不会计入总面积");
                return 0;
            }
        }

        public bool Judge()
        {
            if(Side <= 0) { return false; }
            else { return true; }
        }
    }

    //三角形的类
    class Triangle: Shape
    {
        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }

        public Triangle() { }
        public Triangle(double Side1,double Side2,double Side3)
        {
            this.a = Side1;
            this.b = Side2;
            this.c = Side3;
        }

        public double GetArea()
        {
            if (Judge())
            {
                return 0.25 * Math.Sqrt((a + b + c) * (a + b - c) * (a + c - b) * (b + c - a));
            }
            else
            {
                Console.WriteLine("图形不合法，该三角形面积将不会计入总面积");
                return 0;
            }
        }

        public bool Judge()
        {
            if (a + b <= c) { return false; }
            else if (a + c < b) { return false; }
            else if (b + c <= a) { return false; }
            else { return true; } 
        }

    }

        class Program
    {



        static void Main(string[] args)
        {
            double sum = 0.0;

            for(int i = 0; i < 10; i++)
            {
                Random rd = new Random();
                int choice = rd.Next(0, 2);
                Shape randomShape = ShapeFactory.creatShape(choice);
                sum += randomShape.GetArea();
            }
          
            Console.WriteLine("总面积为：" + sum);

        }
    }
}
