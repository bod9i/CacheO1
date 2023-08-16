namespace CustomLinkedList
{
    public class CustomNode<T>
    {
        public CustomNode<T> Prev { get; set; }
        public CustomNode<T> Next { get; set; }
        public T Value { get; set; }
    }
}