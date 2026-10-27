# KT_26_Constraints

# Вариант 1. Обёртки
1) ReferenceBox<T> where T : class с методами Set(T item), bool IsEmpty, T? Get(), использующий null как «пустое» состояние.
2) ValueBox<T> where T : struct с тем же набором методов, использующий Nullable<T> (T?) как «пустое» состояние.
3) Продемонстрируйте ReferenceBox<string> (или своим классом): пустое и заполненное состояние.
4) Продемонстрируйте ValueBox<int> (или своей структурой): пустое и заполненное состояние.
5) Продемонстрируйте (закомментированным кодом с пояснением), что ReferenceBox<int> и ValueBox<string> не компилируются.

# Ограничения
Оба класса в выбранном варианте обязаны решать задачу «пустого» состояния именно через соответствующий своему ограничению механизм — null напрямую для class-варианта и Nullable<T> для struct-варианта, а не одинаковым способом для обоих.

# Результаты и проверочные ключи
<img width="1352" height="207" alt="изображение" src="https://github.com/user-attachments/assets/05d8ea20-bccf-442e-8846-9350a0dbef57" />

# Мои результаты:
<img width="902" height="394" alt="изображение" src="https://github.com/user-attachments/assets/89b70d26-abf0-47e2-ad11-2164f3f9177c" />

# А также мой результат с ошибкой:
<img width="1919" height="1140" alt="изображение" src="https://github.com/user-attachments/assets/edc2cd44-0e7c-465b-83ef-6771320ab2d0" />

# Вариант 2. Кэш
1) ReferenceCache<T> where T : class с методом bool TryGet(out T? value), возвращающим false и null, если кэш пуст, и true с сохранённым значением — иначе.
2) ValueCache<T> where T : struct с тем же по смыслу методом bool TryGet(out T? value), использующим Nullable<T> внутри для представления «пусто».
3) Продемонстрируйте ReferenceCache<string> (или своим классом): попадание и промах кэша.
4) Продемонстрируйте ValueCache<double> (или своей структурой): попадание и промах кэша.
5) Продемонстрируйте (закомментированным кодом с пояснением), что ReferenceCache<double> и ValueCache<string> не компилируются.

# Ограничения
Оба класса в выбранном варианте обязаны решать задачу «пустого» состояния именно через соответствующий своему ограничению механизм — null напрямую для class-варианта и Nullable<T> для struct-варианта, а не одинаковым способом для обоих.

# Результаты и проверочные ключи
<img width="1523" height="295" alt="изображение" src="https://github.com/user-attachments/assets/979f2f12-dd02-47cc-9e71-ce227ddf9030" />

# Мои результаты:
<img width="1012" height="260" alt="изображение" src="https://github.com/user-attachments/assets/8c227413-731d-4e9d-a2b4-e540c70c823a" />

# А также мой результат с ошибкой:
<img width="1280" height="201" alt="изображение" src="https://github.com/user-attachments/assets/7d245c60-2e31-496e-8dbd-ae873f3a63a9" />

