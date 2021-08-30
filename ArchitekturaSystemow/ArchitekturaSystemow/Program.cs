using System;

namespace ArchitekturaSystemow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj zawartość rejestru AX: ");
            string AX = Console.ReadLine();
            Console.WriteLine("Podaj zawartość rejestru BX: ");
            string BX = Console.ReadLine();
            Console.WriteLine("Podaj zawartość rejestru CX: ");
            string CX = Console.ReadLine();
            Console.WriteLine("Podaj zawartość rejestru DX: ");
            string DX = Console.ReadLine();

            Console.WriteLine("Podaj pierwszy rejestr rozkazu: ");
            string pierwszy = Console.ReadLine();
            Console.WriteLine("Podaj drugi rejestr rozkazu: ");
            string drugi = Console.ReadLine();

            Console.WriteLine("Wybierz czy chcesz uzyć rozkazu MOV czy XCHG");
            Console.WriteLine("(1 - rozkaz MOV, 2 - rozkaz XCHG)");
            int rodzajRozkazu = int.Parse(Console.ReadLine());
            string x;

            if (rodzajRozkazu == 1)
            {
                if (pierwszy == "AX" && drugi == "AX")
                    AX = AX;
                else if (pierwszy == "AX" && drugi == "BX")
                    AX = BX;
                else if (pierwszy == "AX" && drugi == "CX")
                    AX = CX;
                else if (pierwszy == "AX" && drugi == "DX")
                    AX = DX;
                else if (pierwszy == "BX" && drugi == "AX")
                    BX = AX;
                else if (pierwszy == "BX" && drugi == "BX")
                    BX = BX;
                else if (pierwszy == "BX" && drugi == "CX")
                    BX = CX;
                else if (pierwszy == "BX" && drugi == "DX")
                    BX = DX;
                else if (pierwszy == "CX" && drugi == "AX")
                    CX = AX;
                else if (pierwszy == "CX" && drugi == "BX")
                    CX = BX;
                else if (pierwszy == "CX" && drugi == "CX")
                    CX = CX;
                else if (pierwszy == "CX" && drugi == "DX")
                    CX = DX;
                else if (pierwszy == "DX" && drugi == "AX")
                    DX = AX;
                else if (pierwszy == "DX" && drugi == "BX")
                    DX = BX;
                else if (pierwszy == "DX" && drugi == "CX")
                    DX = CX;
                else if (pierwszy == "DX" && drugi == "DX")
                    DX = DX;
                else
                    Console.WriteLine("Błędnie podano rejestry procesora!");

                Console.WriteLine("Aktualny stan rejestrów procesora po wykonaniu rozkazu MOV:");
                Console.WriteLine("AX: " + AX);
                Console.WriteLine("BX: " + BX);
                Console.WriteLine("CX: " + CX);
                Console.WriteLine("DX: " + DX);
            }

            else if (rodzajRozkazu == 2)
            {
                if (pierwszy == "AX" && drugi == "AX")
                    AX = AX;
                else if (pierwszy == "AX" && drugi == "BX")
                {
                    x = AX;
                    AX = BX;
                    BX = x;
                }
                else if (pierwszy == "AX" && drugi == "CX")
                {
                    x = AX;
                    AX = CX;
                    CX = x;
                }
                else if (pierwszy == "AX" && drugi == "DX")
                {
                    x = AX;
                    AX = DX;
                    DX = x;
                }
                else if (pierwszy == "BX" && drugi == "AX")
                {
                    x = BX;
                    BX = AX;
                    AX = x;
                }
                else if (pierwszy == "BX" && drugi == "BX")
                    BX = BX;
                else if (pierwszy == "BX" && drugi == "CX")
                {
                    x = BX;
                    BX = CX;
                    CX = x;
                }
                else if (pierwszy == "BX" && drugi == "DX")
                {
                    x = BX;
                    BX = DX;
                    DX = x;
                }
                else if (pierwszy == "CX" && drugi == "AX")
                {
                    x = CX;
                    CX = AX;
                    AX = x;
                }
                else if (pierwszy == "CX" && drugi == "BX")
                {
                    x = CX;
                    CX = BX;
                    BX = x;
                }
                else if (pierwszy == "CX" && drugi == "CX")
                    CX = CX;
                else if (pierwszy == "CX" && drugi == "DX")
                {
                    x = CX;
                    CX = DX;
                    DX = x;
                }
                else if (pierwszy == "DX" && drugi == "AX")
                {
                    x = DX;
                    DX = AX;
                    AX = x;
                }
                else if (pierwszy == "DX" && drugi == "BX")
                {
                    x = DX;
                    DX = BX;
                    BX = x;
                }
                else if (pierwszy == "DX" && drugi == "CX")
                {
                    x = DX;
                    DX = CX;
                    CX = x;
                }
                else if (pierwszy == "DX" && drugi == "DX")
                    DX = DX;
                else
                    Console.WriteLine("Błędnie podano rejestry procesora!");

                Console.WriteLine("Aktualny stan rejestrów procesora po wykonaniu rozkazu XCHG:");
                Console.WriteLine("AX: " + AX);
                Console.WriteLine("BX: " + BX);
                Console.WriteLine("CX: " + CX);
                Console.WriteLine("DX: " + DX);
            }
            else
                Console.WriteLine("Błędnie podano rodzaj rozkazu");
        }
    }
}

