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