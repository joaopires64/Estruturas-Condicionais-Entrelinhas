
Console.WriteLine("Você tem o bilhete de viagem");

string resposta = Console.ReadLine();


if (resposta == "sim")
{
    Console.WriteLine("Você é cidadão americano?");
    string cidadaoAmericano = Console.ReadLine();
    if (cidadaoAmericano == "sim")
    {
        Console.WriteLine("Por gentileza, embarque no avião no terminal A2. Uma ótima viagem!");
    }
    else
    {
        Console.WriteLine("Você possui passaporte brasileiro?");
        string passaporte = Console.ReadLine();
        if (passaporte == "sim")
        {
            Console.WriteLine("Você possui visto americano válido?");
            string visto = Console.ReadLine();
            if (visto == "sim")
            {
                //Quantas malas você tem?
                string malasString = Console.ReadLine();
                int malas = int.Parse(malasString);
                // qual a condição que eu devo verificar aqui?
                // lembarndo que despachar uma mala por pessoa é gratuito, e cada mala adicional custa 50 dolares
                // é proibido despachar mais de 3 malas por pessoa
                if (/*AQUI*/)
                {
                    Console.WriteLine("Quantidade de malas Aprovada sem custos extras");
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
                }
                // qual estrutura devemos colocar aqui?
                {
                    if (malas <= 3)
                    {
                        int custoExtra = /*quanto vai custar a mais?*/;
                        Console.WriteLine($"Você terá um custo extra de $ {custoExtra} por despachar {malas - 1} malas adicionais.");
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
                    }
                    else
                    {
                        Console.WriteLine("Por favor, dirija-se aos escaninhos para descartar uma das malas");
                        Console.WriteLine($"Você terá um custo extra de $ 100 por despachar 2 malas adicionais.");
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
                    }

                }
                    else
                {
                    Console.WriteLine("Desculpe, não é permitido despachar mais de 3 malas por pessoa.");
                }
            }
            else
            {
                Console.WriteLine("naõ é possivel embarcar sem os documentos necessários. Por favor, dirija-se ao balcão de atendimento para mais informações.");
            }

        }
        else
        {
            Console.WriteLine("naõ é possivel embarcar sem os documentos necessários. Por favor, dirija-se ao balcão de atendimento para mais informações.");
        }
    }
}






