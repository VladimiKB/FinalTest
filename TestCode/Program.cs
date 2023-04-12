// Первый способ

// Console.Clear();

// string[] arr = new string[6] {"124", "23", "hello", "world", "rus", "test"};
// string[] newArr = new string[arr.Length];

// void ArrayCreationByTask(string[] arr, string[] newArr)
// {
//     int j = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//     if(arr[i].Length <= 3)
//         {
//         newArr[j] = arr[i];
//         j++;
//         }
//     }
// }

// void ArrayPrinted(string[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// ArrayCreationByTask(arr, newArr);
// ArrayPrinted(newArr);
// Console.WriteLine();

// Второй способ

// Console.Clear();

// Console.Write("Введите количество строк в массиве: ");
//     int n = int.Parse(Console.ReadLine());

//     string[] arr = new string[n];

//     for (int i = 0; i < n; i++){
//         Console.Write($"Введите строку {i + 1}: ");
//         arr[i] = Console.ReadLine();
//     }

//     string[] newArr = new string[n];

//     int j = 0;
//     for (int i = 0; i < n; i++){
//         if (arr[i].Length <= 3){
//             newArr[j] = arr[i];
//             j++;
//         }
//     }

//     Console.WriteLine("Новые строки массива:");
//     for (int i = 0; i < j; i++){
//         Console.WriteLine(newArr[i]);
//     }
