using System;


namespace _3._1
{
    public class ShapeFactory
    {
        public static Shape creatShape(int choice) {
            Shape shape = null;
            Random rd = new Random();
            double rd1 = rd.Next(1, 10);
            double rd2 = rd.Next(1, 10);
            double rd3 = rd.Next(1, 10);
            switch (choice)
            {
                case 0:
                    shape = new Rectangle(rd1,rd2);
                    break;
                case 1:
                    shape = new Square(rd1);
                    break;
                case 2:
                    shape = new Triangle(rd1,rd2,rd3);
                    break;
            }
            return shape;
        }



        
    }

  



}

