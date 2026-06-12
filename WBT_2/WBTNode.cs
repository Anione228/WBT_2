namespace WBT_2
{
    public class WBTNode
    {
        public int Key;
        public int Size = 1;
        public WBTNode Left, Right;

        public WBTNode(int key) => Key = key;

        public WBTNode WBTNode1
        {
            get => default;
            set
            {
            }
        }

        public void Update()
        {
            this.Size = (Left?.Size ?? 0) + (Right?.Size ?? 0)+1;
        }
    }
}