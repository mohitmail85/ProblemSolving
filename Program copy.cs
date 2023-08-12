
// using System.Text;
// using Newtonsoft.Json;

// public class Program
// {
// 	public static void Main()
// 	{
      
//       List<int> A = new List<int>{1, 2, 3, 4, 5};
//       List<List<int>> B = new List<List<int>>{ new List<int>{0,2}, new List<int>{1,4}};
//       var temp = SumOfEven(A, B);
      
//       Console.WriteLine(temp);
//       // PalindromRec obj = new PalindromRec();
//       // string A = "naman";
//       // var temp = obj.isPalin(A, 0, A.Length);
//      // Console.WriteLine(temp);
// //       Matrix a = new Matrix(10, 5);
// // 	a.input();
// // 	Matrix b = new Matrix(10, 5);
// // 	b.input();
// //     Matrix c1 = a.add(b);
// //     Matrix c2 = a.subtract(b);
// //     Matrix c3 = a.transpose();
// //     a.print();
// //       Console.WriteLine(a);

//       //  Solution obj = new Solution();
//       //  ListNode node1 = new ListNode(1);
//       //   ListNode node2 = new ListNode(2);
//       //   node1.next = node2;
//       // var temp =  obj.solve(node1, 3,1);

//       // Circle a = new Circle(3);
// 	    // //a.perimeter();
//       // //a.area();
//       // Console.WriteLine(a.perimeter());
//       // Console.WriteLine(a.area());

//       //       PrintNumber obj = new PrintNumber();
//       //  int ans = obj.foo(3,5);
//       // obj.printNum(10);
//       //List<List<int>> res = new List<List<int>>{new List<int>{1,2,10}, new List<int>{2,3,20} , new List<int>{2,5,25} };

//       //Console.WriteLine(JsonConvert.SerializeObject(res));

// 	}
//       public static bool CheckBit(int x, int i)
//       {
//             if(((x>>i) & 1) == 1)
//             {
//                   return true;
//             }
//             else{
//                   return false;
//             }
//       }

//          public static int solveMaximum(List < int > A) {
//         List < int > v = new List < int > ();
//         for (int i = 0; i < A.Count; i++) 
//             v.Add(A[i]);
//         for (int i = 29; i >= 0; i--) {
//             // create a set of elements with the i-th bit set
//             List < int > v2 = new List < int > ();
//             for (int j = 0; j < v.Count; j++)
//             if ((v[j] & (1 << i)) > 0) 
//                 v2.Add(v[j]);
//             if (v2.Count >= 2) 
//                 v = v2;
//         }
//         return v[0] & v[1];
//     }

//          public static List<int> SumOfEven(List<int> A, List<List<int>> B) {
//           List<int> pf_odd = new List<int>();
//         List<int> res = new List<int>();
//         int sum = 0;
//         pf_odd.Add(0);
//         for(int i=1;i<A.Count;i++)
//         {
//             if(i%2 != 0){
//                 sum = sum + A[i];
//             }
//             pf_odd.Add(sum);
//         }

//         for(int j=0;j<B.Count;j++)
//         {
//             int s = B[j][0];
//             int e = B[j][1];
//             int sumA = 0;
//             if(s == 0){
//                 sumA = sumA + pf_odd[e];
//             }
//             else
//             {
//                 sumA = sumA + pf_odd[e] - pf_odd[s -1];
//             }
//             res.Add(sumA);
//         }
//         return res;


        
//     }
        
// }