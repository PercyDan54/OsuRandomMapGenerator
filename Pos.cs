using static RandomMap.RandomMapGen;

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
            this.X = x;
            this.Y = y;
        }

        public static Pos operator +(Pos a, Pos b) => new Pos(a.X + b.X, a.Y + b.Y);
        public static Pos operator *(Pos a, int b) => new Pos(a.X * b, a.Y * b);
        public static Pos operator /(Pos a, int b) => new Pos(a.X / b, a.Y / b);

        public bool IsInField => !(X > max_x || X < min_x || Y > max_y || Y < min_y);

        public Pos Step(Direction d, int times = 1)
        {
            switch (d.n)
            {
                default:
                    return this + new Pos(XGrid * times, 0);

                case 1:
                    return this + new Pos(XGrid * times / 2, YGrid * times);

                case 2:
                    return this + new Pos(-XGrid * times / 2, YGrid * times);

                case 3:
                    return this + new Pos(-XGrid * times, 0);

                case 4:
                    return this + new Pos(-XGrid * times / 2, -YGrid * times);

                case 5:
                    return this + new Pos(XGrid * times / 2, -YGrid * times);
            }
        }
    }
}
