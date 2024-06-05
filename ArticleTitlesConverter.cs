using System.Globalization;
using System.Linq;

public class ArticleTitlesConverter
{
    public static string ConvertToArticleTitle(string input, string exceptions)
    {
        var wordsInput = input.Split(' ');
        var wordsException = exceptions.Split(' ');

        string result = "";
        for (int i = 0; i < wordsInput.Length; i++)
        {
            if (i == 0)
            {
                result += char.ToUpper(wordsInput[i][0]) + wordsInput[i].Substring(1) + " ";
            }
            else
            {
                if (wordsException.Contains(wordsInput[i].ToLower()))
                {
                    result += wordsInput[i].ToLower() + " ";
                }
                else
                {
                    result += char.ToUpper(wordsInput[i][0]) + wordsInput[i].Substring(1).ToLower() + " ";
                }
            }
        }

        return result.Trim();
    }

    public static string ConvertToArticleTitle(string input)
    {
        var wordsInput = input.Split(' ');

        string result = "";
        for (int i = 0; i < wordsInput.Length; i++)
        {
            if (i == 0)
            {
                result += char.ToUpper(wordsInput[i][0]) + wordsInput[i].Substring(1) + " ";
            }
            else
            {
                result += char.ToUpper(wordsInput[i][0]) + wordsInput[i].Substring(1).ToLower() + " ";
            }
        }

        return result.Trim();
    }

}
