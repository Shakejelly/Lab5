namespace Lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle area = new Circle();
            

            Console.WriteLine("Skriv in radie i cm till en cirkel så visar jag dess area");
            int radie = Convert.ToInt32(Console.ReadLine());
            

            Circle.GetArea();

        }
    }
}