
// // ----------------------------------  Task 1  -----------------------------------
//
// List<int> numbers = new List<int>(){12,32,67,342,2143,5,22,1};
// Console.WriteLine($"oxirgi sonning indexi: {numbers.Count()-1}");

// // ----------------------------------  Task 2  -----------------------------------
//
// List<int>numbers1 = new List<int>(){1,2,3,4,5,6,7,8,9};
// List<int>numbers2 = new List<int>(){2,4,5,6,7,8,9};
// int count = 0;
// for (int i = 0; i < numbers2.Count; i++)
// {
//     for (int j = i; j < numbers1.Count; j++)
//     {
//         if (numbers1[j] == numbers2[i])
//             {
//             count++;
//             }
//     }
// }
//
// if (numbers2.Count == count)
// {
//     Console.WriteLine("2-listdagi barcha element 1-listda bor. ");
// }
// else
// {
//     Console.WriteLine("2-listdagi barcha element 1-listda yo'q. ");
// }

// // ----------------------------------  Task 3  -----------------------------------
//
// List<int> numbers3 = new List<int>(){12,32,67,342,2143,5,22,1};
// numbers3.Reverse();
// Console.Write("Reverse bo'lgan sonlar: ");
// foreach (var item in numbers3)
//     {
//     Console.Write(item+" ");
//     }

// // ----------------------------------  Task 4  -----------------------------------
//
// List<int> numbers4 = new List<int>(){12,33,567,2,2,1,43};
// if (numbers4.Count == 0)
// {
//     Console.WriteLine("Listning ichida son yo'q. ");
// }
// else
// {
//     Console.WriteLine("Listning ichida bir nechta son bor. ");
// }

// // ----------------------------------  Task 5  -----------------------------------
//
// List<int> numbers5 = new List<int>(){12,32,67,342,2143,5,22,1};
// List<int> sublist=numbers5.GetRange(0,4);
// Console.Write("Sublistning qiymatlari: ");
// foreach(int i in sublist)
//     {
//     Console.Write(i+" ");
//     }

// // ----------------------------------  Task 6  -----------------------------------
//
// List<int> numbers6 = new List<int>(){12,32,67,342,2143,5,22,1};
// numbers6.Sort();
// Console.Write("Sort qilingan sonlar: ");
// foreach (var item in numbers6)
// {
//     Console.Write(item+" ");
// }

// // ----------------------------------  Task 7  -----------------------------------
//
// List<int> numbers7 = new List<int>(){12,32,67,342,2143,5,22,1};
// numbers7.RemoveAll(x => numbers7.Contains(x));
// Console.Write("Qolgan sonlar: ");
// foreach (var item in numbers7)
// {
//     Console.WriteLine(item);
// }

// // ----------------------------------  Task 8  -----------------------------------
//
// List<int> numbers8 = new List<int>(){12,32,67,342,2143,5,22,1};
// Console.WriteLine($"Listdagi elementlarning eng katta qiymati: {numbers8.Max()}");
// Console.WriteLine($"Listdagi elementlarning eng kichik qiymati: {numbers8.Min()}");

// // ----------------------------------  Task 9  -----------------------------------
//
// List<int> numbers9 = new List<int>(){12,32,67,342,2143,5,22,1};
// numbers9.RemoveAll(x => x%2==1);
// Console.Write("Qolgan sonlar: ");
// foreach (var item in numbers9)
// {
//     Console.Write(item+" ");
// }

// // ----------------------------------  Task 10  -----------------------------------

