//Faça um programa que leia o nome de um vendedor, o seu salário fixo e o
//total de vendas efetuadas por ele no mês (em dinheiro).
//Sabendo que este vendedor ganha 15% de comissão sobre suas vendas efetuadas,
//informar o total a receber no final do mês, com duas casas decimais.

String nome;
double salario, valorvendas, total;

Console.WriteLine("DIGITE O NOME, SALARIO, E VALOR DAS VENDAS NO MÊS.");

nome = (Console.ReadLine());
salario = double.Parse(Console.ReadLine());
valorvendas = double.Parse(Console.ReadLine());
total = salario + valorvendas*0.15;

Console.WriteLine("TOTAL: R$" + total.ToString("F2"));