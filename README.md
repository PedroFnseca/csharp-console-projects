## 📑 Sumário

* [🔗 Relacionamento entre Objetos e Encapsulamento](#-relacionamento-entre-objetos-e-encapsulamento)
* [🧬 Herança](#-herança)
* [🛠️ Construtores](#%EF%B8%8F-construtores)
  * [👪 Construtores com Herança](#-construtores-com-herança-uso-do-base)
* [📝 Sobrescrita (Override)](#-sobrescrita-override)
* [🧱 Classes Abstratas](#-classes-abstratas)
* [➕ Sobrecarga (Overload)](#-sobrecarga-overload)
* [🧩 Interfaces](#-interfaces)
* [📚 Manipulação de Arrays](#-manipulação-de-arrays)
* [🔐 Variáveis Públicas e Privadas](#-variáveis-públicas-e-privadas)
* [📌 Tipos de Variáveis Comuns em C#](#-tipos-de-variáveis-comuns-em-c)

---

## 🔗 Relacionamento entre Objetos e Encapsulamento

### Para que serve:
- **Relacionamento entre objetos** permite que classes colaborem entre si.
- **Encapsulamento** protege os dados internos do objeto, permitindo acesso controlado através de métodos.

### Exemplo:
```csharp
public class Motor {
    public void Ligar() {
        Console.WriteLine("Motor ligado.");
    }
}

public class Carro {
    private Motor motor = new Motor(); // Relacionamento (composição)

    public void LigarCarro() {
        motor.Ligar();
    }
}
````

---

## 🧬 Herança

### Para que serve:

* Permite que uma classe herde atributos e métodos de outra, promovendo reuso de código.

### Exemplo:

```csharp
public class Animal {
    public void Comer() {
        Console.WriteLine("Comendo...");
    }
}

public class Cachorro : Animal {
    public void Latir() {
        Console.WriteLine("Au au!");
    }
}
```

---

## 🛠️ Construtores

### Para que serve:
- Inicializa os objetos no momento de sua criação.
- Pode ser usado com herança para inicializar tanto a classe base quanto a derivada.

### Exemplo básico:
```csharp
public class Pessoa {
    public string Nome { get; set; }

    public Pessoa(string nome) {
        Nome = nome;
    }
}
````

### 👪 Construtores com Herança (uso do `base`)

### Para que serve:

* Permite que uma classe derivada chame o construtor da classe base, garantindo que todos os atributos necessários sejam inicializados corretamente.

### Exemplo:

```csharp
public class Pessoa {
    public string Nome { get; set; }

    public Pessoa(string nome) {
        Nome = nome;
    }
}

public class Aluno : Pessoa {
    public string Curso { get; set; }

    public Aluno(string nome, string curso) : base(nome) {
        Curso = curso;
    }
}
```

### Explicação:

* A classe `Aluno` herda de `Pessoa`.
* O construtor de `Aluno` recebe dois parâmetros: `nome` e `curso`.
* O `base(nome)` chama o construtor da classe `Pessoa` para inicializar a propriedade `Nome`.

---

## 📝 Sobrescrita (Override)

### Para que serve:

* Permite redefinir o comportamento de um método herdado.

### Exemplo:

```csharp
public class Animal {
    public virtual void Falar() {
        Console.WriteLine("Som genérico");
    }
}

public class Gato : Animal {
    public override void Falar() {
        Console.WriteLine("Miau");
    }
}
```

---

## 🧱 Classes Abstratas

### Para que serve:

* Definem um contrato base que não pode ser instanciado diretamente, mas serve como modelo para outras classes.

### Exemplo:

```csharp
public abstract class Forma {
    public abstract double CalcularArea();
}

public class Circulo : Forma {
    public double Raio { get; set; }

    public override double CalcularArea() {
        return Math.PI * Raio * Raio;
    }
}
```

---

## ➕ Sobrecarga (Overload)

### Para que serve:

* Permite criar múltiplos métodos com o mesmo nome, mas diferentes parâmetros.

### Exemplo:

```csharp
public class Calculadora {
    public int Somar(int a, int b) {
        return a + b;
    }

    public double Somar(double a, double b) {
        return a + b;
    }
}
```

---

## 🧩 Interfaces

### Para que serve:

* Define um contrato que outras classes devem implementar, sem fornecer implementação.

### Exemplo:

```csharp
public interface IAnimal {
    void EmitirSom();
}

public class Vaca : IAnimal {
    public void EmitirSom() {
        Console.WriteLine("Muuu");
    }
}
```

---

## 📚 Manipulação de Arrays

### Para que serve:

* Armazenar coleções de dados do mesmo tipo, facilitando operações em lote.

### Exemplo:

```csharp
string[] nomes = { "Ana", "Bruno", "Carlos" };

foreach (string nome in nomes) {
    Console.WriteLine("Olá, " + nome);
}

// Acessar elemento específico
Console.WriteLine(nomes[1]); // Bruno
```

---

## 🔐 Variáveis Públicas e Privadas

### Para que serve:

* Controlar a visibilidade e acesso aos dados da classe.

### Exemplo:

```csharp
public class ContaBancaria {
    public string Titular;        // Acessível fora da classe
    private double saldo;         // Acessível apenas dentro da classe

    public void Depositar(double valor) {
        saldo += valor;
    }

    public double ConsultarSaldo() {
        return saldo;
    }
}
```

---

## 📌 Tipos de Variáveis Comuns em C\#

| Tipo     | Descrição                     | Exemplo                 |
| -------- | ----------------------------- | ----------------------- |
| `int`    | Número inteiro                | `int idade = 30;`       |
| `double` | Número com casas decimais     | `double altura = 1.75;` |
| `bool`   | Verdadeiro ou falso           | `bool ativo = true;`    |
| `char`   | Caractere único               | `char letra = 'A';`     |
| `string` | Cadeia de caracteres          | `string nome = "Ana";`  |
| `var`    | Tipo inferido automaticamente | `var x = 42;`           |
