
using System;

class Representacaodecaracter
{
    static void Main();
    {
   
        Console.WriteLine("Digite um caractere: ");
        char caracter= Console.ReadKey(): KeyChar();
        Console.WriteLine();
    
        string unicodeRepresent= $"\\u{(int)caracter:X4}";

        string hexadecRepresent = $"\\x{(int)caracter:X4}";

        int representacao = (int)caracter;

        Console.WriteLine('$Caractere Literal: '{caracter}'');
        Console.WriteLine('$Representação Unicode: '{unicodeRepresent}'');
        Console.WriteLine('$representação Hexadecimal: '{hexadecRepresent}'');
        Console.WriteLine('$Representação como Inteiro: '{representacao}'');
    }
}
