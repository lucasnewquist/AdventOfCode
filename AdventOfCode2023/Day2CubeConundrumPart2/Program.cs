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

        int power = 0;

        int redMax = 0;
        int blueMax = 0;
        int greenMax = 0;

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

                if (num > redMax)
                {
                    redMax = num;
                }
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

                if (num > blueMax)
                {
                    blueMax = num;
                }
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

                if (num > greenMax)
                {
                    greenMax = num;
                }
            }

        }

        power = (greenMax * redMax * blueMax);

        answer += power;

        Console.WriteLine(power);

    }

    Console.WriteLine(answer);
}


