using UnityEngine;
using System.Collections;

public class LoopGen : MonoBehaviour
{

		public int number;
		public int zero;

		void Start ()
		{
				print (MathfUtils.Gcd (10, 13));
				float x = 24, y = 32;
				MathfUtils.Gcd (ref x, ref y);
				print (x + ":" + y);
				print (MathfUtils.Gcd2 (152963, 783049));
				print (LoopGenerate (number, zero));
		}

		double LoopGenerate (int number, int zero)
		{
				int digits = Mathf.CeilToInt (Mathf.Log10 (number)) + zero;
				double denominator = 1;
				for (int i = 0; i < digits; i++) {
						denominator *= 10;
				}
				denominator --;
				return number / denominator;
		}

		public static float Gcd (float x, float y)
		{
				while (x!=y) {
						if (x > y) {
								x -= y;
						} else {
								y -= x;
						}
				}
				return x;
		}
	


}