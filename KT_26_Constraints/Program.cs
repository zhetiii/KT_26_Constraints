using System;

namespace KT_26_Constraints
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReferenceBox<string> refBox = new ReferenceBox<string>();
            Console.WriteLine($"ReferenceBox создан. Пустой? {refBox.IsEmpty}");

            Console.Write("Введите текст (строку) для заполнения ReferenceBox: ");
            string inputString = Console.ReadLine();
            refBox.Set(inputString);

            Console.WriteLine($"После Set. Пустой? {refBox.IsEmpty}");
            Console.WriteLine($"Значение в ReferenceBox: {refBox.Get()}");

            Console.WriteLine();

            ValueBox<int> valBox = new ValueBox<int>();
            Console.WriteLine($"ValueBox создана. Пустой? {valBox.IsEmpty}");

            Console.Write("Введите целое число для заполнения ValueBox: ");
            int inputInt = int.Parse(Console.ReadLine());
            valBox.Set(inputInt);

            Console.WriteLine($"После Set. Пустой? {valBox.IsEmpty}");
            Console.WriteLine($"Значение в ValueBox: {valBox.Get()}");
            //ReferenceBox<int> invalidRef = new ReferenceBox<int>();
            //ValueBox<string> invalidVal = new ValueBox<string>();

            /*
             * Демонстрация (ошибки компиляции):
             * Если попытаться использовать ReferenceBox с типом значения (int) 
             * или ValueBox со ссылочным типом (string), компилятор выдаст ошибку, 
             * так как типы не соответствуют ограничениям where T : class / where T : struct:
             * 
             * ReferenceBox<int> invalidRef = new ReferenceBox<int>(); // Ошибка: int не является классом
             * ValueBox<string> invalidVal = new ValueBox<string>();   // Ошибка: string не является struct
             */
        }
    }
}
