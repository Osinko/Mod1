using UnityEngine;
using System.Collections;

public class nCode : MonoBehaviour
{

		void Start ()
		{
				print (NCode (16, 2));
		}


		public  string NCode (float number, float baseNum)
		{
				string str = "";
				float mod;
				while (number!=0) {
						mod = number % baseNum;
						number = Mathf.FloorToInt (number / baseNum);
						str += mod.ToString ();
				}
				return str.Reverse ();
		}
}
