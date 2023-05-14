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

            linkedList.InsertAfter(30, 40);

            linkedList.Display();
        }
    }
}
    
