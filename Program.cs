// Напишите программму, которая из имеющегося массива строк формирует массив 
//из строк, длина которых меньше или равна 3 символа.
string[] myArray = { "Елена", "Яна", "Ольга", "Ада", "Зоя", "Мария", "Ая" };string[] newArray = CreatNewArray(myArray);

string[] CreatNewArray(string[] array)
{
    string[] newArray = new string[array.Length];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[j] = array[i];
            j++;
        }
    }
    Array.Resize(ref newArray, j);
    return newArray;
}