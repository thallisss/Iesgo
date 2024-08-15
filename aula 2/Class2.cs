using System;

public class Class1
{
	public Class1()
	{
		console.writeLine("Digite o primeiro numero; ");
		double num1 = convert.ToDouble(Console.ReadLine());

        console.writeLine("Digite o primeiro numero; ");
        double num2 = convert.ToDouble(Console.ReadLine());

        console.writeLine("Digite o primeiro numero; ");
        double num3 = convert.ToDouble(Console.ReadLine());

        double media = (num1 + num2 + num3) / 3;
        Console.writeLine("A media e " + media);
    }
}
