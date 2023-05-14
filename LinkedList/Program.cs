namespace LinkedList
{

    public class Program
    {
        public static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();

            linkedList.Add(70);
            linkedList.Add(56);
            linkedList.Add(30);
            linkedList.Add(40);

            linkedList.Delete(40);

            linkedList.Display();
            Console.WriteLine($"Size of LinkedList: {linkedList.Size()}");
        }
    }
}

    
