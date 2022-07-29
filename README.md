# *Задача*
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 

# *Решение*
## Инструкция
1. Вводите набор символов в файл **inputdata.txt** для разделения между строками используйте **пробел**;
2. Запускаете программу;
3. Отрываете файл **output.txt** нужные строки выведены через запятую.

## Принцип работы программы
Программа берет из файла **inputdata.txt** строку состоящие из набора символов. После разбивает их по строкам использую пробел как разделитель между строками, все остальные символы являются частью элементов строки. Результат работы программа записывает в файл **input.txt**. Используя массив строк из файла **inputdata.txt**, программа проверяет строки на условие задачи (длина строки не превышает трех символов). После в файл **output.txt** записывает строки прошедшие проверку условием.
Решение оформляется в виде массива строк состоящая из набора элементов разделенные запятой, массив строк оканчивается точкой.
## Пример
+ В файле **inputdata.txt** вводите: "1! 23re @#! :l;LK1 K3* fdsf4" /"
+ Запускате программу.
+ В файл **output.txt** выводиться: "1!, @#!, :l;, LK1, K3*, /."

# *Состав*
Создана программа, состоящая из следующих файлов:
1. **BlockDiagram.drawio** - блок схема основного метода решения задачи;
2. __Program.cs__ - файл, выполняющий задачу на языке программирования C#;
3. **nputdata.txt** - текстовый файл в котором пользователь может задать начальные данные.
4. __input.txt__ - промежуточный текстовый файл, состоящий из элементов строк обработанный программой для дальнейшей работы с ней.
5. **output.txt** - тестовый файл в который программа записывает ответ.