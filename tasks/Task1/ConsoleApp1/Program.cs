namespace Task1
{
    class program
    {
        static void Main()
        {                       /*PROBLEM1*/
            // Part 1 
            byte seatNumber = 150;     
            byte roomNumber = 10;       
            byte viewerAge = 120;       
            
            // Part 2 
            uint ticketSerial = 3_000_000_000U;         
            ulong totalTicketsPrinted = 3_500_000_000UL; 
            sbyte zoneCode = -100;                       

            // Part 3
            decimal ticketPrice = 12.50m;
            float popcornComboDiscount = 18.5f;
            double screenBrightnessRatio = 0.85;

            // Part 4
            string customerName = "Ahmed Tawfik";
            char membershipTierCode = 'A';
            bool isVipMember = true;
                                      
                                            /*PROBLEM2*/
           
            byte studentAge = 20; //wrong syntax student-age
            
            int distance = -500;  //unit cant store negative values 
            
            int firstPlayerScore = 1000; // wrong syntax 1stplayer 
            
            long itemsCount = 50;
            
            ushort temperature = 40000; // ushort range is 0 to 65,535


                                     /*problem 3*/
            int currentStock = 500;
            
            int backupStock = currentStock;
            
            currentStock += 100;

            Console.WriteLine($"currentStock: {currentStock}"); // Prints: 600
            Console.WriteLine($"backupStock: {backupStock}");   // Prints: 500
        }
    }
}