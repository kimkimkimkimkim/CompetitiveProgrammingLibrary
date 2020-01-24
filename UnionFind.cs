class Node<T>
{
    private int m_height;
    private Node<T> m_parent;
    public T Item { get; private set; }
    public Node(T item)
    {
        m_height = 0;
        m_parent = this;
        Item = item;
    }
    public Node<T> Find()
    {
        if (m_parent == this) { return this; }

        Node<T> parent = m_parent.Find();
        m_parent = parent;
        return parent;
    }
    public static void Unite(Node<T> a, Node<T> b)
    {
        Node<T> p = a.Find();
        Node<T> q = b.Find();
        if (p.m_height < q.m_height)
        {
            p.m_parent = q;
            q.m_height = Math.Max(p.m_height + 1, q.m_height);
        }
        else
        {
            q.m_parent = p;
            p.m_height = Math.Max(q.m_height + 1, p.m_height);
        }
    }
}
