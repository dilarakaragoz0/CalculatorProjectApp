namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hesap Makinesi");

            Console.Write("Birinci sayıyı giriniz: ");
            int sayi1 = int.Parse(Console.ReadLine());
            
            Console.Write("İşlem seçiniz (+) (-) (*) (/) (%): ");
            string islem = Console.ReadLine();

            Console.Write("ikinci sayıyı giriniz: ");
            int sayi = int.Parse(Console.ReadLine());


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
            }
        }
    }
}