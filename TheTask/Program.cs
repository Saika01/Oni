string[] array = new string[4];

array[0] = "nose";
array[1] = "see";
array[2] = "enorme";
array[3] = "bo";

PrintArray(array);

Console.WriteLine();

string[] resultArray = CreateArray(array);
FillArray(array, resultArray);

PrintArray(resultArray);

string[] CreateArray(string[] arr)
{
    int counter = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <=3) counter++;
    }
    string[] newArr = new string[counter];
    return newArr;
}

void FillArray(string[] arr, string[] newArr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i].Length <= 3) 
        {
            for (int j = 0; j < newArr.Length; j++)
            {
                if(string.IsNullOrEmpty(newArr[j])) 
                {
                    newArr[j] = arr[i];
                    break;
                } 
            }
        }
    }
}

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"'{arr[i]}' ");
    }
    Console.WriteLine("]");
}

