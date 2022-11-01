using System.Text;
namespace practical1
{
    class Program
    {
        static void Main(string[] args)
        {
            int no1, no2, no3, no4, product;
            Console.WriteLine("Enter Four No : ");
            no1 = Convert.ToInt32(Console.ReadLine());
            no2 = Convert.ToInt32(Console.ReadLine());
            no3 = Convert.ToInt32(Console.ReadLine());
            no4 = Convert.ToInt32(Console.ReadLine());
            product = no1 * no2 * no3 * no4;
            Console.WriteLine("Product of Given No = " + product);
            Console.ReadLine();
        }
    }
}