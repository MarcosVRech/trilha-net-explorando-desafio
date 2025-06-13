# Sistema de Hospedagem em C#

Este é um projeto que desenvolvi como parte de um **desafio de código da DIO (Digital Innovation One) em parceria com a WEX**. O objetivo era criar um sistema básico de hospedagem para hotéis, utilizando conceitos de **POO (Programação Orientada a Objetos)** com C#.

## 💡 O que o sistema faz

O sistema permite:
- Cadastrar hóspedes
- Cadastrar uma suíte com valor e capacidade
- Criar uma reserva informando o número de dias
- Calcular automaticamente o valor total da estadia

Também implementei um **sistema de desconto progressivo**:  
- Reservas de **10 dias ou mais** recebem **desconto começando em 10%**  
- Esse desconto cresce 1% por dia extra, até **30% no máximo**

Além disso, o programa mostra um **resumo da reserva formatado no console**, com:
- Lista de hóspedes
- Tipo da suíte
- Valor original da reserva
- Desconto aplicado
- Valor final com desconto

## 🧪 Tecnologias utilizadas

- C#
- .NET 9

## ✨ Funcionalidades Extras Implementadas

Além dos requisitos propostos no desafio da DIO, foram adicionadas melhorias e recursos que demonstram atenção a detalhes e aprofundamento técnico:

- 🔻 **Desconto Progressivo em Diárias**  
  Sistema de desconto de **10% para estadias acima de 10 dias**, simulando políticas reais de hotéis e reforçando o uso de lógica condicional no cálculo final da reserva.

- 👤 **Identificação dos Hóspedes com Nome**  
  Os hóspedes são representados com **nomes personalizados**, e não apenas como números ou contadores. Isso humaniza a aplicação e torna a exibição dos dados mais compreensível.

- 🎨 **Uso de Cores no Console**  
  A interface no console foi aprimorada com **cores** para diferenciar títulos, avisos e informações importantes, melhorando a experiência de leitura e interação no terminal.

- 🔄 **Fluxo Interativo**  
  O sistema simula um **fluxo completo de cadastro, reserva e exibição de informações**, demonstrando o comportamento real da aplicação desde a entrada dos dados até a finalização da reserva.

> Esses elementos evidenciam preocupação com **usabilidade**, **estética** e **comportamento realista do sistema**, agregando valor ao projeto e demonstrando habilidades além do básico.
---

Este projeto me ajudou a reforçar conceitos de classes, métodos, encapsulamento e boas práticas com C#.  
Fico à disposição para sugestões ou melhorias!
