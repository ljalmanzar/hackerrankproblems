using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static string solve(int year){
        // Complete this function
      // arrays holding number of days for each type of year (febuary set as 28 initially)
      int[] JulianDays = {31, 28, 31, 30, 31, 30, 31, 31};
      int[] GregorianDays = {31, 28, 31, 30, 31, 30, 31, 31};
      
      int programmerDay = 256;
      int counter = 0;
      
      //split into 3 conditions
      if (year > 1918){
        //check for leap year, if so substitute 29 for feb
        if ( ( year%400==0 )||( year%4==0 && year%100!=0 ) )
          GregorianDays[1] = 29;
        
        foreach (var days in GregorianDays) {
          counter += days;
        }
      }
      else if (year < 1918){
        //check for leap year, if so substitute 29 for feb
        if (year%4==0)
          JulianDays[1] = 29;
        
        foreach (var days in JulianDays) {
          counter += days;
        }
      }
      //year is 1918
      else {
        return "26.09.1918";
      }
      
      programmerDay -= counter;
        
        string output = programmerDay + ".09." + year;
        
        return output;
    }

    static void Main(String[] args) {
        int year = Convert.ToInt32(Console.ReadLine());
        string result = solve(year);
        Console.WriteLine(result);
    }
}
