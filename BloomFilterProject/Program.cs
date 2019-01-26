using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmsDataStructures;

namespace BloomFilterProject
{
  class Program
  {
    static void Main(string[] args)
    {
      TestBloomFilter();

      Console.ReadKey();
    }

    static void TestBloomFilter()
    {
      BloomFilter filter = new BloomFilter(32);

      for (int i = 0; i < 10; i++)
      {
        string str = string.Empty;
        for (int j = 0, s = i; j < 10; j++, s++)
          str += s % 10;
        filter.Add(str);
      }

      for (int i = 0; i < 10; i++)
      {
        string str = string.Empty;
        for (int j = 0, s = i; j < 10; j++, s++)
          str += s % 10;
       Console.WriteLine(str + " is exist = " + filter.IsValue(str));
      }

      string testStr = "aaaaaa";
      Console.WriteLine(testStr + " is exist = " + filter.IsValue(testStr));
      testStr = "12345678910";
      Console.WriteLine(testStr + " is exist = " + filter.IsValue(testStr));
    }
  }
}
