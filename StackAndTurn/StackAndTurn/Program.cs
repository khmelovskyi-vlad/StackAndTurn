using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndTurn
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = ReadTurn();
            WriteMatrixFromTheEnd(array);
            Console.ReadKey();
        }
        static void WriteMatrixFromTheEnd (int[] array)
        {
            for(int i = array.Length - 1; i >= 0; i--)
            {
                Console.Write(array[i]);
            }
        }
        static int[] ReadStack()
        {
            Console.WriteLine("Stack array");
            var numArray = 1;
            int i = 0;
            int[] array = new int[numArray];
            while (true)
            {
                try
                {
                    Console.WriteLine("If you want to add some numbers to the array, click Enter, if you want to delete some from the numbers, click Backspace, if you want write you array, click Tab ");
                    var key = Console.ReadKey(true);
                    if (key.Key == ConsoleKey.Enter)
                    {
                        while (true)
                        {
                            {
                                array[i] = ReadInt("number");
                                Console.WriteLine("If you want to add new number - click any key, else - click Backspace");
                                key = Console.ReadKey(true);
                                if (key.Key == ConsoleKey.Escape)
                                {
                                    throw new OperationCanceledException();
                                }
                                else if (key.Key == ConsoleKey.Backspace)
                                {
                                    break;
                                }
                                else
                                {
                                    numArray++;
                                    i++;
                                    Array.Copy(array, 0, array = new int[numArray], 0, numArray - 1);
                                    continue;
                                }
                            }
                        }
                    }
                    else if (key.Key == ConsoleKey.Backspace)
                    {
                        while (true)
                        {
                            i--;
                            numArray--;
                            Array.Copy(array, 0, array = new int[numArray], 0, numArray);
                            Console.WriteLine($"Еhe array has decreased by 1 and there are {numArray} elements in it ");
                            Console.WriteLine("If you want to delete new number - click any key, else - click Enter");
                            key = Console.ReadKey(true);
                            if (key.Key == ConsoleKey.Escape)
                            {
                                throw new OperationCanceledException();
                            }
                            else if (key.Key == ConsoleKey.Enter)
                            {
                                break;
                            }
                        }
                    }
                    else if (key.Key == ConsoleKey.Tab)
                    {
                        return array;
                    }
                }
                catch(OperationCanceledException)
                {
                    throw new OperationCanceledException();
                }
                catch (OverflowException)
                {
                    numArray = 1;
                    i = 0;
                    Array.Copy(array, 0, array = new int[numArray], 0, numArray - 1);
                    Console.WriteLine("Array is empty, try again");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Bed input {ex.Message}, try again or click Escape");
                }
            }
        }
        static int[] ReadTurn()
        {
            Console.WriteLine("Turn array");
            var numArray = 1;
            int i = 0;
            int[] array = new int[numArray];
            while (true)
            {
                try
                {
                    Console.WriteLine("If you want to add some numbers to the array, click Enter, if you want to delete some from the numbers, click Backspace, if you want write you array, click Tab ");
                    var key = Console.ReadKey(true);
                    if (key.Key == ConsoleKey.Enter)
                    {
                        while (true)
                        {
                            {
                                array[i] = ReadInt("number");
                                Console.WriteLine("If you want to add new number - click any key, else - click Backspace");
                                key = Console.ReadKey(true);
                                if (key.Key == ConsoleKey.Escape)
                                {
                                    throw new OperationCanceledException();
                                }
                                else if (key.Key == ConsoleKey.Backspace)
                                {
                                    break;
                                }
                                else
                                {
                                    numArray++;
                                    i++;
                                    Array.Copy(array, 0, array = new int[numArray], 0, numArray - 1);
                                    continue;
                                }
                            }
                        }
                    }
                    else if (key.Key == ConsoleKey.Backspace)
                    {
                        while (true)
                        {
                            i--;
                            numArray--;
                            Array.Copy(array, 1, array = new int[numArray], 0, numArray);
                            Console.WriteLine($"Еhe array has decreased by 1 and there are {numArray} elements in it ");
                            Console.WriteLine("If you want to delete new number - click any key, else - click Enter");
                            key = Console.ReadKey(true);
                            if (key.Key == ConsoleKey.Escape)
                            {
                                throw new OperationCanceledException();
                            }
                            else if (key.Key == ConsoleKey.Enter)
                            {
                                break;
                            }
                        }
                    }
                    else if (key.Key == ConsoleKey.Tab)
                    {
                        return array;
                    }
                }
                catch (OperationCanceledException)
                {
                    throw new OperationCanceledException();
                }
                catch (OverflowException)
                {
                    numArray = 1;
                    i = 0;
                    Array.Copy(array, 0, array = new int[numArray], 0, numArray - 1);
                    Console.WriteLine("Array is empty, try again");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Bed input {ex.Message}, try again or click Escape");
                }
            }
        }
        static int ReadInt(string readInt)
        {
            do
            {
                try
                {
                    Console.WriteLine($"Enter {readInt}");
                    var key = Console.ReadKey();
                    if(key.Key == ConsoleKey.Escape)
                    {
                        throw new OperationCanceledException();
                    }
                    var line = Console.ReadLine();
                    var keyLine = $"{key.KeyChar}{line}";
                    return Int32.Parse(keyLine);
                }
                catch(FormatException ex)
                {
                    Console.WriteLine($"Bed input {ex.Message}, try again or click Escape");
                }
            } while (true);
        }
    }
}
