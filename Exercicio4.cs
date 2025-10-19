
Console.WriteLine("Você tem o bilhete de viagem");

string resposta = Console.ReadLine();


if (resposta == "sim")
{
    // antes de perguntar a idade, devemos verificar se a pessoa possui alguns documentos, 
    // Existem dois documentos que podem ser aceitos: Identidade Americana ou Passaporte Brasileiro com visto Americano
    // lembarndo : Cidadão americanos não precisam de visto para entrar nos Estados Unidos

    Console.WriteLine("Você é cidadão americano?");
    string cidadaoAmericano = Console.ReadLine();
    if (/*AQUI*/)
    {
        Console.WriteLine("Por gentileza, embarque no avião no terminal A2. Uma ótima viagem!");
    }
    else
    {
        Console.WriteLine("Você possui passaporte brasileiro?");
        string passaporte = Console.ReadLine();
        if (*/*AQUI*/)
        {
            Console.WriteLine("Você possui visto americano válido?");
            string visto = Console.ReadLine();
            // escreva a condição que verifica se a pessoa possui visto americano válido
            {
                Console.WriteLine("Qual a sua idade?");
                string idadeString = Console.ReadLine();
                int idade = int.Parse(idadeString);
                if (idade >= 18 && idade <= 65)
                {
                    Console.WriteLine("Por gentileza, embarque no avião no terminal A2. Uma ótima viagem!");
                }
                else if (idade > 65)
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
        }
        // o que deve acontecer se a pessoa não possuir visto americano válido?
        {
            Console.WriteLine("naõ é possivel embarcar sem os documentos necessários. Por favor, dirija-se ao balcão de atendimento para mais informações.");

        }
    }
        else
    {
        Console.WriteLine("naõ é possivel embarcar sem os documentos necessários. Por favor, dirija-se ao balcão de atendimento para mais informações.");

    }
}






