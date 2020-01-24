class Modular
{
    private const int M = 1000000007;
    private long value;
    public Modular(long value) { this.value = value; }
    public static implicit operator Modular(long a)
    {
        var m = a % M;
        return new Modular((m < 0) ? m + M : m);
    }
    public static Modular operator +(Modular a, Modular b)
    {
        return a.value + b.value;
    }
    public static Modular operator -(Modular a, Modular b)
    {
        return a.value - b.value;
    }
    public static Modular operator *(Modular a, Modular b)
    {
        return a.value * b.value;
    }
    private static Modular Pow(Modular a, int n)
    {
        switch (n)
        {
        case 0:
            return 1;
        case 1:
            return a;
        default:
            var p = Pow(a, n / 2);
            return p * p * Pow(a, n % 2);
        }
    }
    public static Modular operator /(Modular a, Modular b)
    {
        return a * Pow(b, M - 2);
    }
    private static readonly List<int> facs = new List<int> { 1 };
    private static Modular Fac(int n)
    {
        for (int i = facs.Count; i <= n; ++i)
        {
            facs.Add((int)(Math.BigMul(facs.Last(), i) % M));
        }
        return facs[n];
    }
    public static Modular Ncr(int n, int r)
    {
        return (n < r)  ? 0
             : (n == r) ? 1
                        : Fac(n) / (Fac(r) * Fac(n - r));
    }
    public static explicit operator int(Modular a)
    {
        return (int)a.value;
    }
}
