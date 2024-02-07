using System;
using System.Collections.Generic;

namespace Homework_2
{
    class Program
    {
        //findng middle elements
        public static List<int> Middle(List<int> nums)
        {
            List<int> middleElems = new List<int>();
            int length = nums.Count;
            if (length % 2 != 0)
            {
                middleElems.Add(nums[length / 2]);
            }
            else
            {
                middleElems.Add(nums[length / 2 - 1]);
                middleElems.Add(nums[length / 2]);
            }
            return middleElems;
        }

        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 4, 5 };
            List<int> middleElems = Middle(numbers);
            Console.WriteLine("Middle Element(s):");
            foreach (var element in middleElems)
            {
                Console.WriteLine(element);
            }
        }
    }
}

/*Ունենք 12 ոսկե ձուլակտոր որոնցից մեկը կեղծ է. 3 կշռումով ինչպես պարզենք թե որն է կեղծը
         
         [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12]
        1. Բաժանել 3 մասի և կշռել
            1[1,2,3,4], 2[5,6,7,8],  3[9,10,11,12]
            1st operation 1 * 2
            if( 1 == 2) Արել էինք լսարանում
            else if( 1 > 2) 
        {
              => Կամ 1,2,3,4ից մեկը ծանր է, կամ 5,6,7,8ից մեկը թեթև
             Բաժանենք 1-8ը 3 մասի։ 1[1,2,5] 2[3,4,6], 3[7,8]
             2nd operation  1 * 2
             if( 1 == 2) 3րդ քայլով կշռել 7, 8ը ընտել թեթևը
             else if(1>2) 3րդ քայլով կշռել 1, 2ը ընտրել ծանրը, եթե =են ընտրել 6։
             else if(1<2)3րդ քայլով կշռել 3, 4ը ընտրել ծանրը, եթե =են ընտրել 5։
         }
         else if( 1 < 2) անել նույն բանը ինչ արել ենք (1>2) դեպքի համար։
         
         Հ․Գ․ Խնդիրը լուծել եմ Գոռի հետ։) 
         
         */