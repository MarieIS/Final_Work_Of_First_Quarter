void PrintArray(string[] array)
{
  if (array.Length == 0)
   {
     Console.WriteLine("The array is empty!");
   }
   else
   {
     Console.WriteLine("[" + string.Join(", ", array) + "]");
   } 
}

string[] GetNewArray(string[] array)
{
   int length = array.Length;
   string[] newarr = new string[length];   
   int count = 0;
   for (int i = 0; i < length; i++)
   {
      if (array[i].Length <= 3)
       {
         newarr[count] = array[i];
         count++;
       }
   }
   Array.Resize(ref newarr, count);
   return newarr;
}

string [] GetAnArray(int size) {
   string [] array = new string[size];
   for (int i = 0; i < size; i++){
    Console.Write("Insert an element: ");
    array[i] = Console.ReadLine();
   }
   return array;
}

int GetNumberAmount(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int number1 = GetNumberAmount("Введите желаемое количество элементов массива: ");
string [] arr1 = GetAnArray(number1);
Console.WriteLine("The first array: ");
PrintArray(arr1);
string [] arr2 = GetNewArray(arr1);
Console.WriteLine("The second array: ");
PrintArray(arr2);