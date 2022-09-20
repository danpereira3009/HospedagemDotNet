using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);

List<Pessoa> hospedes = new List<Pessoa>();

bool retornar = true;
int retorno = 1;

while (retornar == true)
{

    Console.WriteLine("Digite a quantidade de hospedes");
    int quantidadeDeHospedes = Convert.ToInt32(Console.ReadLine());
    int contador = 0;

    if(quantidadeDeHospedes <= suite.Capacidade && quantidadeDeHospedes != 0) {

    while (contador < quantidadeDeHospedes) 
    {
        Pessoa hospede = new Pessoa();
        Console.WriteLine("Digite o primeiro nome do Hospede");
        hospede.Nome = Console.ReadLine();
        Console.WriteLine("Digite o sobrenome do hospede");
        hospede.Sobrenome = Console.ReadLine();
        hospedes.Add(hospede);
        contador++;
    }

    Console.WriteLine("Digite a quantidade de dias reservados");
    int diasReservados = Convert.ToInt32(Console.ReadLine());
    Reserva reserva = new Reserva(diasReservados);
    reserva.CadastrarSuite(suite);
    reserva.CadastrarHospedes(hospedes);

    Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
    Console.WriteLine($"Valor total das diárias: {reserva.CalcularValorDiaria()}");

    } else {
        if(quantidadeDeHospedes == 0) {
            Console.WriteLine("A quantidade de hospedes não pode ser igual a 0");
        } else {

                Console.WriteLine($"Capacidade da Suite é de: {suite.Capacidade}");
            }
        }

        Console.WriteLine("Deseja começar novamente? Digite 1 para SIM e 2 para NÃO");
        retorno = Convert.ToInt32(Console.ReadLine());

        if (retorno == 1) {
            retornar = true;
        } else {
            retornar = false;
        }
}