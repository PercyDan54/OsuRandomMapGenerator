namespace RandomMap
{
    public class Pos
    {
        private const int min_x = 0;
        private const int max_x = 512;
        private const int min_y = 0;
        private const int max_y = 384;

        public int X;
        public int Y;

        public Pos(int x = 256, int y = 192)
        {
            X = x;
            Y = y;
        }

        public static Pos operator +(Pos a, Pos b) => new Pos(a.X + b.Y, a.Y + b.Y);
        public static Pos operator *(Pos a, Pos b) => new Pos(a.X * b.Y, a.Y * b.Y);

        public bool IsInField => X > max_x || X < min_x || Y > max_y || Y < min_y;
    }
}
