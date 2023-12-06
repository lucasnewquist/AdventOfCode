// See https://aka.ms/new-console-template for more information

StreamReader reader = new StreamReader("C:\\Users\\light\\Documents\\Github\\AdventOfCode\\AdventOfCode2023\\Day2CubeConundrum\\bag.txt");


using (StreamReader read = new StreamReader("C:\\Users\\light\\Documents\\Github\\AdventOfCode\\AdventOfCode2023\\Day2CubeConundrum\\bag.txt"))
{
    string line;

    int answer = 0;
    int counter = 0;

    while ((line = read.ReadLine()) != null)
    {
        counter++;

        Boolean bag = true;

        //Red Checker
        for (int i = 0; i <= line.Length - 3; i++)
        {
            if (line.Substring(i, 3) == "red")
            {
                int num;
                if (line.Substring(i - 3, 1) == " ")
                {
                    num = Int32.Parse(line.Substring(i - 2, 1));
                }
                else
                {
                    num = Int32.Parse(line.Substring(i - 3, 2));
                }

                if (num > 12)
                {
                    bag = false;
                }
            }

            if (!bag)
            {
                break;
            }
        }

        //Blue Checker
        for (int i = 0; i <= line.Length - 4; i++)
        {
            if (line.Substring(i, 4) == "blue")
            {
                int num;
                if (line.Substring(i - 3, 1) == " ")
                {
                    num = Int32.Parse(line.Substring(i - 2, 1));
                }
                else
                {
                    num = Int32.Parse(line.Substring(i - 3, 2));
                }

                if (num > 14)
                {
                    bag = false;
                }
            }

            if (!bag)
            {
                break;
            }
        }

        //Green Checker
        for (int i = 0; i <= line.Length - 5; i++)
        {
            if (i == 74 && counter == 45)
            {
                Thread.Sleep(100);
            }

            if (line.Substring(i, 5) == "green")
            {
                int num;
                if (line.Substring(i - 3, 1) == " ")
                {
                    num = Int32.Parse(line.Substring(i - 2, 1));
                }
                else
                {
                    num = Int32.Parse(line.Substring(i - 3, 2));
                }

                if (num > 13)
                {
                    bag = false;
                }
            }

            if (!bag)
            {
                break;
            }
        }

        if (bag)
        {
            if (line.Substring(6, 1) == ":")
            {
                answer += Int32.Parse(line.Substring(5, 1));
                Console.WriteLine(Int32.Parse(line.Substring(5, 1)));
            }
            else if (line.Substring(7, 1) == ":")
            {
                answer += Int32.Parse(line.Substring(5, 2));
                Console.WriteLine(Int32.Parse(line.Substring(5, 2)));
            }

            else
            {
                answer += Int32.Parse(line.Substring(5, 3));
                Console.WriteLine(Int32.Parse(line.Substring(5, 3)));
            }
        }

        
    }
    
    Console.WriteLine(answer);
}

