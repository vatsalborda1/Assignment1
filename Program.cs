using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1
            Console.WriteLine("Q1: Enter the string:");
            string s = Console.ReadLine();
            string final_string = RemoveVowels(s);
            Console.WriteLine("Final string after removing the Vowels: {0}", final_string);
            Console.WriteLine();

            //Question 2:
            string[] bulls_string1 = new string[] { "Marshall", "Student", "Center" };
            string[] bulls_string2 = new string[] { "MarshallStudent", "Center" };
            bool flag = ArrayStringsAreEqual(bulls_string1, bulls_string2);
            Console.WriteLine("Q2");
            if (flag)
            {
                Console.WriteLine("Yes, Both the array’s represent the same string");
            }
            else
            {
                Console.WriteLine("No, Both the array’s don’t represent the same string ");
            }
            Console.WriteLine();

            //Question 3:
            int[] bull_bucks = new int[] { 1, 2, 3, 2 };
            int unique_sum = SumOfUnique(bull_bucks);
            Console.WriteLine("Q3:");
            Console.WriteLine("Sum of Unique Elements in the array are :{0}", unique_sum);
            Console.WriteLine();


            //Question 4:
            int[,] bulls_grid = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Console.WriteLine("Q4:");
            int diagSum = DiagonalSum(bulls_grid);
            Console.WriteLine("The sum of diagonal elements in the bulls grid is {0}:", diagSum);
            Console.WriteLine();

            //Question 5:
            Console.WriteLine("Q5:");
            String bulls_string = "aiohn";
            int[] indices = { 3, 1, 4, 2, 0 };
            String rotated_string = RestoreString(bulls_string, indices);
            Console.WriteLine("The  Final string after rotation is {0} ", rotated_string);
            Console.WriteLine();

            //Quesiton 6:
            string bulls_string6 = "mumacollegeofbusiness";
            char ch = 'c';
            string reversed_string = ReversePrefix(bulls_string6, ch);
            Console.WriteLine("Q6:");
            Console.WriteLine("Resultant string are reversing the prefix:{0}", reversed_string);
            Console.WriteLine();

        }

        /* 
        <summary>
        Given a string s, remove the vowels 'a', 'e', 'i', 'o', and 'u' from it, and return the new string.
        Example 1:
        Input: s = "MumaCollegeofBusiness"
        Output: "MmCllgfBsnss"
        Example 2:
        Input: s = "aeiou"
        Output: ""
        Constraints:
        •	0 <= s.length <= 10000
        s consists of uppercase and lowercase letters
        </summary>
        */

        private static string RemoveVowels(string s)
        {
            try
            {
                //Removal process will be in removal loop even if single vowlel is there in the string capital or small
                while (s.Contains("a")
                    || s.Contains("e")
                    || s.Contains("i")
                    || s.Contains("o")
                    || s.Contains("u")
                    || s.Contains("A")
                    || s.Contains("E")
                    || s.Contains("I")
                    || s.Contains("O")
                    || s.Contains("U"))
                {

                    //run through all if statements for each vowel and remove them if they exist
                    if (s.Contains("a"))
                    {
                        int index_of_a = s.IndexOf("a");
                        s = s.Remove(index_of_a, 1);
                    }

                    if (s.Contains("e"))
                    {
                        int index_of_e = s.IndexOf("e");
                        s = s.Remove(index_of_e, 1);
                    }

                    if (s.Contains("i"))
                    {
                        int index_of_i = s.IndexOf("i");
                        s = s.Remove(index_of_i, 1);
                    }

                    if (s.Contains("o"))
                    {
                        int index_of_o = s.IndexOf("o");
                        s = s.Remove(index_of_o, 1);
                    }

                    if (s.Contains("u"))
                    {
                        int index_of_u = s.IndexOf("u");
                        s = s.Remove(index_of_u, 1);
                    }


                    if (s.Contains("A"))
                    {
                        int index_of_A = s.IndexOf("A");
                        s = s.Remove(index_of_A, 1);
                    }

                    if (s.Contains("E"))
                    {
                        int index_of_E = s.IndexOf("E");
                        s = s.Remove(index_of_E, 1);
                    }

                    if (s.Contains("I"))
                    {
                        int index_of_I = s.IndexOf("I");
                        s = s.Remove(index_of_I, 1);
                    }

                    if (s.Contains("O"))
                    {
                        int index_of_O = s.IndexOf("O");
                        s = s.Remove(index_of_O, 1);
                    }

                    if (s.Contains("U"))
                    {
                        int index_of_U = s.IndexOf("U");
                        s = s.Remove(index_of_U, 1);
                    }

                }
                //returning the 'vowel-less' string after complete removal of vowels using while loop.
                //string final_string = input;
                return s;
                String final_string = "";
                return final_string;
            }
            catch (Exception)
            {
                throw;
            }

        }

        /* 
        <summary>
       Given two string arrays word1 and word2, return true if the two arrays represent the same string, and false otherwise.
       A string is represented by an array if the array elements concatenated in order forms the string.
       Example 1:
       Input: : bulls_string1 = ["Marshall", "Student",”Center”], : bulls_string2 = ["MarshallStudent ", "Center"]
       Output: true
       Explanation:
       word1 represents string "marshall" + "student" + “center” -> "MarshallStudentCenter "
       word2 represents string "MarshallStudent" + "Center" -> "MarshallStudentCenter"
       The strings are the same, so return true.
       Example 2:
       Input: word1 = ["Zimmerman", "School", ”of Advertising”, ”and Mass Communications”], word2 = ["Muma", “College”,"of”, “Business"]
       Output: false
       Example 3:
       Input: word1  = ["University", "of", "SouthFlorida"], word2 = ["UniversityofSouthFlorida"]
       Output: true
       </summary>
       */

        private static bool ArrayStringsAreEqual(string[] bulls_string1, string[] bulls_string2)
        {
            try
            {
                // write your code here.
                string two = "";
                for (int i = 0; i < bulls_string1.Length; i++)
                {
                    two += bulls_string1[i];
                }
                // Console.WriteLine(two);

                string three = "";
                for (int i = 0; i < bulls_string2.Length; i++)
                {
                    three += bulls_string2[i];
                }
                bool result = two.Equals(three);
                return result;
                return false;
            }
            catch (Exception)
            {

                throw;
            }

        }
        /*
        <summary> 
       You are given an integer array bull_bucks. The unique elements of an array are the elements that appear exactly once in the array.
       Return the sum of all the unique elements of nums.
       Example 1:
       Input: bull_bucks = [1,2,3,2]
       Output: 4
       Explanation: The unique elements are [1,3], and the sum is 4.
       Example 2:
       Input: bull_bucks = [1,1,1,1,1]
       Output: 0
       Explanation: There are no unique elements, and the sum is 0.
       Example 3:
       Input: bull_bucks = [1,2,3,4,5]
       Output: 15
       Explanation: The unique elements are [1,2,3,4,5], and the sum is 15.
       </summary>
        */

        private static int SumOfUnique(int[] bull_bucks)
        {
            try
            {
                // write your code here
                //initialising & defining sum and value as 0 for 'for' loop
                int sum = 0;
                //Two for loops needed to pick each element and compare that with other element (similar to linear search)
                for (int i = 0; i < bull_bucks.Length; i++)
                {

                    int count = 0;
                    
                    for (int j = 0; j < bull_bucks.Length; j++)
                    {
                        //making sure it doesn't compare it with itself.
                        if (bull_bucks[i] == bull_bucks[j] && i != j)
                        {
                            count++;
                        }
                    }
                    //when it's different it adds it into sum
                    if (count == 0)
                    {
                        sum = sum + bull_bucks[i];
                    }
                }
                return sum;
                return 0;

            }
            catch (Exception)
            {
                throw;
            }
        }
        /*
        <summary>
       Given a square matrix bulls_grid, return the sum of the matrix diagonals.
       Only include the sum of all the elements on the primary diagonal and all the elements on the secondary diagonal that are not part of the primary diagonal.
       Example 1:
       Input: bulls_grid = [[1,2,3],[4,5,6], [7,8,9]]
       Output: 25
       Explanation: Diagonals sum: 1 + 5 + 9 + 3 + 7 = 25
       Notice that element mat[1][1] = 5 is counted only once.
       Example 2:
       Input: bulls_grid = [[1,1,1,1], [1,1,1,1],[1,1,1,1], [1,1,1,1]]
       Output: 8
       Example 3:
       Input: bulls_grid = [[5]]
       Output: 5
       </summary>
        */

        private static int DiagonalSum(int[,] bulls_grid)
        {
            try
            {
                int len = bulls_grid.GetLength(0);

                int p_diagonal = 0;
                int s_diagonal = 0;
                for (int i = 0; i < len; i++)
                {
                    for (int j = 0; j < len; j++)
                    {
                        if (i == j)
                        {
                            p_diagonal = p_diagonal + bulls_grid[i, j];
                        }
                        if ((i + j) == (len - 1) && i != j)
                        {
                            s_diagonal = s_diagonal + bulls_grid[i, j];
                        }

                    }

                }


                return (p_diagonal + s_diagonal);


                return 0;
            }
            catch (Exception e)
            {

                Console.WriteLine("An error occured: " + e.Message);
                throw;
            }

        }



        /*
         
        <summary>
        Given a string bulls_string  and an integer array indices of the same length.
        The string bulls_string  will be shuffled such that the character at the ith position moves to indices[i] in the shuffled string.
        Return the shuffled string.
        Example 3:
        Input: bulls_string  = "aiohn", indices = [3,1,4,2,0]
        Output: "nihao"
        */

        private static string RestoreString(string bulls_string, int[] indices)
        {
            try
            {
                // write your code here.
                
                
                //defining array to store reshuffled characters as an array
                string[] final;
                //length would be same as inputs
                final = new string[indices.Length];

                //iterating for loop to reassignment each position according to input array 
                for (int i = 0; i < bulls_string.Length; i++)
                {

                    final[indices[i]] = Convert.ToString(bulls_string[i]);
                }
                //initiating empty string to collect all elements of final array into single string
                string p = "";
                for (int i = 0; i < bulls_string.Length; i++)
                {
                    p += Convert.ToString(final[i]);
                }
                return p;
                return "null";
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

        }

        /*
         <summary>
        Given a 0-indexed string bulls_string   and a character ch, reverse the segment of word that starts at index 0 and ends at the index of the first occurrence of ch (inclusive). If the character ch does not exist in word, do nothing.
        For example, if word = "abcdefd" and ch = "d", then you should reverse the segment that starts at 0 and ends at 3 (inclusive). The resulting string will be "dcbaefd".
        Return the resulting string.
        Example 1:
        Input: bulls_string   = "mumacollegeofbusiness", ch = "c"
        Output: "camumollegeofbusiness"
        Explanation: The first occurrence of "c" is at index 4. 
        Reverse the part of word from 0 to 4 (inclusive), the resulting string is "camumollegeofbusiness".
        Example 2:
        Input: bulls_string   = "xyxzxe", ch = "z"
        Output: "zxyxxe"
        Explanation: The first and only occurrence of "z" is at index 3.
        Reverse the part of word from 0 to 3 (inclusive), the resulting string is "zxyxxe".
        Example 3:
        Input: bulls_string   = "zimmermanschoolofadvertising", ch = "x"
        Output: "zimmermanschoolofadvertising"
        Explanation: "x" does not exist in word.
        You should not do any reverse operation, the resulting string is "zimmermanschoolofadvertising".
        */

        private static string ReversePrefix(string bulls_string6, char ch)
        {
            try
            {
                Char[] abc = bulls_string6.ToCharArray();
                for (int i = 0; i < bulls_string6.Length; i++)
                {
                    if (Char.IsUpper(abc[i]))
                    {
                        throw new Exception("PLease enter lower case letters only");
                    }
                }
                int ind = 0;
                String s1;
                String s2;
                char[] ans = bulls_string6.ToCharArray();
                for (int i = 0; i < bulls_string6.Length; i++)
                {
                    if (ans[i] == ch)
                    {
                        ind = i;
                        break;
                    }
                }

                if (ind == 0)
                {

                    return bulls_string6;
                }
                else
                {
                    s1 = bulls_string6.Substring(0, ind + 1);
                    char[] sz = s1.ToCharArray();
                    Array.Reverse(sz);
                    s2 = bulls_string6.Substring(ind + 1);
                    return new String(sz) + s2;

                }

                String prefix_string = "";
                return prefix_string;
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
