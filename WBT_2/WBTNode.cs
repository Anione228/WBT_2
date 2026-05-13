namespace WBT_2
{
    public class WBTNode
    {
        public int Key, Size = 1;
        public WBTNode Left, Right;
        public WBTNode(int key) => Key = key;
        public void Update() => Size = 1 + (Left?.Size ?? 0) + (Right?.Size ?? 0);
    }
}