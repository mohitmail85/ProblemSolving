
// /* 
// Given an array of words A (dictionary) and another array B (which contain some words).

// You have to return the binary array (of length |B|) as the answer where 1 denotes that the word is present in the dictionary and 0 denotes it is not present.

// Formally, for each word in B, you need to return 1 if it is present in Dictionary and 0 if not.

// Such problems can be seen in real life when we work on any online editor (like Google Documnet), if the word is not valid it is underlined by a red line.
// */

// class Node
// {
//     public char val;
//     public Node[] children;
//     public bool isEnd;
//     public Node(char x)
//     {
//         this.val = x;
//         this.isEnd = false;
//         this.children = new Node[26];
//     }
// }
// public static class TriesSpellChecker
// {
//     public Node head = Node('1');
//     public static List<int> SpellChecker(List<string> A, List<string> B)
//     {
//         List<int> ans = new List<int>();
//         int n = A.Count;
//         for (int i = 0; i < n; i++)
//         {
//             InsertChar(A[i]);
//         }
//         int m = B.Count;
//         for (int i = 0; i < n; i++)
//         {
//             var validWord = SearchWord(B[i]);
//             ans.Add(validWord);
//         }
//         return ans;

//     }

//     public static void InsertChar(string word)
//     {
//         int l = word.Length;
//         Node cur = head;
//         for (int j = 0; j < l; j++)
//         {
//             int idx = word[j] - 'a';
//             if (cur.children[idx] == null)
//             {
//                 cur.children[idx] = new Node(word[j]);
//             }
//             cur = cur.children[idx];
//         }
//         cur.isEnd = true;
//     }

//     public static int SearchWord(string word)
//     {
//         int l = word.Length;
//         Node cur = head;
//         for (int j = 0; j < l; j++)
//         {
//             int idx = word[j] - 'a';
//             if (cur.children[idx] == null)
//             {
//                 return 0;
//             }
//             cur = cur.children[idx];
//         }

//         return cur.isEnd ? 1 : 0;
//     }
// }