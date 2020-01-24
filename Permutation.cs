static class Permutation<T>
{
    private static void Search(List<T[]> perms, Stack<T> stack, T[] a)
    {
        int N = a.Length;
        if (N == 0)
        {
            perms.Add(stack.Reverse().ToArray());
        }
        else
        {
            var b = new T[N - 1];
            Array.Copy(a, 1, b, 0, N - 1);
            for (int i = 0; i < a.Length; ++i)
            {
                stack.Push(a[i]);
                Search(perms, stack, b);
                if (i < b.Length) { b[i] = a[i]; }
                stack.Pop();
            }
        }
    }
    public static IEnumerable<T[]> All(IEnumerable<T> src)
    {
        var perms = new List<T[]>();
        Search(perms, new Stack<T>(), src.ToArray());
        return perms;
    }
}
