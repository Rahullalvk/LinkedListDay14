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

            Node result = linkedList.Search(30);
            if (result != null)
            {
                Console.WriteLine("Node with value 30 found.");
            }
            else
            {
                Console.WriteLine("Node with value 30 not found.");
            }

            linkedList.Display();
        }
    }
}
    
