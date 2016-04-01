using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace viusal
{
    public static class VariantGenirator
    {
        private static Dictionary<int, List<List<int>>> cahe = new Dictionary<int, List<List<int>>>();

        public static List<List<int>> GerVariant(int size)
        {
            if (cahe.ContainsKey(size))
                return cahe[size];

            var result = new List<List<int>>();
            for (int k = 1; k <= size; k++)
            {
                for (int i = 0; i < (1 << size); i++)
                {
                    int grayCode = i ^ (i >> 1);
                    if (count_bits(grayCode) == k)
                    {
                        var variant = new List<int>();
                        for (int j = 0; j < size; ++j)
                            if ((grayCode & (1 << j)) != 0)
                                variant.Add(j);

                        result.Add(variant);
                    }
                }
            }
            cahe.Add(size, result);
            return result;
        }

        public static List<string> GerVariant(string dictionary)
        {
            var vv = GerVariant(dictionary.Count());
            return vv.Select(l1 => string.Concat(l1.Select(l2 => dictionary[l2]))).ToList();
        }

        public static List<List<T>> GerVariant<T>(List<T> dictionary)
        {
            var vv = GerVariant(dictionary.Count());
            return vv.Select(l1 => l1.Select(l2 => dictionary[l2]).ToList()).ToList();
        }

        private static int count_bits(int n)
        {
            int res = 0;
            for (; n != 0; n >>= 1)
                res += n & 1;
            return res;
        }
    }
}