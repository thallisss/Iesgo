using System;

class Program
{
    static void Main()
    {

        Console.Write("nome do funcionário: ");
        string nomeFuncionario = Console.ReadLine();

        Console.Write("horas trabalhadas na semana: ");
        int horasTrabalhadas = int.Parse(Console.ReadLine());


        Console.Write("pagamento por hora: ");
        double taxaPagamentoHora = double.Parse(Console.ReadLine());

        Console.Write("comissões recebidas na semana: ");
        decimal comissoes = decimal.Parse(Console.ReadLine());

        decimal salarioBruto = (decimal)(horasTrabalhadas * taxaPagamentoHora) + comissoes;

        Console.WriteLine($"\nFuncionário: {nomeFuncionario}");
        Console.WriteLine($"Salário Total: {salarioBruto:C}");
    }
}