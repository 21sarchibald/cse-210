using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");

        Scripture scripture = new Scripture();
        Reference reference = new Reference();

        reference.SetReference("John 3:16");
        scripture.SetScripture("For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        reference.DisplayReference();
        scripture.SplitScripture();
    }
}