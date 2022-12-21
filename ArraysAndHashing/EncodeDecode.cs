using System;
using System.Text;

namespace ArraysAndHashing
{
    public static class Codec
    {
        public static string Encode(IList<string> strs)
        {
            StringBuilder sb = new StringBuilder();
            int[] sizes = new int[strs.Count];

            for (int i = 0; i < strs.Count; i++)
            {
                sizes[i] = strs[i].Length;
                sb.Append(strs[i]);
            }

            var data = sb.ToString();
            return string.Join(",", sizes) + "$" + data;
        }

        public static IList<string> Decode(string str)
        {
            int dataBorder = 0;

            while (str[dataBorder] != '$')
            {
                dataBorder++;
            }

            string splitInfo = str.Substring(0, dataBorder);
            string[] sizes = splitInfo.Split(',');
            int[] intSizesArr = new int[sizes.Length];

            for (int i = 0; i < sizes.Length; i++)
                intSizesArr[i] = Int32.Parse(sizes[i]);

            IList<string> resultList = new List<string>(sizes.Length);
            int codeStart = dataBorder + 1;

            for (int i = 0; i < intSizesArr.Length; i++)
            {
                resultList.Add(str.Substring(codeStart, intSizesArr[i]));
                codeStart += intSizesArr[i];
            }

            return resultList;
        }
    }
}

