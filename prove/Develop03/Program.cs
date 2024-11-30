using System;

class Program
{
    static void Main(string[] args)
    {
    
    // BOOK, CHAPTER, AND VERSE REFERENCE
    Reference myReference = new Reference("John", 3, 16);
    Console.WriteLine(myReference.GetDisplayText());
    
    // VERSE OBJECT SCRIPTURE
    Scripture myScripture = new Scripture(myReference.GetDisplayText(), "For God so loved the world that he gave His only Begotten Son that whosoever believeth in Him should not perish but have everlasting life.");
    Console.WriteLine(myScripture.reference);

    myScripture.ScriptureMemorySupport(myReference);

    }
}