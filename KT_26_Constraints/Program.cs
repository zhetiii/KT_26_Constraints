using System;

namespace KT_26_Constraints
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ==========================================
            // ЗАДАНИЕ 1. Обёртки
            // ==========================================

            Console.WriteLine("=== ЗАДАНИЕ 1: Обёртки ===");

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


            // ==========================================
            // ЗАДАНИЕ 2. Кэш
            // ==========================================

            Console.WriteLine("=== ЗАДАНИЕ 2: Кэш ===");
            ReferenceCache<string> refCache = new ReferenceCache<string>();

            bool refFoundEmpty = refCache.TryGet(out string? refValEmpty);
            Console.WriteLine($"TryGet на пустом ReferenceCache<string> -> {refFoundEmpty}, значение: {(refValEmpty == null ? "null" : refValEmpty)}");

            Console.Write("Введите строку для заполнения ReferenceCache: ");
            string cacheStrInput = Console.ReadLine();
            refCache.Set(cacheStrInput);

            bool refFoundFull = refCache.TryGet(out string? refValFull);
            Console.WriteLine($"TryGet на заполненном ReferenceCache<string> -> {refFoundFull}, корректное значение: {refValFull}");

            Console.WriteLine();

            ValueCache<double> valCache = new ValueCache<double>();

            bool valFoundEmpty = valCache.TryGet(out double? valValEmpty);
            Console.WriteLine($"TryGet на пустом ValueCache<double> -> {valFoundEmpty}");

            Console.Write("Введите вещественное число (например, 45.67) для заполнения ValueCache: ");
            double cacheDoubleInput = double.Parse(Console.ReadLine());
            valCache.Set(cacheDoubleInput);

            bool valFoundFull = valCache.TryGet(out double? valValFull);
            Console.WriteLine($"TryGet на заполненном ValueCache<double> -> {valFoundFull}, корректное значение: {valValFull}");

            // ReferenceCache<double> invalidRefCache = new ReferenceCache<double>();
            // ValueCache<string> invalidValCache = new ValueCache<string>();

            /*
             * демонстрация ошибок компиляции (для задания 2):
             * ReferenceCache<double> invalidRefCache = new ReferenceCache<double>();
             * ValueCache<string> invalidValCache = new ValueCache<string>();
             */


        }
    }
}
