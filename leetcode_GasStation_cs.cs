using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_GasStation_cs
{
    class Program
    {
        public static int CanCompleteCircuit(int[] gas, int[] cost)
        {
            int start_index = -1;

            int station_count = gas.Length;
            // sets the total no of stations in the gas array .

            /*
             algorithm : 

                1. run two loops , outer loop takes every gas station as the start_index 
                2. the inner loop checks for the given start index , if we can successfully  complete the tour 
                3. how to check the loop condition : 

             */

            for (int station_start = 0 ; station_start < station_count ; station_start++)
            {
                // iterate through each station start  possibility.

                int gas_capacity = gas[station_start % station_count];
                // stores the gas capacity of the vehicle

                int trip = 0;
                // successfull trips completed 

                while ( trip < station_count &&  gas_capacity >= cost[(trip + station_start) % station_count])
                {
                    // test all the successfull trips that can be made from the station_start 
                    gas_capacity -= cost[(trip + station_start) % station_count];
                    // decrease the gas capacity after successfully completing a trip .

                    trip += 1;
                    // increment the successfully completed trip count by 1 .

                    gas_capacity += gas[(trip + station_start) % station_count];
                    // refuel the current capacity at the new station.
                }

                if (trip == station_count)
                {
                    // successfully visited all the stations : job done

                    return station_start;
                }
            }


            return start_index;
        }
        static void Main(string[] args)
        {
            /*
            int[] gas   = { 1, 2, 3, 4, 5 };
            int[] cost  = { 3, 4, 5, 1, 2 };
            */

            int[] gas  = { 2, 3, 4 };
            int[] cost = { 3, 4, 3 };
            int station_start = CanCompleteCircuit(gas, cost);
            // implement the gas array in circular form 

            Console.WriteLine(station_start);
            Console.ReadLine();

        }
    }
}
