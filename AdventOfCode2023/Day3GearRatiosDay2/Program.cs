// See https://aka.ms/new-console-template for more information
using System;
using System.Net.Http.Headers;
using System.Reflection;
using System.Reflection.PortableExecutable;

StreamReader reader = new StreamReader("C:\\Users\\light\\Documents\\Github\\AdventOfCode\\AdventOfCode2023\\Day3GearRatios\\TextFile1.txt");


using (StreamReader read = new StreamReader("C:\\Users\\light\\Documents\\Github\\AdventOfCode\\AdventOfCode2023\\Day3GearRatios\\TextFile1.txt"))
{

    String[] values = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
    string line;
    int counter = 0;
    String previous = "";
    String current = "";
    String next = "";
    int total = 0;


    while ((line = read.ReadLine()) != null)
    {
        if (counter == 0)
        {
            current = line;
        }

        else if (counter == 1)
        {
            next = line;
        }

        else
        {

            previous = current;
            current = next;
            next = line;

        }
        int index = -1;


        Console.WriteLine("LINE: " + counter);
        //finds symbol and index of said symbol
        if (next != "" && previous != "")
        {
            for (int k = 0; k < current.Length; k++)
            {
                index = -1;


                String currentSubstring = current.Substring(k, 1);


                if (currentSubstring != "1" && currentSubstring != "2" && currentSubstring != "3" &&
                    currentSubstring != "4" && currentSubstring != "5" && currentSubstring != "6" &&
                    currentSubstring != "7" && currentSubstring != "8" && currentSubstring != "9" &&
                    currentSubstring != "." && currentSubstring != "" && counter > 1 && currentSubstring != "0")
                {
                    index = k;
                    Console.WriteLine("\nSymbol: " + currentSubstring);

                    //finds any numbers within the proper index



                    int beginBuffer = Math.Abs(index - 3);
                    int endBuffer = index + 3 - line.Length;
                    int start = index - 3;
                    int end = index + 3;

                    if (beginBuffer < 4)
                    {
                        start = start - beginBuffer;
                    }

                    if (endBuffer < 4 && Math.Sign(endBuffer) != -1)
                    {
                        end = end - endBuffer;
                    }

                    String previousSubstring = previous.Substring(start, end - start);
                    String nextSubstring = next.Substring(start, end - start);
                    currentSubstring = current.Substring(start, end - start);

                    for (int i = 0; i < previousSubstring.Length; i++)
                    {
                        int firstNum = 0;
                        int secondNum = 0;

                        

                            //Cheacks top row
                            for (int j = 0; j < values.Length; j++)
                            {
                                if (previousSubstring.Substring(i, 1) == values[j])
                                {
                                    for (int l = 0; l < values.Length; l++)
                                    {
                                        if (i + 2 < previousSubstring.Length &&
                                            previousSubstring.Substring(i + 1, 1) == values[l])
                                        {
                                            for (int p = 0; p < values.Length; p++)
                                            {
                                                if (i + 3 < previousSubstring.Length &&
                                                    previousSubstring.Substring(i + 2, 1) == values[p])
                                                {
                                                    if (firstNum != 0)
                                                    {
                                                        firstNum = Int32.Parse(previousSubstring.Substring(i, 3));
                                                        j += 3;

                                                    }
                                                    else
                                                    {
                                                        secondNum = Int32.Parse(previousSubstring.Substring(i, 3));
                                                        j += 3;
                                                }

                                                }

                                                else if (i > 1 && i < previousSubstring.Length - 1)
                                                {
                                                    if (firstNum != 0)
                                                    {
                                                        firstNum = Int32.Parse(previousSubstring.Substring(i, 2));
                                                        j += 3;
                                                }
                                                    else
                                                    {
                                                        secondNum = Int32.Parse(previousSubstring.Substring(i, 2));
                                                        j += 3;
                                                }
                                                }
                                            }

                                        }

                                        else if (i > 2 && i < previousSubstring.Length - 2)
                                        {
                                            if (firstNum != 0)
                                            {
                                                firstNum = Int32.Parse(previousSubstring.Substring(i, 1));
                                                j += 3;
                                            }
                                            else
                                            {
                                                secondNum = Int32.Parse(previousSubstring.Substring(i, 1)); 
                                                j += 3;

                                            }
                                        }
                                    }
                                }
                            }

                            //checks bottom row 
                            
                                for (int j = 0; j < values.Length; j++)
                                {
                                    if (nextSubstring.Substring(i, 1) == values[j])
                                    {
                                        for (int l = 0; l < values.Length; l++)
                                        {
                                            if (i + 2 < nextSubstring.Length &&
                                                nextSubstring.Substring(i + 1, 1) == values[l])
                                            {
                                                for (int p = 0; p < values.Length; p++)
                                                {
                                                    if (i + 3 < nextSubstring.Length &&
                                                        nextSubstring.Substring(i + 2, 1) == values[p])
                                                    {
                                                    if (firstNum != 0)
                                                    {
                                                        firstNum = Int32.Parse(nextSubstring.Substring(i, 1));
                                                        j += 3;
                                                    }
                                                    else
                                                    {
                                                        secondNum = Int32.Parse(nextSubstring.Substring(i, 1));
                                                        j += 3;

                                                    }

                                                }

                                                    else if (i > 1 && i < nextSubstring.Length - 1)
                                                    {
                                                    if (firstNum != 0)
                                                    {
                                                        firstNum = Int32.Parse(nextSubstring.Substring(i, 1));
                                                        j += 3;
                                                    }
                                                    else
                                                    {
                                                        secondNum = Int32.Parse(nextSubstring.Substring(i, 1));
                                                        j += 3;

                                                    }
                                                }
                                                }
                                            }

                                            else if (i > 2 && i < nextSubstring.Length - 2)
                                            {
                                            if (firstNum != 0)
                                            {
                                                firstNum = Int32.Parse(nextSubstring.Substring(i, 1));
                                                j += 3;
                                            }
                                            else
                                            {
                                                secondNum = Int32.Parse(nextSubstring.Substring(i, 1));
                                                j += 3;

                                            }
                                        }
                                        }
                                    }
                                }
                            

                            //checks middle row
                           
                            
                                for (int j = 0; j < values.Length; j++)
                                {
                                    if (currentSubstring.Substring(i, 1) == values[j])
                                    {
                                        for (int l = 0; l < values.Length; l++)
                                        {
                                            if (i + 2 < currentSubstring.Length &&
                                                currentSubstring.Substring(i + 1, 1) == values[l])
                                            {
                                                for (int p = 0; p < values.Length; p++)
                                                {
                                                    if (i + 3 < currentSubstring.Length &&
                                                        currentSubstring.Substring(i + 2, 1) == values[p])
                                                    {
                                                if (firstNum != 0)
                                                {
                                                    firstNum = Int32.Parse(currentSubstring.Substring(i, 1));
                                                    j += 3;
                                                }
                                                else
                                                {
                                                    secondNum = Int32.Parse(currentSubstring.Substring(i, 1));
                                                    j += 3;

                                                }

                                            }

                                                    else if (i > 1 && i < currentSubstring.Length - 1)
                                                    {
                                                if (firstNum != 0)
                                                {
                                                    firstNum = Int32.Parse(currentSubstring.Substring(i, 1));
                                                    j += 3;
                                                }
                                                else
                                                {
                                                    secondNum = Int32.Parse(currentSubstring.Substring(i, 1));
                                                    j += 3;

                                                }
                                            }
                                                }
                                            }

                                            else if (i > 2 && i < currentSubstring.Length - 2)
                                            {
                                        if (firstNum != 0)
                                        {
                                            firstNum = Int32.Parse(currentSubstring.Substring(i, 1));
                                            j += 3;
                                        }
                                        else
                                        {
                                            secondNum = Int32.Parse(currentSubstring.Substring(i, 1));
                                            j += 3;

                                        }
                                    }
                                        }
                                    }
                                }
                                Console.WriteLine("First Value: " + firstNum + " Second Value: " + secondNum);


                        if (secondNum * firstNum != 0)
                        {
                            Console.WriteLine("THIS WORLS! First Value: " + firstNum + " Second Value: " + secondNum);
                            total += secondNum * firstNum;
                        }
                    }



                }
            }
        }


        Console.WriteLine();
        counter++;

    }

    Console.WriteLine(total);
}
