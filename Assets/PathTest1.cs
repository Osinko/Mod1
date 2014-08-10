using UnityEngine;
using System.Collections;
using System;

public class PathTest1 : MonoBehaviour
{
		void Start ()
		{
				//頂点の設定
				//2進16の位置のビットがオンの場合、外周になる
				byte[] point = {
					Convert.ToByte ("00000001", 2),	//Aの位置情報（1）
					Convert.ToByte ("00000010", 2),	//Bの位置情報（2）
					Convert.ToByte ("00000011", 2),	//Cの位置情報（3）
					Convert.ToByte ("00000100", 2),	//Dの位置情報（4）
					Convert.ToByte ("10000001", 2),	//aの位置情報（129）
					Convert.ToByte ("10000010", 2),	//bの位置情報（130）
					Convert.ToByte ("10000011", 2),	//cの位置情報（131）
					Convert.ToByte ("10000100", 2),	//dの位置情報（132）
				};

//				byte odd = Convert.ToByte ("00000101", 2);	//奇数（5）
//				byte even = Convert.ToByte ("00001010", 2);	//偶数（10）

				foreach (var item in point) {
						print (item);
				}
				print (Convert.ToString (point [0] >> 1, 2).PadLeft (8, '0'));		//1を右へビットシフトすると0になる
				print ((point [3] & 1) == 2);
		}


}
