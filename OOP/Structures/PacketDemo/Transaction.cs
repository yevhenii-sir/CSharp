using System;

namespace LearnCSharpStructures
{
    public class Transaction
    {
        private static uint transacNum = 0;
        private PacketHeader ph;
        private string accountNum;
        private double amount;

        public Transaction(string acc, double val)
        {
            ph.PackNum = transacNum++;
            ph.PackLen = 512;

            accountNum = acc;
            amount = val;
        }

        public void SendTransaction()
        {
            Console.WriteLine("Пакет #: " + ph.PackNum +
                              ", Длинна: " + ph.PackLen + 
                              ",\n\tСчет #: " + accountNum + 
                              ", Сумма: {0:C}",amount);
        }
    }
}
