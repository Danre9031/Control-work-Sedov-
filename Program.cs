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
    int CountInElements(string elements)
    {
        int lengthElements = elements.Length;
        if (lengthElements <= 3) return 1;
        else return 0;
    }
}