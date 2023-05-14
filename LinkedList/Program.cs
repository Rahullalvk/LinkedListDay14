namespace LinkedList
{

    public class Program
    {
        public static void Main(string[] args)
        {

            SortedLinkedList<int> sortedList = new SortedLinkedList<int>();

            sortedList.Add(56);
            sortedList.Add(30);
            sortedList.Add(40);
            sortedList.Add(70);

            sortedList.Display();
        }


    }
}

    
