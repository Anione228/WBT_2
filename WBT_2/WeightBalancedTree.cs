namespace WBT_2
{
    public class WeightBalancedTree
    {
        public WBTNode Root;
        private const int Omega = 2;

        public WBTNode WBTNode
        {
            get => default;
            set
            {
            }
        }

        public bool Search(WBTNode n, int k)
        {
            if (n == null) return false;
            if (n.Key == k) return true;
            return k < n.Key ? Search(n.Left, k) : Search(n.Right, k);
        }

        public void Insert(int k) => Root = Insert(Root, k);
        private WBTNode Insert(WBTNode n, int k)
        {
            if (n == null) return new WBTNode(k);
            if (k < n.Key) n.Left = Insert(n.Left, k);
            else if (k > n.Key) n.Right = Insert(n.Right, k);
            else return n; // Ключ уже есть
            n.Update();
            return Rebalance(n);
        }

        public void Delete(int k) => Root = Delete(Root, k);
        private WBTNode Delete(WBTNode n, int k)
        {
            if (n == null) return null;
            if (k < n.Key) n.Left = Delete(n.Left, k);
            else if (k > n.Key) n.Right = Delete(n.Right, k);
            else
            {
                if (n.Left == null) return n.Right;
                if (n.Right == null) return n.Left;
                WBTNode min = n.Right;
                while (min.Left != null) min = min.Left;
                n.Key = min.Key;
                n.Right = Delete(n.Right, min.Key);
            }
            n.Update();
            return Rebalance(n);
        }

        private WBTNode Rebalance(WBTNode n)
        {
            int lW = (n.Left?.Size ?? 0) + 1;
            int rW = (n.Right?.Size ?? 0) + 1;

            if (lW > Omega * rW)
            {
                if (((n.Left.Right?.Size ?? 0) + 1) > ((n.Left.Left?.Size ?? 0) + 1))
                    n.Left = RotateL(n.Left);
                return RotateR(n);
            }
            if (rW > Omega * lW)
            {
                if (((n.Right.Left?.Size ?? 0) + 1) > ((n.Right.Right?.Size ?? 0) + 1))
                    n.Right = RotateR(n.Right);
                return RotateL(n);
            }
            return n;
        }

        private WBTNode RotateR(WBTNode y)
        {
            var x = y.Left; y.Left = x.Right; x.Right = y;
            y.Update(); x.Update(); return x;
        }
        private WBTNode RotateL(WBTNode x)
        {
            var y = x.Right; x.Right = y.Left; y.Left = x;
            x.Update(); y.Update(); return y;
        }
    }
}