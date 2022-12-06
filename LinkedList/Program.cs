namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating Project For LinkedList Program");

            LinkedList myLinkedList = new LinkedList();
            myLinkedList.Append(30);
            myLinkedList.Append(56);
            myLinkedList.Append(70);
        }
    }
}