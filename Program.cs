using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string mode = Console.ReadLine();
            float fLength;
            float foV;
            while (true)
            {
                float filmBackWidth = float.Parse(Console.ReadLine());
                if(filmBackWidth > 0)
                {
                   
                    if (mode == "fLength")
                    {
                        while (true)
                        {
                            fLength = float.Parse(Console.ReadLine());
                            if (fLength > 0)
                            {
                                foV = 2 * (float)Math.Atan(filmBackWidth / (2*fLength));
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Invalid fLegnth.\nPlease input again.");
                            }
                        }
                        break;
                    }
                    else if (mode == "foV")
                    {
                        while (true)
                        {
                            foV = float.Parse(Console.ReadLine());
                            if (foV > 0.1 && foV < 6.28)
                            {
                                fLength = filmBackWidth/(2*(float)Math.Tan(foV/2));
                                break;
                                
                            }
                            else
                            {
                                Console.WriteLine("Invalid foV.\nPlease input again.");
                            }
                        }
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid filmBackWidth.\nPlease input again.");
                }
            }
            Console.WriteLine("fLegnth = {0}", fLength);
            Console.WriteLine("foV = {0}", foV);

        }
    }
}
