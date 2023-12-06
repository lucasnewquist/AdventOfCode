// See https://aka.ms/new-console-template for more information

int total = 0;

StreamReader reader = new StreamReader("C:\\Users\\light\\Documents\\Github\\AdventOfCode\\AdventOfCode2023\\AdventOfCode2023\\cordinates.txt");

using (StreamReader read = new StreamReader("C:\\Users\\light\\Documents\\Github\\AdventOfCode\\AdventOfCode2023\\AdventOfCode2023\\cordinates.txt"))
{
    string line;

    while ((line = read.ReadLine()) != null)
    {

        String num = "-1";
        String[] values = {"1", "2", "3", "4", "5", "6", "7", "8", "9", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

        for (int i = 0; i < line.Length; i++)
        {
            for (int j = 0; j < values.Length; j++)
            {
                for (int k = 1; k <= 5; k++)
                {
                    if (i + k <= line.Length && line.Substring(i, k) == (values[j]) && num == "-1")
                    {
                        if (j > 8)
                        {
                            num = values[j - 9];
                            num += num;
                        }

                        else
                        {
                            num = values[j];
                            num += num;
                        }
                    }

                    else if (i + k <= line.Length && line.Substring(i, k) == (values[j]))
                    {
                        if (j > 8)
                        {
                            num = num.Substring(0, 1);
                            num += values[j - 9];
                        }

                        else
                        {
                            num = num.Substring(0, 1);
                            num += values[j];
                        }
                    }
                }
            }
        }

        total += Int32.Parse(num);

        Console.WriteLine(num);


    }

    Console.WriteLine("Total: " + total);
}