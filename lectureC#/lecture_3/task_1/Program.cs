/* В тексте надо заменить проблемы на черточки "|" , маленькие "к" заменить на "К", Большие "С" заменить на "с".
*/

string GetText()
{
    Console.Write("Введите текст -> ");
string getText =Console.ReadLine();
return getText;

}
string ReplaceChar(string  value, char oldChar, char newChar)
{   string result=String.Empty;
    for(int i=0; i<value.Length;i++)
    {
        if (value[i]==oldChar) result += $"{newChar}";
        else result+=$"{value[i]}";
    }
    return result;
}

string newText =ReplaceChar(GetText(),' ','|');
newText =ReplaceChar(newText,'к','К');
newText =ReplaceChar(newText,'С','с');
Console.WriteLine(newText);
