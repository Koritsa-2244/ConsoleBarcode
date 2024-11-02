using BarcodeLib;
using System;
using System.Text;
class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Введите текст для кодирования:");
            string inputText = Console.ReadLine();

            // Создание объекта Barcode
            Barcode barcode = new Barcode(inputText);

            // Вывод штрих-кода
            Console.WriteLine(barcode.ToString());
            Console.ReadKey();
        }
    }
}