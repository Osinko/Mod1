using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Length : MonoBehaviour
{
		int[] n = new int[4];

		List<string> str = new  List<string> ();

		void Start ()
		{
				n [0] = 0;
				n [1] = 1;
				n [2] = 2;
				n [3] = 3;

				print (n.Length);

				str.Add ("1");
				str.Add ("2");
				print (str.Count);
				print (str [1]);

				for (int i = 0; i < str.Count; i++) {
			
				}

		}
	
}
