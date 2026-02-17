namespace praca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            zadanie1();
            zadanie2();
            zadanie3();
            zadanie4();
            zadanie5();
            zadanie6();
            zadanie7();
            zadanie8();
            zadanie9();
            zadanie10();
            zadanie11();
            zadanie12();
            zadanie13();
            zadanie14();
            zadanie15();
            zadanie16();
            zadanie17();
            zadanie18();

            Console.ReadLine();
        }

        static void zadanie1()
        {
            Console.WriteLine("Zadanie 1");

            Console.Write("Wpisz dowolne zdanie: ");
            string input = Console.ReadLine();
            Console.WriteLine("Długość tekstu: " + input.Length);
            string toUpper = input.ToUpper();
            string toLower = input.ToLower();

            Console.Write("Napisz 1 żeby wypisać zdanie wielkimi literami" +
                " i 2 małymi oraz 3 żeby tylko pierwsza liczba wielka: ");
            int result = int.Parse(Console.ReadLine());

            if (result == 1)
            {
                Console.WriteLine(toUpper);
            }
            else if (result == 2)
            {
                Console.WriteLine(toLower);
            }
            else if (result == 3)
            {
                string newString = "";
                newString += input.Substring(0, 1).ToUpper();
                newString += input.Substring(1, input.Length -1);
                Console.WriteLine(newString);
            }

            Console.WriteLine();
        }

        static void zadanie2()
        {
            Console.WriteLine("Zadanie 2");

            Console.Write("Wpisz dowolne zdanie: ");
            string input = Console.ReadLine().Trim();
            Console.WriteLine("Wpisany tekst bez spacji na końcu i początku tekstu: " + input);
            Console.WriteLine("Długość: " + input.Length);
            Console.WriteLine("Pierwsza litera: " + input[0]);
            Console.WriteLine("Ostatnia litera: " + input[input.Length - 1]);

            Console.WriteLine();
        }

        static void zadanie3()
        {
            Console.WriteLine("Zadanie 3");

            Console.Write("Wpisz dowolne zdanie: ");
            string input = Console.ReadLine();
            char firstLetter = input[0];

            int counter = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (firstLetter == input[i])
                {
                    counter++;
                }
            }

            Console.WriteLine("Litera: " + firstLetter + " występuje: " + counter + " razy");

            Console.WriteLine();
        }

        static void zadanie4()
        {
            Console.WriteLine("Zadanie 4");

            Console.Write("Wpisz dowolne zdanie: ");
            string input = Console.ReadLine();
            string result = input.Replace(" ", "_");
            Console.WriteLine("Resultat: " + result);

            Console.Write("Na jaki znak zmienić spacje: ");
            string userChar = Console.ReadLine();

            string userResult = input.Replace(" ", userChar);
            Console.WriteLine("Zmienione spacje na twój znak: " + userResult);

            Console.Write("Na jaki znak zmienić spacje na sztywno: ");
            string userCharInAll = Console.ReadLine();

            Console.WriteLine();
        }
        static void zadanie5()
        {
            Console.WriteLine("Zadanie 5");

            Console.Write("Wpisz dowolne zdanie: ");
            string input = Console.ReadLine();
            string newString = "";

            for (int i = input.Length - 1; i >= 0; i--)
            {
                newString += input[i];
            }

            Console.WriteLine("Odwrucony text: " + newString);

            Console.WriteLine();
        }
        static void zadanie6()
        {
            Console.WriteLine("Zadanie 6");
            Console.Write("Wpisz dowolne zdanie: ");
            string input = Console.ReadLine();

            bool isPalindor = true;
            string[] myArr = input.Split(' ');
            input = "";

            foreach (string word in myArr)
            {
                word.Trim();
                input += word;
            }

            for (int i = 0; i < input.Length; i++)
            {
                if (input.ToLower()[i] != input.ToLower()[input.Length + (-1 - i)])
                {
                    isPalindor = false;
                    break;
                }
            }

            Console.WriteLine("Zdanie: " + input + " czy jest palindorem: " + isPalindor);

            Console.WriteLine();
        }
        static void zadanie7()
        {
            Console.WriteLine("Zadanie 7");

            Console.Write("Wpisz dowolne zdanie: ");
            string input = Console.ReadLine().Trim();
            int counter_words = 0;
            string[] myArrWords = input.Split(' ');

            foreach (string word in myArrWords)
            {
                counter_words++;
            }

            Console.WriteLine("Zdanie składa się z: " + counter_words + " słów!");

            Console.WriteLine();
        }
        static void zadanie8()
        {
            Console.WriteLine("Zadanie 8");

            Console.Write("Wpisz dowolne zdanie: ");
            string input = Console.ReadLine().Trim();
            string akronim = "";
            string[] myAkrArr = input.Split(' ');

            foreach (string word in myAkrArr)
            {
                akronim += word.ToUpper()[0];
            }

            Console.WriteLine("Akronim: " + akronim);

            Console.WriteLine();
        }
        static void zadanie9()
        {
            Console.WriteLine("Zadanie 9");

            Console.Write("Wpisz tu swuj emai: ");
            string input = Console.ReadLine();

            string domena = input.Substring(input.IndexOf('@') + 1);

            Console.Write("Domena: " + domena);

            Console.WriteLine();
        }
        static void zadanie10()
        {
            Console.WriteLine("Zadanie 10");

            Console.Write("Podaj zdanie: ");
            string input = Console.ReadLine().Trim();
            Console.Write("Podaj słowa zakazane. Oddziel je pojedynczą spacją: ");
            string[] cenzure = Console.ReadLine().Split(' ');
            string[] words = input.Split(' ');
            bool dotTheLast = false;

            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < cenzure.Length; j++)
                {
                    if (words[i].IndexOf(".") != -1)
                    {
                        words[i] = words[i].Substring(0, words[i].Length - 1);
                        dotTheLast = true;
                    }

                    if (words[i].ToLower() == cenzure[j].ToLower())
                    {
                        string newWord = "";

                        for (int k = 0; k < words[i].Length; k++)
                        {
                            newWord += '*';
                        }

                        words[i] = newWord;
                    }
                }
            }

            string result = string.Join(' ', words);

            if (dotTheLast)
            {
                result += '.';
            }

            Console.WriteLine("Resultat: " + result);

            Console.WriteLine();
        }
        static void zadanie11()
        {
            Console.WriteLine("Zadanie 11");

            Console.Write("Wpisz dowolne zdanie: ");
            string input = Console.ReadLine();

            input = input.Replace("1", "Jeden");
            input = input.Replace("2", "Dwa");
            input = input.Replace("3", "Trzy");
            input = input.Replace("4", "Cztery");
            input = input.Replace("5", "Pjenc");
            input = input.Replace("6", "Sesc");
            input = input.Replace("7", "Siedem");
            input = input.Replace("8", "Osiem");
            input = input.Replace("9", "Dziewiec");

            Console.WriteLine("Resultat: " + input);

            Console.WriteLine();
        }
        static void zadanie12()
        {
            Console.WriteLine("Zadanie 12");

            Console.Write("Tekst: ");
            string input = Console.ReadLine();

            Console.Write("Szukane: ");
            string searchingWord = Console.ReadLine();
            string[] words = input.Split(' ');

            if (words.Contains(searchingWord))
            {
                Console.WriteLine("Znaleziono na indeksie: " + Array.IndexOf(words, searchingWord));
            }
            else
            {
                Console.WriteLine("");
            }



            Console.WriteLine();
        }
        static void zadanie13()
        {
            Console.WriteLine("Zadanie 13");

            Console.Write("Imie i nazwisko: ");
            string input = Console.ReadLine().Trim();
            string[] names = input.Split(' ');

            string newFirstName = "";
            newFirstName += names[0].Substring(0, 1).ToUpper();
            newFirstName += names[0].Substring(1, names[0].Length - 1).ToLower();

            string newSecondName = "";
            newSecondName += names[1].Substring(0, 1).ToUpper();
            newSecondName += names[1].Substring(1, names[1].Length - 1).ToLower();

            Console.WriteLine("Result: " + newFirstName + " " + newSecondName);

            Console.WriteLine();
        }
        static void zadanie14()
        {
            Console.WriteLine("Zadanie 14");

            Console.Write("Wpisz dowolne zdanie: ");
            string input = Console.ReadLine().Trim();
            string[] words = input.Split(' ');
            string newString = "";


            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < words[i].Length; j++)
                {
                    char letter = words[i][j];

                    if (j % 2 == 0)
                    {
                        newString += char.ToLower(letter);
                    }
                    else
                    {
                        newString += char.ToUpper(letter);
                    }
                }

                newString += ' ';
            }

            Console.WriteLine("Resultat: " + newString);

            Console.WriteLine();
        }
        static void zadanie15()
        {
            Console.WriteLine("Zadanie 15");

            Console.Write("Wpisz dowolne zdanie: ");
            string input = Console.ReadLine().Trim();
            string[] words = input.Split(' ');
            string[] newWords = new string[words.Length];

            for (int i = 0; i < words.Length; i++)
            {
                newWords[i] = words[words.Length - (i + 1)];
            }

            Console.WriteLine("Resultat: " + string.Join(" ", newWords));

            Console.WriteLine();
        }
        static void zadanie16()
        {
            Console.WriteLine("Zadanie 16");

            Console.Write("Wpisz dowolne zdanie: ");
            string input = Console.ReadLine().Trim();
            string[] informations = input.Split(",");

            Console.WriteLine();

            Console.WriteLine("Resultat: ");

            Console.WriteLine();

            if (informations.Length != 3)
            {
                Console.WriteLine("Niepoprawne dane!");
                return;
            }

            Console.WriteLine("Imie: " + informations[0]);
            Console.WriteLine("Nazwisko: " + informations[1]);
            Console.WriteLine("Wiek: " + informations[2]);

            Console.WriteLine();
        }
        static void zadanie17()
        {
            Console.WriteLine("Zadanie 17");

            Console.Write("Wpisz dowolne zdanie: ");
            string input = Console.ReadLine().Trim();
            string[] words = input.Split(' ');
            int counterSamoGloski = 0;
            int counterSpulGloski = 0;

            char[] samoGloski = ['a', 'ą', 'e', 'ę', 'i', 'o', 'ó', 'u', 'y'];
            char[] spulGloski = ['b', 'c', 'ć', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'ł',
                'm', 'n', 'ń', 'p', 'r', 's', 'ś', 't', 'w', 'z', 'ź', 'ż'];

            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < words[i].Length; j++)
                {
                    if (!char.IsLetter(words[i][j]))
                    {
                        continue;
                    }

                    char letter = char.ToLower(words[i][j]);
                    if (samoGloski.Contains(letter))
                    {
                        counterSamoGloski++;
                    }
                    else if (spulGloski.Contains(letter))
                    {
                        counterSpulGloski++;
                    }
                }
            }

            Console.WriteLine();

            Console.WriteLine("Rezultat:");

            Console.WriteLine();

            Console.WriteLine("Liczba samogłosek: " + counterSamoGloski);
            Console.WriteLine("Liczba spółgłosek: " + counterSpulGloski);


            Console.WriteLine();
        }
        static void zadanie18()
        {
            Console.WriteLine("Zadanie 18");

            Console.Write("Wpisz dowolne zdanie: ");
            string input = Console.ReadLine().Trim();

            Console.Write("Podaj klucz: ");
            int key = int.Parse(Console.ReadLine());

            string[] words = input.Split(' ');
            string newString = "";
            char[] alfabet = ['a', 'ą', 'b', 'c', 'ć', 'd', 'e', 'ę', 'f', 'g',
                'h', 'i', 'j', 'k', 'l', 'ł', 'm', 'n', 'ń', 'o', 'ó', 'p', 'r',
                's', 'ś', 't', 'u', 'w', 'y', 'z', 'ź', 'ż'];

            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < words[i].Length; j++)
                {
                    if (words[i][j] == ' ')
                    {
                        newString += ' ';
                        continue;
                    }

                    int index = Array.IndexOf(alfabet, words[i][j]);
                    if (index >= 0)
                    {
                        int indexInAlfabet = index + key;
                        newString += alfabet[indexInAlfabet];
                    }
                }
            }

            Console.WriteLine();

            Console.WriteLine("Resultat:" + newString);

            Console.WriteLine();
        }
    }
}
