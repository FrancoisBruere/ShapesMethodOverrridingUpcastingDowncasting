namespace UpcastingDowncasting
{
    public class Triangle : Shape
    {
        public int LeftHeight { get; set; }
        public int rightHeight { get; set; }
        public override void Draw()
        {
            System.Console.WriteLine("algo to draw a tiangle");
        }

    }
}
