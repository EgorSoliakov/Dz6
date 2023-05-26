//Задача 41: Пользователь вводит с клавиатуры M 
//чисел. Посчитайте, сколько чисел больше 0 ввёл 
//пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите числа: ");
string[] nums_strings = Console.ReadLine().Split();
int[] nums = new int[nums_strings.Length];
for(int i = 0; i < nums_strings.Length; i++)
    nums[i] = Convert.ToInt32(nums_strings[i]);
Console.WriteLine(nums);
Console.Write($"  ->{PositiveNumbers(nums)}");


int PositiveNumbers(int[] arr)
{
    int count = 0;
     for(int i =0; i<arr.Length; i++)
     
     if(arr[i]>0)
     {  
        count = count +1;
     }
     return count;
} 

// Все работает, но не понимаю как в консоле, после запуска, убрать "System.Int32[]".
