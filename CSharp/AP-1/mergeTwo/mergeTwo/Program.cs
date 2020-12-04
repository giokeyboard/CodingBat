using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mergeTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Start with two arrays of strings, A and B, each with its elements in alphabetical order and
             * without duplicates. Return a new array containing the first N elements from the two arrays.
             * The result array should be in alphabetical order and without duplicates.
             * A and B will both have a length which is N or more.
             * The best "linear" solution makes a single pass over A and B, taking advantage of the fact that
             * they are in alphabetical order, copying elements directly to the new array.
             *
             * mergeTwo(["a", "c", "z"], ["b", "f", "z"], 3) → ["a", "b", "c"]
             * mergeTwo(["a", "c", "z"], ["c", "f", "z"], 3) → ["a", "c", "f"]
             * mergeTwo(["f", "g", "z"], ["c", "f", "g"], 3) → ["c", "f", "g"]
             */
            Console.WriteLine($"[{String.Join(",", MergeTwo(new String[] { "a", "c", "z" }, new String[] { "b", "f", "z" }, 3))}]");
            Console.WriteLine($"[{String.Join(",", MergeTwo(new String[] { "a", "c", "z" }, new String[] { "c", "f", "z" }, 3))}]");
            Console.WriteLine($"[{String.Join(",", MergeTwo(new String[] { "f", "g", "z" }, new String[] { "c", "f", "g" }, 3))}]");
        }

        private static string[] MergeTwo(string[] a, string[] b, int n)
        {
            string[] output = new string[n];
            int aIndex = 0;
            int bIndex = 0;

            for (int i = 0; i < output.Length; i++)
            {
                if (a[aIndex].CompareTo(b[bIndex]) < 0) output[i] = a[aIndex++];
                else if (a[aIndex].CompareTo(b[bIndex]) > 0) output[i] = b[bIndex++];
                else
                {
                    output[i] = a[aIndex++];
                    bIndex++;
                }
            }

            return output;
        }
    }
}
