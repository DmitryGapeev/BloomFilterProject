using System.Collections.Generic;
using System;
using System.IO;
using System.Collections;

namespace AlgorithmsDataStructures
{
  public class BloomFilter
  {
    private BitArray _array;
    public int filter_len;

    public BloomFilter(int f_len)
    {
      filter_len = f_len;
      _array = new BitArray(filter_len);
    }

    // хэш-функции
    public int Hash1(string str1)
    {
      // 17
      int code = 0;
      for (int i = 0; i < str1.Length; i++)
        code = (code * 17 + str1[i]) %filter_len;

      return code;
    }
    public int Hash2(string str1)
    {
      // 223
      int code = 0;
      for (int i = 0; i < str1.Length; i++)
        code = (code * 223 + str1[i]) % filter_len;
      return code;
    }

    public void Add(string str1)
    {
      if(str1 == null)
        return;

      int code1 = Hash1(str1);
      int code2 = Hash2(str1);
      _array[code1] = true;
      _array[code2] = true;
    }

    public bool IsValue(string str1)
    {
      if (str1 == null)
        return false;
      
      int code1 = Hash1(str1);
      int code2 = Hash2(str1);

      return _array[code1] && _array[code2];
    }
  }
}