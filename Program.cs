using System;

class Program
{
    static void Main(string[] args)
    {
        DNA();

    }
    static void DNA()
    {
         bool continueProgram = true;

        while (continueProgram)
        {
            Console.Write("Please input a DNA sequence (half): ");
            string dnaSeq = Console.ReadLine();

            if (IsValidSequence(dnaSeq))
            {
                Console.WriteLine("Current half DNA sequence : " + dnaSeq);

                Console.Write("Do you want to replicate it ? (Y/N) : ");
                string answer = Console.ReadLine();

                if (answer == "Y")
                {
                    string replicatedSeq = ReplicateSequence(dnaSeq);
                    Console.WriteLine("Replicated half DNA sequence : " + replicatedSeq);
                }
                else if (answer == "N")
                {
                    // do nothing
                }
                else
                {
                    Console.WriteLine("Please input Y or N.");
                    answer = Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("That half DNA sequence is invalid.");
            }

            Console.Write("Do you want to process another sequence ? (Y/N) : ");
            string continueAnswer = Console.ReadLine();

            while (continueAnswer != "Y" && continueAnswer != "N")
            {
                Console.WriteLine("Please input Y or N.");
                continueAnswer = Console.ReadLine();
            }

            if (continueAnswer == "Y")
            {
                continueProgram = true;
            }
            else
            {
                continueProgram = false;
            }
        }
    }

    static bool IsValidSequence(string sequence)
    {
        foreach (char c in sequence)
        {
            if (c != 'A' && c != 'T' && c != 'C' && c != 'G')
            {
                return false;
            }
        }
        return true;
    }

    static string ReplicateSequence(string sequence)
    {
        string replicatedSeq = "";

        foreach (char c in sequence)
        {
            if (c == 'A')
            {
                replicatedSeq += "T";
            }
            else if (c == 'T')
            {
                replicatedSeq += "A";
            }
            else if (c == 'C')
            {
                replicatedSeq += "G";
            }
            else if (c == 'G')
            {
                replicatedSeq += "C";
            }
        }

        return replicatedSeq;
    }
}     


    




