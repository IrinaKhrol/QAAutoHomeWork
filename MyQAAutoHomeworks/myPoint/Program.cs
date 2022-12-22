namespace myPoint
{
    // Create class point with coordinates
    internal class Point
    {
        public int x;
        public int y;

        // Create coordinate output method
        public string GetInfo()
        {
            //coordinates
            return "x = " + x + " y = " + y;


        }
        static void Main(string[] args)
        {
            Point point1 = new Point();
            point1.x = 5;
            point1.y = 10;
            Console.WriteLine("GetInfo For Point 1");
            Console.WriteLine(point1.GetInfo());

            Point point2 = new Point();
            point2.x = 6;
            point2.y = 11;

            Point point3 = new Point();
            point3.x = 7;
            point3.y = 8;

            Point point4 = new Point();
            point4.x = 5;
            point4.y = 10;

            Point point5 = new Point();
            point5.x = 5;
            point5.y = 5;

            Point point6 = new Point();
            point6.x = 3;
            point6.y = 10;

            Point point7 = new Point();
            point7.x = 7;
            point7.y = 11;

            Point point8 = new Point();
            point8.x = 4;
            point8.y = 12;

            Point point9 = new Point();
            point9.x = 12;
            point9.y = 15;

            Point point10 = new Point();
            point10.x = 14;
            point10.y = 17;


            // Create an array of 10 points, display the coordinates of the points in the array using a loop

            Point[] points = { point1, point2, point3, point4, point5, point6, point7, point8, point9, point10 };

            Console.WriteLine("GetInfo For Points in Foreach");

            foreach (Point point in points)
            {
                Console.WriteLine(point.GetInfo());
            }

            //Creating a method to calculate the distance between 2 points

            static double LengthBetweenPoint(Point p1, Point p2)
            {
                return Math.Sqrt(Math.Pow(p2.x - p1.x, 2) + Math.Pow(p2.y - p1.y, 2));
            }
            Console.WriteLine("LengthBetweenPoint For points");
            Console.WriteLine(LengthBetweenPoint(point1, point2));

        }


    }


}