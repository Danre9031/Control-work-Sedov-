string[] GetData(string path)
{
    string[] res = File.ReadAllText(path)
      .Split(new char[] { ' ' }
      , StringSplitOptions.RemoveEmptyEntries);
    string[] element = new string[res.Count()];
    for (int i = 0; i < element.Length; i++)
        element[i] = res[i];
    return element;
}
string[] FunctionSelectedElement(string[] inputArray)
{
    bool CountInElements(string elements)
    {
        int lengthElements = elements.Length;
        if (lengthElements <= 3) return true;
        else return false;
    }
    string CountElements(string[] array)
    {

        int result = 0;
        int length = array.Length;
        for (int i = 0; i < length; i++)
            if (CountInElements(array[i])) 
                result++;
        string stringResult = Convert.ToString(result);
        return stringResult;
    }
    string[] outputArray = new string[Convert.ToInt32(CountElements(inputArray))];
    int count = inputArray.Length;
    int index = 0;
    int i = 0;
    while (i < count)
    {
        if (CountInElements(inputArray[i]))
        {
            outputArray[index] = inputArray[i];
            index = index + 1;
        }
        i = i + 1;
    }
    return outputArray;
}

string Print(string[] array)
{
    int length = array.Length;
    string output = String.Empty;
    for (int i = 0; i < length; i++)
    {
        if(i==length-1) output += ($"{array[i]}.");
        else output += ($"{array[i]}, ");
    }
    return output;
}