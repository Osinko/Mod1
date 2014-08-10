using UnityEngine;
using System.Collections;

public class nCode : MonoBehaviour
{

		public float number;
		public int baseNum;

		void Start ()
		{
				print (NCode (number, baseNum));
		}

		//n進数へのコンバート
		public  string NCode (float number, float baseNum)
		{
				string str = "0.";
//				float mod;
				while (number!=0) {
						number = number * baseNum;
						int num = Mathf.FloorToInt (number);
						number -= num;
						if (num < 10) {
								str += num.ToString ();
						} else {
								float conv = num - 10;
								conv += (int)'A';
								str += (char)conv;
						}
				}
				return str;
		}
}
