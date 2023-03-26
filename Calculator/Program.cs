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
            double sayi2 = double.Parse(Console.ReadLine());

            double sonuc = 0;

            switch (islem)
            {
                case "+":sonuc= sayi1 + sayi2;break;

                case "-":sonuc = sayi1 - sayi2;break;
                    
                case "*":sonuc = sayi1 * sayi2;break;
                    
                case "/":sonuc = sayi1 / sayi2;break;
                    
                case "%":sonuc = sayi1 % sayi2;break;
            }
            Console.WriteLine(sayi1 + " " + islem + " " + sayi2 + " = "+  sonuc);
        }
    }
}