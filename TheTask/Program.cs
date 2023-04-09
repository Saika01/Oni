string[] array = new string[4];

array[0] = "nose";
array[1] = "see";
array[2] = "enorme";
array[3] = "bo";

string[] CreateArrayThreeSymbolsLess(string[] arr)
{
    string[] newArr = new string[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <=3) newArr[i] = arr[i];
    }
    return newArr;
}