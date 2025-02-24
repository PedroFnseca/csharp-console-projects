List<Funcionario> funcionarios = new List<Funcionario>();

Funcionario pedro = new Funcionario("Pedro", 1253, "44648326873");
Funcionario willian = new Funcionario("Willian", 1518, "44648326873");
Funcionario barreto = new Funcionario("Barreto", 1517, "44648326873");
Funcionario andre = new Funcionario("Andre", 2534, "44648326873");

funcionarios.Add(pedro);
funcionarios.Add(willian);
funcionarios.Add(barreto);
funcionarios.Add(andre);

float salarioTotal = 0;
float salarioLiquidoTotal = 0;
foreach  (var funcionario in funcionarios)
{
    salarioLiquidoTotal += funcionario.GetSalarioLiquido();
    salarioTotal += funcionario.GetSalario();
}

Console.WriteLine($"Salario total de todos os Funcionarios: {salarioTotal}");
Console.WriteLine($"Salario liquido de todos os Funcionarios: {salarioLiquidoTotal}");
Console.WriteLine($"Descontos totais {salarioTotal - salarioLiquidoTotal}");