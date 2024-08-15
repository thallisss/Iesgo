using System;

class Program
{
    static void Main()
    {
        // Solicita ao usuário para inserir um caractere
        Console.Write("Insira um caractere: ");
        char caractere = Console.ReadKey().KeyChar;
        Console.WriteLine();  // Nova linha após a entrada

        // 1. Literal do caractere
        Console.WriteLine($"Literal do caractere: {caractere}");

        // 2. Unicode (usando o código unicode do caractere)
        Console.WriteLine($"Código Unicode: \\u{((int)caractere):X4}");

        // 3. Hexadecimal
        Console.WriteLine($"Hexadecimal: 0x{((int)caractere):X}");

        // 4. Inteiro para char
        Console.WriteLine($"Inteiro para char: {(int)caractere}");
    }
}