using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDataStructures.HashTable
{
	public class HashTable
	{
		private string[] _hashTable { get; set; }
		public HashTable()
		{
			_hashTable= new string[10];
		}

		private int _hash(string key)
		{
			return	key.Length % _hashTable.Length;
		}

		public void Set(string key, string value)
		{
			//key is going to be hashed 
			int hashedKey = _hash(key);
			if (_hashTable[hashedKey] != null)
			{
				Console.WriteLine("Sorry, hash collision has occured");
			}
			else
			{
				_hashTable[hashedKey] = value;
			}

		}
		public string Get(string key)
		{
			int hashedKey = _hash(key);
			return _hashTable[hashedKey];
		}
	}
}


//Program.cs
/*
HashTable hashTable = new HashTable();

hashTable.Set("Teddy", "555-443-6571");
hashTable.Set("Steve", "555-134-6429");
hashTable.Set("Jessica", "555-214-1374");
hashTable.Set("Sara", "555-156-5311");
hashTable.Set("Jennifer", "555-641-2542");

Console.WriteLine(hashTable.Get("Teddy"));
Console.WriteLine(hashTable.Get("Steve"));
Console.WriteLine(hashTable.Get("Jessica"));
Console.WriteLine(hashTable.Get("Sara"));
Console.WriteLine(hashTable.Get("Jennifer"));
*/