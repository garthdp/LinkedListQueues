namespace LinkedListQueues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queues q = new Queues();
            q.enqueue(10);
            q.enqueue(20);
            q.enqueue(30);
            q.dequeue();
            q.dequeue();
            q.dequeue();
            Console.WriteLine("Queue front: " + ((q.front!=null)? (q.front).key:-1));
            Console.WriteLine("Queue Rear: " + ((q.rear!=null)?(q.rear).key:-1));
        }
    }
}
