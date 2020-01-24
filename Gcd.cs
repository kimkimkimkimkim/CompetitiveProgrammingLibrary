static long Gcd(long a, long b)
{
    var v = new[] { a, b };
    while (v[1] != 0) { v = new[] { v[1], v[0] % v[1] }; }
    return v[0];
}

static long Lcm(long a, long b)
{
    return a / Gcd(a, b) * b;
}
