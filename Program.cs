double altura, peso, imc;
string resultado;

Console.WriteLine("-- Calculadora IMC --");

Console.Write("Digite seu peso em kg...: ");
peso = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite sua altura em m..: ");
altura = Convert.ToDouble(Console.ReadLine());

imc = peso / Math.Pow(altura, 2);

Console.WriteLine($"\nSeu IMC é {imc:N2} kg/m².");

if (imc < 17)
{
    resultado = "Muito abaixo do peso";
}
else if (imc < 18.5)
{
    resultado = "Abaixo do peso";
}
else if (imc < 25)
{
    resultado = "Peso normal";
}
else if (imc < 30)
{
    resultado = "Acima do peso";
}
else if (imc < 35)
{
    resultado = "Obesidade I";
}
else if (imc < 40)
{
    resultado = "Obesidade II (severa)";
}
else
{
    resultado = "Obesidade III (mórbida)";
}
Console.WriteLine ($"Diagnóstico: {resultado}");