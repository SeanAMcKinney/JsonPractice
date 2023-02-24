namespace UserInterface
{
    class Program
    {
        [Obsolete]
        static void Main(string[] args)
        {
            ManualSchemaCreation.Show();
            Console.ReadLine();
            Console.Clear();
            GenerateSchema.Show();
            Console.ReadLine();
        }
    }
}
    