# ЗАДАЧА :

Написать программу, которая из имеющегося массива строк формирует новый
массив строк, длина которых меньше, либо равна трем символам.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте
выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями, лучше обойтись
исключительно массивами.

# Описание алгоритма решения :

*Первый способ*

Сначало определяются два массива строк: первый - с заданными параметрами
и второй - с заданной длинной, равной длине первого массива.
Затем вызывается метод, который наполняет второй массив элементами из
первого массива, которые имеют длину не более трех символов.
В завершении кода вызывается метод, котрый выводит элементы вторго массива
в консоль.

*Второй способ*

Сначало формируется первый массив путем введения данных с клавиатуры:
количество строк и каждый элемент массива.
Затем создается втрой массив с размером равным первому массиву и 
наполняется с помощью цикла элементами из первого массива, которые
имеют длину не более трех символов.
После завершения цикла элементы второго массива выводится в
консоль.

# Дополнительная информация :

1. Блок-схема размещена в папке _**Block-Diagram**_ в двух файлах с разными расширениями.
2. Код написан в _**C#**_ и путь к коду в репозитории _**TestCode/Program.cs**_.
