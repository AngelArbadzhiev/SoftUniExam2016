
//Reading the month from the Console.
 string month = Console.ReadLine().ToLower();
 //Reading the Overnight stays from the Console.
 double OvernightStays = double.Parse(Console.ReadLine());
 double PriceStudio = 0;
 double PriceApartament = 0;
 double NewPriceStudio = 0;
 double NewPriceApartament = 0;
 //If the month is May or October we do all the actions in the brackets.
 if (month == "May" || month == "October")
 {
     if (OvernightStays < 7 )
     {
         PriceApartament = (OvernightStays * 65);
         Console.WriteLine("Apartment: {0} lv.", string.Format("{0:0.00}", PriceApartament));
         PriceStudio = (OvernightStays * 50);
         NewPriceStudio = PriceStudio - (PriceStudio * 5 / 100);
         Console.WriteLine("Studio: {0} lv." , string.Format("{0:0.00}", NewPriceStudio));
     }
     else if (OvernightStays > 14.00 )
     {
         PriceApartament = (OvernightStays * 65);
         NewPriceApartament = PriceApartament - (PriceApartament * 10 / 100);
         Console.WriteLine("Apartment: {0} lv.", string.Format("{0:0.00}", NewPriceApartament));
         PriceStudio = (OvernightStays * 50);
         NewPriceStudio = PriceStudio - (PriceStudio * 30 / 100);
         Console.WriteLine("Studio: {0} lv.", string.Format("{0:0.00}", NewPriceStudio));
     }
     
     else
     {
         PriceApartament = (OvernightStays * 65);
         Console.WriteLine("Apartment: {0} lv.", string.Format("{0:0.00}", PriceApartament));
         PriceStudio = (OvernightStays * 50);
         Console.WriteLine("Studio: {0} lv.", string.Format("{0:0.00}", PriceStudio));
     }
 }
 //If the month is June or September we do all the actions in the brackets.
 else if (month == "June" || month == "September")
 {
     if (OvernightStays <= 14)
     {
         PriceApartament = (OvernightStays * 68.70);
         Console.WriteLine("Apartment: {0} lv.", string.Format("{0:0.00}", PriceApartament));
         PriceStudio = (OvernightStays * 75.20);
         Console.WriteLine("Studio: {0} lv.", string.Format("{0:0.00}", PriceStudio));
     }
     if (OvernightStays > 14)
     {
         PriceApartament = (OvernightStays * 68.70);
         NewPriceApartament = PriceApartament - (PriceApartament * 10 / 100);
         Console.WriteLine("Apartment: {0} lv.", string.Format("{0:0.00}", NewPriceApartament));
         PriceStudio = (OvernightStays * 75.20);
         NewPriceStudio = PriceStudio - (PriceStudio * 20 / 100);
                    Console.WriteLine("Studio: {0} lv.", string.Format("{0:0.00}", NewPriceStudio));
                    
     }
 }
 //If the month is July or August we do all the actions in the brackets.
 else if (month == "July" || month == "August")
 {
     if (OvernightStays <= 14)
     {
         PriceApartament = (OvernightStays * 77);
         Console.WriteLine("Apartment: {0} lv.", string.Format("{0:0.00}", PriceApartament));
         PriceStudio = (OvernightStays * 76);
         Console.WriteLine("Studio: {0} lv.", string.Format("{0:0.00}", PriceStudio));
     }
     else if (OvernightStays > 14)
     {
         PriceApartament = (OvernightStays * 77);
         NewPriceApartament = PriceApartament - (PriceApartament * 10 / 100);
         Console.WriteLine("Apartment: {0} lv.", string.Format("{0:0.00}", NewPriceApartament));
         PriceStudio = (OvernightStays * 76);
         Console.WriteLine("Studio: {0} lv.", string.Format("{0:0.00}", PriceStudio));
     }
 }