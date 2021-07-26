using System;

namespace LearnCSharpOther
{ 
    static class EnumFmtDemo
    {
        enum Direction {North, South, East, West}
        
        [Flags]
        enum Status
        {
            Ready = 0x1,
            OffLine = 0x2,
            Waiting = 0x4,
            TransmitOk = 0x8,
            ReceiveOk = 0x10,
            OnLine = 0x20
        }
        static void Main(string[] args)
        {
            Direction d = Direction.West;
            
            Console.WriteLine($"{d:G}");
            Console.WriteLine($"{d:F}");
            
            Console.WriteLine($"{d:D}");
            Console.WriteLine($"{d:X}");

            Status s = Status.Ready | Status.TransmitOk;
            
            Console.WriteLine($"{s:G}");
            Console.WriteLine($"{s:F}");
            Console.WriteLine($"{s:D}");
            Console.WriteLine($"{s:X}");
        }
    }
}

/*

West
West
3
00000003
Ready, TransmitOk
Ready, TransmitOk
9
00000009

*/
