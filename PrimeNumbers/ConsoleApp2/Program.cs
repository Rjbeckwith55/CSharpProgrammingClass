﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int SIZE = 1000; // 0 to 999
            bool[] primes = new bool[SIZE];
            for (int i = 2; i < SIZE; i++)
            {
                primes[i] = true; // set all the elements to true
            }
            for (int i = 2; i < SIZE; i++)
            {
                for (int j = 2; j < SIZE; j++)
                {
                    if (i % j == 0 && i != j)
                    {
                        primes[i] = false; // set all the elements to true
                    }
                   
                }

            }
            Console.WriteLine("All the prime numbers from 2 to 999");
            for (int i = 2; i < SIZE; i++)
            {
                if (primes[i])
                    Console.WriteLine(i + " is prime");
            }
            
        }
    }
}
/* Sample OUTPUT
 * All the prime numbers from 2 to 999
2 is prime
3 is prime
5 is prime
7 is prime
11 is prime
13 is prime
17 is prime
19 is prime
23 is prime
29 is prime
31 is prime
37 is prime
41 is prime
43 is prime
47 is prime
53 is prime
59 is prime
61 is prime
67 is prime
71 is prime
73 is prime
79 is prime
83 is prime
89 is prime
97 is prime
101 is prime
103 is prime
107 is prime
109 is prime
113 is prime
127 is prime
131 is prime
137 is prime
139 is prime
149 is prime
151 is prime
157 is prime
163 is prime
167 is prime
173 is prime
179 is prime
181 is prime
191 is prime
193 is prime
197 is prime
199 is prime
211 is prime
223 is prime
227 is prime
229 is prime
233 is prime
239 is prime
241 is prime
251 is prime
257 is prime
263 is prime
269 is prime
271 is prime
277 is prime
281 is prime
283 is prime
293 is prime
307 is prime
311 is prime
313 is prime
317 is prime
331 is prime
337 is prime
347 is prime
349 is prime
353 is prime
359 is prime
367 is prime
373 is prime
379 is prime
383 is prime
389 is prime
397 is prime
401 is prime
409 is prime
419 is prime
421 is prime
431 is prime
433 is prime
439 is prime
443 is prime
449 is prime
457 is prime
461 is prime
463 is prime
467 is prime
479 is prime
487 is prime
491 is prime
499 is prime
503 is prime
509 is prime
521 is prime
523 is prime
541 is prime
547 is prime
557 is prime
563 is prime
569 is prime
571 is prime
577 is prime
587 is prime
593 is prime
599 is prime
601 is prime
607 is prime
613 is prime
617 is prime
619 is prime
631 is prime
641 is prime
643 is prime
647 is prime
653 is prime
659 is prime
661 is prime
673 is prime
677 is prime
683 is prime
691 is prime
701 is prime
709 is prime
719 is prime
727 is prime
733 is prime
739 is prime
743 is prime
751 is prime
757 is prime
761 is prime
769 is prime
773 is prime
787 is prime
797 is prime
809 is prime
811 is prime
821 is prime
823 is prime
827 is prime
829 is prime
839 is prime
853 is prime
857 is prime
859 is prime
863 is prime
877 is prime
881 is prime
883 is prime
887 is prime
907 is prime
911 is prime
919 is prime
929 is prime
937 is prime
941 is prime
947 is prime
953 is prime
967 is prime
971 is prime
977 is prime
983 is prime
991 is prime
997 is prime
Press any key to continue . . .*/
