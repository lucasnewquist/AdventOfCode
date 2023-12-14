// See https://aka.ms/new-console-template for more information
using System;
using System.Net.Http.Headers;

StreamReader reader = new StreamReader("C:\\Users\\light\\Documents\\Github\\AdventOfCode\\AdventOfCode2023\\Day3GearRatios\\TextFile1.txt");


using (StreamReader read = new StreamReader("C:\\Users\\light\\Documents\\Github\\AdventOfCode\\AdventOfCode2023\\Day3GearRatios\\TextFile1.txt"))
{

    String[] values = { "1", "2", "3", "4", "5", "6", "7", "8", "9" , "0"}; 
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
        int length = -1;

        Console.Write("Line: " + (counter) + "   ");

        for (int i = 0; i < current.Length; i++)
        {
            index = -1;
            length = -1;

            for (int j = 0; j < values.Length; j++)
            {
                if (current.Substring(i, 1) == values[j])
                {
                    //find length

                    index = i;
                    for (int k = 0; k < values.Length; k++)
                    {

                        if (i + 2 <= current.Length && current.Substring(i + 1, 1) == values[k])
                        {
                            for (int l = 0; l < values.Length; l++)
                            {
                                if (i + 3 <= current.Length && current.Substring(i + 2, 1) == values[l])
                                {
                                    length = 3;
                                }

                                else if (length != 3)
                                {
                                    length = 2;
                                }
                            }
                        }

                        else if (length != 2 && length != 3)
                        {
                            length = 1;
                        }
                    }
                    

                }
            }


                    String testPrevious;
                    String testNext;
                    if (index != -1 && length != -1 && counter != 0)
                    {


                        if (index == 0)
                        {
                            testPrevious = previous.Substring(index, length + 1);
                            testNext = next.Substring(index, length + 1);
                        }
                        else if (index + length + 1 > current.Length)
                        {
                            testPrevious = previous.Substring(index - 1, length);
                            testNext = next.Substring(index - 1, length);
                        }

                        else if (previous != "")
                        {
                            testPrevious = previous.Substring(index - 1, length + 2);
                            testNext = next.Substring(index - 1, length + 2);
                        }

                        else
                        {
                            testPrevious = "                                                    ";
                            testNext = next.Substring(index - 1, length + 2);
                        }

                        Boolean checker = false;

                        for (int k = 0; k < testNext.Length; k++)
                        {
                            String previousSubstring = testPrevious.Substring(k, 1);
                            String nextSubstring = testNext.Substring(k, 1);
                            String start = "";
                            String end = "";
                            if (index != 0)
                            {
                                start = current.Substring(index - 1, 1);
                            }

                            if (index + length + 1 < current.Length)
                            {
                                end = current.Substring(index + length, 1);
                            }


                    if (previousSubstring != "1" && previousSubstring != "2" && previousSubstring != "3" &&
                                previousSubstring != "4" && previousSubstring != "5" && previousSubstring != "6" &&
                                previousSubstring != "7" && previousSubstring != "8" && previousSubstring != "9" &&
                                previousSubstring != "." && previousSubstring != "" && counter > 1 && previousSubstring != "0")
                            {
                                checker = true;
                                Console.WriteLine("\nSymbol: " + previousSubstring);
                            }

                            else if (nextSubstring != "1" && nextSubstring != "2" && nextSubstring != "3" &&
                                     nextSubstring != "4" && nextSubstring != "5" && nextSubstring != "6" &&
                                     nextSubstring != "7" && nextSubstring != "8" && nextSubstring != "9" &&
                                     nextSubstring != "." && nextSubstring != "" && nextSubstring != "0")
                            {
                                checker = true;
                                Console.WriteLine("\nSymbol: " + nextSubstring);
                            }
                    else if (start != "1" && start != "2" && start != "3" &&
                             start != "4" && start != "5" && start != "6" &&
                             start != "7" && start != "8" && start != "9" &&
                             start != "." && start != "" && start != "0")
                    {
                        checker = true;
                        Console.WriteLine("\nSymbol: " + start);
                    }

                    else if (end != "1" && end != "2" && end != "3" &&
                             end != "4" && end != "5" && end != "6" &&
                             end != "7" && end != "8" && end != "9" &&
                             end != "." && end != "" && end != "0")
                    {
                        checker = true;
                        Console.WriteLine("\nSymbol: " + end);
                    }

                }

                        if (checker)
                        {
                            total += Int32.Parse(current.Substring(index, length));
                            Console.WriteLine("VALID ANSWER: " + Int32.Parse(current.Substring(index, length)) + " ");
                            i += length;
                        }
                    }


            
        }

        
        Console.WriteLine();
        counter++;

        
    }
    Console.WriteLine(total + 3028);
}
