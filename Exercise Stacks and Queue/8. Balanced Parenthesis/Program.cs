

static bool IsBalanced(string text)
{
   Dictionary<char, char> parenthesesMap = new Dictionary<char, char>
    {
        ['(']= ')',
        ['{']='}',
        ['[']=']'
    };
    Stack<char> parentheses=new Stack<char>();
    foreach (char item in text)
    {
        if (parenthesesMap.ContainsKey(item))
        {
            parentheses.Push(parenthesesMap[item]);
        }
        
        else if(parenthesesMap.ContainsValue(item))
        {
            if (parentheses.Count==0||parentheses.Pop()!=item)
        {
            return false;
        }
           
        }
    }
    return parentheses.Count==0;
}

string text = Console.ReadLine();
if (IsBalanced(text)) { Console.WriteLine("YES"); }
else { Console.WriteLine("NO"); }