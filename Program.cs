using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "João", sobrenome: "Silva");
Pessoa p2 = new Pessoa(nome: "Maria", sobrenome: "Oliveira");

hospedes.Add(p1);
hospedes.Add(p2);

// Cria a suíte
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30); // R$30 por diária

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new Reserva(diasReservados: 20);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibe o resumo completo da reserva
reserva.ExibirResumoDaReserva();