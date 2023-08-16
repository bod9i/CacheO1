namespace CustomLinkedList
{
    public class CustomLinkedList<T>
    {
        private CustomNode<T> head;
        private CustomNode<T> last;
        private int count;
        public CustomLinkedList()
        {
            count = 0;
        }

        public CustomNode<T> Last => last;
        public CustomNode<T> First => head;

        public CustomNode<T> Add(CustomNode<T> node) 
        {
            if (head == null) 
            {
                head = new CustomNode<T>
                {
                    Value = node.Value
                };

                last = head;

                count++;
                return head;
            }

            var newNode = new CustomNode<T>
            {
                Value = node.Value,
                Prev = last
            };

            last.Next = newNode;
            last = newNode;

            count++;

            return newNode;
        }

        public void Remove(CustomNode<T> item)
        {
            if (item == null || head == null)
            {
                return;
            }

            if (item == head)
            {
                head.Next.Prev = null!;
                head = head.Next;
                count--;
                return;
            }

            item.Next.Prev = item.Prev;
            item.Prev.Next = item.Next;

            count--;
        }
    }
}
