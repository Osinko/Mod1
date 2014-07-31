using UnityEngine;
using System.Collections;
using System;

public class ModTest1 : MonoBehaviour
{
		void Start ()
		{
				print (Mathf.Pow (9, 7));
				print (Mathf.Pow (9, 8));	//unityのpow関数で8乗が限界
				print (Math.Pow (9, 8));
				print (Math.Pow (9, 15));	//doubleの計算で15乗が限界
				print (Math.Pow (9, 16));
		}
}
