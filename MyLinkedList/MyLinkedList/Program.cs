using Microsoft.VisualBasic.FileIO;
using SingleLinkedList;
using System;
using System.ComponentModel;

namespace MyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            int option = 0;
            

            SingleLinkedList.LinkedList<string> Names = new SingleLinkedList.LinkedList<string>();

            //Created a List for reference

            Console.WriteLine("Best Students of BSCOE 2-4");
            Console.WriteLine("--------------------------");

            Node<string> a = new Node<string>("Zabala"); //adding a name
            Names.AddFirst(a);

            Node<string> b = new Node<string>("De Guzman"); //adding a name
            Names.AddFirst(b);

            Node<string> c = new Node<string>("Panuga"); //adding a name
            Names.AddFirst(c);

            Node<string> d = new Node<string>("Gordora"); //adding a name
            Names.AddFirst(d);

            Names.Traverse();


            while (option != 10)
            {
                Console.WriteLine("\n\t\tMenu - select an option number");
                Console.WriteLine("\t\t--------------------------------");
                Console.WriteLine("\t\t1. Add a name After Zabala");
                Console.WriteLine("\t\t2. Add a name After De Guzman");
                Console.WriteLine("\t\t3. Add a name After Panuga");
                Console.WriteLine("\t\t4. Add a name After Gordora");
                Console.WriteLine("\t\t5. Add a name Last");
                Console.WriteLine("\t\t6. Add a name First");
                Console.WriteLine("\t\t7. Search a name");
                Console.WriteLine("\t\t8. Remove a name");
                Console.WriteLine("\t\t9. Exit");
                Console.WriteLine("Option:");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1: //add a name after Zabala
                        bool one = true;
                        while (one)
                        {
                            Console.Write("Enter name(type 'n' to stop): ");
                            var afternode = Console.ReadLine();

                            if (afternode != "n")
                            {
                                Node<string> nodeafter = new Node<string>(afternode);
                                Names.AddAfter(nodeafter, a);
                            }

                            one = afternode == "n" ? false : true;
                        }
                        Names.Traverse();
                        break;

                    case 2: //add a name after De Guzman
                        bool two = true;
                        while (two)
                        {
                            Console.Write("Enter name(type 'n' to stop): ");
                            var afternode = Console.ReadLine();

                            if (afternode != "n")
                            {
                                Node<string> nodeafter = new Node<string>(afternode);
                                Names.AddAfter(nodeafter, b);
                            }

                            two = afternode == "n" ? false : true;
                        }
                        Names.Traverse();
                        break;

                    case 3: //add a name after Panuga
                        bool three = true;
                        while (three)
                        {
                            Console.Write("Enter name(type 'n' to stop): ");
                            var afternode = Console.ReadLine();

                            if (afternode != "n")
                            {
                                Node<string> nodeafter = new Node<string>(afternode);
                                Names.AddAfter(nodeafter, c);
                            }

                            three = afternode == "n" ? false : true;
                        }
                        Names.Traverse();
                        break;

                    case 4: //add a name after Gordora
                        bool four = true;
                        while (four)
                        {
                            Console.Write("Enter name(type 'n' to stop): ");
                            var afternode = Console.ReadLine();

                            if (afternode != "n")
                            {
                                Node<string> nodeafter = new Node<string>(afternode);
                                Names.AddAfter(nodeafter, d);
                            }

                            four = afternode == "n" ? false : true;
                        }
                        Names.Traverse();
                        break;

                    case 5: // Add a name last
                        bool six = true;
                        while (six)
                        {
                            Console.Write("Enter name(type 'n' to stop): ");
                            var lastnode = Console.ReadLine();

                            if (lastnode != "n")
                            {
                                Node<string> nodelast = new Node<string>(lastnode);
                                Names.AddLast(nodelast);
                            }

                            six = lastnode == "n" ? false : true;
                        }
                        Names.Traverse();
                        break;


                    case 6: // Add a name First
                        bool seven = true;
                        while (seven)
                        {
                            Console.Write("Enter name(type 'n' to stop): ");
                            var firstnode = Console.ReadLine();

                            if (firstnode != "n")
                            {
                                Node<string> nodefirst = new Node<string>(firstnode);
                                Names.AddFirst(nodefirst);
                            }

                            seven = firstnode == "n" ? false : true;
                        }
                        Names.Traverse();
                        break;

                    case 7: // Search a name
                        bool eight = true;
                        while (eight)
                        {

                            Console.Write("Enter name(type 'n' to stop): ");
                            var searchnode = Console.ReadLine();

                            if (searchnode != "n")
                            {
                                Node<string> target = Names.Find(searchnode);
                                if (target != null)
                                {
                                    Console.WriteLine("Found: " + target.Data);
                                }
                                else
                                {
                                    Console.WriteLine(searchnode + " Not Found");
                                }
                            }
                            eight = searchnode == "n" ? false : true;
                        }
                        Names.Traverse();
                        break;

                    case 8: // Remove a name
                        bool nine = true;
                        while (nine)
                        {

                            Console.Write("Enter a name to remove(type 'n' to stop): ");
                            var doomnode = Console.ReadLine();

                            if (doomnode != "n")
                            {
                                Node<string> target = Names.Find(doomnode);
                                if (target != null)
                                {
                                    Names.Remove(target);
                                }
                                else
                                {
                                    Console.WriteLine(doomnode + " Not Found");
                                }
                                

                            }

                            nine = doomnode == "n" ? false : true;
                        }
                        Names.Traverse();
                        break;


                    case 9: // Exit program
                        Environment.Exit(0);
                        break;


                    default:
                        Console.WriteLine("Invalid Option!");
                        break;

                }
            }
        }
    }
}


            
    
    


