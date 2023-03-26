namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hesap Makinesi");

            Console.Write("Birinci sayıyı giriniz: ");
            double sayi1 = double.Parse(Console.ReadLine());
            
            Console.Write("İşlem seçiniz (+) (-) (*) (/) (%): ");
            string islem = Console.ReadLine();

            Console.Write("ikinci sayıyı giriniz: ");
            double sayi = double.Parse(Console.ReadLine());


            switch (islem)
            {
                case "+":
                    Console.WriteLine(sayi1+sayi);
                    break;

                case "-":
                    Console.WriteLine(sayi1-sayi);
                    break;
                
                case "*":
                    Console.WriteLine(sayi1*sayi);
                    break;
                
                case "/":
                    Console.WriteLine(sayi1/sayi);
                    break;
            }
        }
    }
}