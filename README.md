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

