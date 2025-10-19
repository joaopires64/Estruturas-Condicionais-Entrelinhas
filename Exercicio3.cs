
Console.WriteLine("Você tem o bilhete de viagem");

string resposta = Console.ReadLine();


if (resposta == "sim")
{
    Console.WriteLine("Qual a sua idade?");
    string idadeString = Console.ReadLine();
    int idade = int.Parse(idadeString);
    // qual a condição que eu devo verificar aqui?
    // lembrado que é permitido apenas adultos viajarem sozinhos, e pessoas idosas (maiores de 65 anos) tem que passar por uma verificação médica anets de embarcar
    // dica: existe um arquivo de nome comandos revisoes.md que pode te ajudar a lembrar qual operador
    if (/*AQUI*/)
    {
        Console.WriteLine("Por gentileza, embarque no avião no terminal A2. Uma ótima viagem!");
    }
    else if(/*AQUI*/)
    {
  Console.WriteLine("Por favor,por questões de segurança, dirija-se ao balcão de atendimento médico para uma verificação antes do embarque.");
    }
    else
    {
        Console.WriteLine("Por favor, menores de idade devem estar acompanhados por um adulto para embarcar.");
    }   
}else
{
    Console.WriteLine("Por favor, dirija-se ao balcão de atendimento ou totem para emitir seu bilhete de viagem.");
}




