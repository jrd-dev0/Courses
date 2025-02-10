namespace Generics_1.Services
{
    internal class PrintService<T>
    {
        public List<T> list = new List<T>();

        public void AddValue(T value)
        {
            list.Add(value);
        }
        public void RemoveValue(T value)
        {
            list.Remove(value);
        }

        public T First()
        {
            return list.First();
        }

        public void Print()
        {
            Console.Write("[");

            int x = 1;

            foreach (T n in list)
            {
                Console.Write(n);
                if (x < list.Count)
                {
                    Console.Write(", ");
                }
                x++;
            }

            Console.WriteLine("]");
        }
    }
}