Random random = new Random();
        string[] opções = { "Pedra", "Papel", "Tesoura" };

        while (true)
        {
            Console.Write("Escolha (Pedra, Papel ou Tesoura ): ");
            string escolhaJogador = Console.ReadLine();

            

            if (Array.IndexOf(opções, escolhaJogador) == -1)
            {
                Console.WriteLine("Escolha inválida. Tente novamente.");
                continue;
            }

            string escolhaComputador = opções[random.Next(opções.Length)];
            Console.WriteLine($"Computador escolheu: {escolhaComputador}");

            if (escolhaJogador == escolhaComputador)
                Console.WriteLine("Empate!");
            else if ((escolhaJogador == "Pedra" && escolhaComputador == "Tesoura") ||
                     (escolhaJogador == "Papel" && escolhaComputador == "Pedra") ||
                     (escolhaJogador == "Tesoura" && escolhaComputador == "Papel"))
                Console.WriteLine("Você ganhou!");
            else
                Console.WriteLine("Você perdeu!");

            Console.WriteLine();
        }