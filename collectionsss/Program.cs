using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography;


//array: pros -> fast access by o(1)
//       cons -> fixedsize - waste of resources




#region arraylist

ArrayList al = new ArrayList();
al.Add(6);
al.Add("eslam");
//Console.WriteLine(al[1]);
//Console.WriteLine(al.Capacity);




////pros take an object so it can take any data type
//foreach (var item in al)
//{
//    Console.WriteLine(item);
//}


////cons alwayes nead boxing , unboxing -> so it's unsafe
//int sum = 0;
//for (int i = 0; i < al.Count; i++)
//{
//    sum += (int)al[i];
//}
//Console.WriteLine(sum);

#endregion


#region list
//List<int> list = new List<int> { 1, 2, 3, 4, 5 };

//List<int> lst = new List<int>(1);
//lst.Add(1);
//lst.Add(2);
//lst.Add(3);
//lst.Add(5);
//lst.Add(6);
//lst.Add(4);
//Console.WriteLine(lst.Capacity);
//lst.Add("eslam"); //-> cannot add items but type t intially setted (compiler enforce type safety)

//int sum = 0;
//for (int i = 0; i < lst.Count; i++)
//{
//	sum += lst[i];
//}
//Console.WriteLine(sum);


//// lst[10] = 4; // indexer update and retreive cannot add
//lst.AddRange(new int[] { 4, 4, 4, 4, });

//Console.WriteLine(lst.Count);
//Console.WriteLine(lst.Capacity);

//lst.TrimExcess();

//Console.WriteLine(lst.Count);
//Console.WriteLine(lst.Capacity);

#endregion


#region dictionary

//Dictionary<string, int> ph = new Dictionary<string, int>();

//ph.Add("eslam", 8734);
//ph.Add("ahmed", 893489);

////ph.Add("eslam", 8734); // exception because the key mustn't reapeted

//ph["ali"] = 93845; // indexer can used for addition unlike the list
////Console.WriteLine(ph["ali"]);

//foreach (KeyValuePair<string, int> item in ph)
//{
//    Console.WriteLine(item.Key + "     " + item.Value);
//}


//foreach (var item in ph)
//{
//    Console.WriteLine(item.Key + "     " + item.Value);
//}


//List<string> keys = ph.Keys.ToList();

//for (int i = 0; i <keys.Count; i++)
//{
//    string keyy = keys[i];
//    int value = ph[keyy];
//} 
#endregion


#region hashset
//HashSet<int> hs = new HashSet<int> { 1, 2, 3, 4, 5 };
//hs.Add(6);
//hs.Add(3);  // doesn't allow Duplicate so won't be added un like list
//foreach (var item in hs)
//{
//    Console.WriteLine(item);
//}


#endregion


















#region tuple


//Tuple<int, string, bool> tuple = new Tuple<int, string, bool>(1, "two", true);
//Console.WriteLine(tuple.Item1);  // Output: 1
//Console.WriteLine(tuple.Item2);  // Output: two
//Console.WriteLine(tuple.Item3);  // Output: True

#endregion

