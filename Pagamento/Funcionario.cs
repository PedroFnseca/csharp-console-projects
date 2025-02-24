using System;
using System.Data.SqlTypes;

public class Funcionario
{
    public string nome;
	private float salario;
	private float salario_liquido;
	public string cpf;

	public Funcionario(string nome, float salario, string cpf)
	{ 
		this.nome = nome;
		this.salario = salario;
		this.cpf = cpf;

		this.SetSalario(salario);
	}

	public void SetSalario(float salario)
	{
		this.salario = salario;
		this.salario_liquido = salario;

		if (salario > 2000.01)
		{
			this.salario_liquido = (float)(salario - salario * 0.075);
		} else if (salario > 3000.01)
		{
			this.salario_liquido = (float)(salario - salario * 0.15);
		} else if (salario > 4000.01)
		{
			this.salario_liquido = (float)(salario - salario * 0.225);
		} else if (salario > 5000.01)
		{
			this.salario_liquido = (float)(salario - salario * 0.275);
		}
	}

	public float GetSalarioLiquido()
	{
		return this.salario_liquido;
	}

	public float GetSalario()
	{
		return this.salario;
	}
}
