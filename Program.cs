using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(ArticleTitlesConverter.ConvertToArticleTitle("В шаге ОТ победы", "в от"));

        Console.WriteLine(ArticleTitlesConverter.ConvertToArticleTitle("the clash of CLANS", "a an the of"));

        Console.WriteLine(ArticleTitlesConverter.ConvertToArticleTitle("первый аргумент"));
    }
}