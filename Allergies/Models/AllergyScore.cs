using System;
using System.Collections.Generic; //remove if not using Dictionary in app //

namespace AllergyScore
{
  public class Score
  {
    string[] allergies = { "eggs", "peanuts", "shellfish", "strawberries", "tomatoes", "chocolate", "pollen", "cats"};

    11011101

    7 = 4 + 2 + 1 

    111

    10 = 8 + 2

    1010 

    public static List<int> ConvertToBinary(int number)
    {
      List<int> result = new List<int>();
      while(number > 0)
      { // Why binary // How binary
        result.Add(number%2);
        number /=2; 
      }

      return result.Reverse();
    }
    /*3 - 11 - 
    6 - 110 - array[1], array[2] 

    2 in power 4 = 2 * 2 * 2 *2 
    
    1001 - 

    11 - 1011 1*8+0*4+1*2+1*1 - [3, 1, 0]
    ["egg", "peanuts", ...., "pollen" = 64]*/
  }
}

// List of codes x = 2 y = 4 z = 8
// number provided is 12
// -z = 4z