namespace Program
{
    internal class Program
    {
        public void printName (params string[] name)
        {
            Console.WriteLine(string.Join(", ", name));
        }

        public int sampleNumber(int num)
        {
            if (num == 1)
                return num;

            return num * sampleNumber(num - 1);
        }
        static void Main(string[] Args)
        {
            var program = new Program();

            program.printName("Elmer", "Heather", "Savanah");

            var sum = program.sampleNumber(3);

            Console.WriteLine(sum);
        }
    }
}