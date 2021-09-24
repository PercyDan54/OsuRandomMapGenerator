namespace RandomMap
{
    public class Direction
    {
        private int n;

        private void simplify()
        {
            while (n > 5)
                n -= 6;
            while (n < 0)
                n += 6;
        }

        public Direction(int n = 0)
        {
            this.n = n;
            simplify();
        }

        public static Direction operator +(Direction a, Direction b) => new Direction(a.n + b.n);
        public static Direction operator -(Direction a, Direction b) => new Direction(a.n - b.n);

        public Direction Rotate(int n = 0) => this + new Direction(n);
    }
}
