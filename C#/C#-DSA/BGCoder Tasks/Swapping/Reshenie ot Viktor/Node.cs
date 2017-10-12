namespace Swapping
{
    public class Node
    {
        public int Value { get; private set; }

        public Node Left { get; private set; }
        public Node Right { get; private set; }

        public Node(Node end, int x)
        {
            this.Value = x;

            this.Left = end;
            this.Right = null;

            if (end != null)
            {
                end.Right = this;
            }
        }

        public static void Detach(Node x)
        {
            if (x.Left != null)
            {
                x.Left.Right = null;
            }
            if (x.Right != null)
            {
                x.Right.Left = null;
            }

            x.Left = null;
            x.Right = null;
        }

        public static void Attach(Node l, Node r)
        {
            if (l == r)
            {
                return;
            }

            l.Right = r;
            r.Left = l;
        }
    }
}
