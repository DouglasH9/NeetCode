using ArraysAndHashing;

//int[] answer1 = TopKFreqElements.Calc(new int[] { 1, 1, 1, 2, 2, 3, }, 2);
//foreach (int num in answer1)
//    Console.WriteLine(num);

//int[] answer = ProductExceptSelf.Calc(new int[] { 1, 2, 3, 4 });
//foreach (int num in answer)
//{
//    Console.WriteLine(num);
//}

//List<string> strs = new List<string>() { "hello", "doug", "how", "are", "you?" };

//Console.WriteLine(Codec.Encode(strs));
//string code = Codec.Encode(strs);

//foreach (string word in Codec.Decode(code))
//{
//    Console.WriteLine(word);
//}
int[] array = new int[] { 0, 3, 7, 2, 5, 8, 4, 6, 0, 1 };

int longestRun = LongestConsecutiveSeq.Calc(array);
Console.WriteLine(longestRun);