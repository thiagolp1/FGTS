double salario, FGTS;

Console.WriteLine("Salário (R$)..:");
salario = Convert.ToDouble(Console.ReadLine());

FGTS = (salario / 100) * 8;

Console.WriteLine($"\nFGTS: {FGTS:C2}");