﻿using System;

namespace Imposto {
    class Program {
 

            //Declaracão de variáveis
            double impostoSalario, abatimento;

            //Entrada de Dados

            Console.WriteLine("Renda anual com salário: ");
            double salario = double.Parse(Console.ReadLine());
            Console.WriteLine("Renda anual com prestação de serviço: ");
            double prestacaoServico = double.Parse(Console.ReadLine());
            Console.WriteLine("Renda anual com ganho de capital: ");
            double capital = double.Parse(Console.ReadLine());
            Console.WriteLine("Gastos médicos: ");
            double medicos = double.Parse(Console.ReadLine());
            Console.WriteLine("Gastos educacionais: ");
            double educacionais = double.Parse(Console.ReadLine());

            double rendaMensal = salario / 12;

            //Calculo do Imposto sobre o salário
            if (rendaMensal < 3000.00) {
                impostoSalario = 0;
            }
            else if (rendaMensal < 5000.00) {
                impostoSalario = salario * 0.1;
            }
            else {
                impostoSalario = salario * 0.2;
            }

            //Calculo do Imposto sobre prestação do serviço
            double impostoServico = prestacaoServico * 0.15;

                    //Calculo do Imposto sobre os gastos médicos
                double impostoCapital = capital * 0.2;

            //Valor Total Bruto
            double totalBruto = impostoSalario + impostoServico + impostoCapital;

            //Valor dos gastos Dedutíveis
            double gastosDedutiveis = medicos + educacionais;

            //Valor dos máximos Dedutíveis
            double maximoDedutivel = totalBruto * 0.3;

            //Calculo do abatimento
            if (gastosDedutiveis > maximoDedutivel) {
                abatimento = maximoDedutivel;
            }
            else {
                abatimento = gastosDedutiveis;
            }

            //Valor total Líquido
            double totalLiquido = totalBruto - abatimento;

            Console.WriteLine();
            Console.WriteLine("RELATÓRIO DE IMPOSTO DE RENDA");
            Console.WriteLine();
            Console.WriteLine("CONSOLIDADO DE RENDA:");
            Console.WriteLine("Imposto sobre salário: " + impostoSalario);
            Console.WriteLine("Imposto sobre serviços: " + impostoServico);
            Console.WriteLine("Imposto sobre ganho de capital: " + impostoCapital);
            Console.WriteLine();
            Console.WriteLine("DEDUÇÕES: ");
            Console.WriteLine("Máximo dedutível: " + maximoDedutivel);
            Console.WriteLine("Gastos dedutíveis: " + gastosDedutiveis);
            Console.WriteLine();
            Console.WriteLine("RESUMO: ");
            Console.WriteLine("Imposto bruto total: " + totalBruto);
            Console.WriteLine("Abatimento: " + abatimento);
            Console.WriteLine("Imposto devido: " + totalLiquido);
        }
    }
