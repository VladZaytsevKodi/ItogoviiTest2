/* Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше 3 символа*/

string[] array1 = new string[6] {"yes", "5", "!", "Brains", "01234", "Geek"};
string[] array2 = new string[array1.Length];
SecondArray(array1, array2);
void SecondArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[i] = array1[i];
        }
        count++;
    }
}

PrintArray(array2);
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

