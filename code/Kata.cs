using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace warsMen
{
    public class Kata
    {
        public static string SpinWords(string sentence)
        {
            StringBuilder sentenceToReturn = new StringBuilder();
            foreach (var item in sentence.Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray())
            {
                string text = item;
                if (item.Length >= 5)
                {
                    char[] arr = item.ToCharArray();
                    arr = arr.Reverse().ToArray();
                    text = new string(arr);
                }
                sentenceToReturn.Append(text + " ");
            }
            return sentenceToReturn.ToString().TrimEnd();
        }

        public static string Likes(string[] name)
        {
            if (name.Count() == 0)
            {
                return "no one likes this";
            }
            else if (name.Count() == 1)
            {
                return $"{name[0]} likes this";
            }
            else if (name.Count() == 2)
            {
                return $"{name[0]} and {name[1]} like this";
            }
            else if (name.Count() == 3)
            {
                return $"{name[0]}, {name[1]} and {name[2]} like this";
            }
            else
            {
                return $"{name[0]}, {name[1]} and {name.Count() - 2} others like this";
            }   
        }

        public static int[] MoveZeroes(int[] arr)
        {
            // link -> https://www.codewars.com/kata/52597aa56021e91c93000cb0

            int count = 0;
            int[] array = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    count++;
                }
                else
                {
                    int f = Array.IndexOf(array, 0);
                    array[f] = arr[i];
                } 
            }
            return array;
        }
        public static string formatDuration(int seconds)
        {
            //link -> https://www.codewars.com/kata/52742f58faf5485cae000b9a/train/csharp
            int years = 0, days = 0, hours = 0, minutes = 0;
            StringBuilder sb = new StringBuilder();
            if (seconds == 0)
            {
                return "now";
            }else
            {
                days = seconds / 86400;
                seconds -= days * 86400;
                hours = seconds / 3600;
                seconds -= hours * 3600;
                minutes = seconds / 60;
                seconds -= minutes * 60;

                years = days / 365;
                days -= years * 365;

                sb.Append(years > 1 ? $"{years} years," : $"{years} year,");
                sb.Append(days > 1 ? $"{days} days," : $"{days} day,");
                sb.Append(hours > 1 ? $"{hours} hours," : $"{hours} hour,");
                sb.Append(minutes > 1 ? $"{minutes} minutes," : $"{minutes} minute,");
                sb.Append(seconds > 1 ? $"{seconds} seconds" : $"{seconds} second");
            }
            List<string> list = new List<string>();
            list = sb.ToString().Split(",").Where(x => x.ToCharArray().First() != '0').ToList();

            if (list.Count == 1)
            {
                return list[0];
            }else if (list.Count == 2)
            {
                return $"{list[0]} and {list[1]}";
            }else
            {
                sb.Clear();
                for (int i = 0; i < list.Count - 2; i++)
                {
                    sb.Append(list[i] + ", ");
                }
                sb.Append(list[list.Count - 2] + " and " + list.Last());
                return sb.ToString();
            }

            
        }

    }
}
