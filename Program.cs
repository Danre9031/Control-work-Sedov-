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

}