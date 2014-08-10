using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class FindindexTest1 : MonoBehaviour
{
		void Start ()
		{
				var OnePairList = new List<defineOnePair> ();
				int MaxJyunkanVal = 0;
				int MaxJyunkan = 0;
				for (int I = 2; I < 20; I++) {
						OnePairList.Clear ();
			
						int Wararerukazu = 10;
						int Syou, Amari;
			
						bool FirstFlag = true;
						do {
								Syou = Wararerukazu / I;
								Amari = Wararerukazu % I;
								defineOnePair WillAdd;
								WillAdd.Syou = Syou;
								WillAdd.Amari = Amari;
				
								int WKInd = OnePairList.FindIndex (X => X.Syou == WillAdd.Syou
										&& X.Amari == WillAdd.Amari);
								if (WKInd >= 0) {
										int LenJyunkan = OnePairList.Count - WKInd;
										print (" 循環部の長さ=" + LenJyunkan);
										if (LenJyunkan > MaxJyunkan) {
												MaxJyunkan = LenJyunkan;
												MaxJyunkanVal = I;
										}
										break;
								}
								OnePairList.Add (WillAdd);
				
								if (FirstFlag) {
										FirstFlag = false;
										Console.WriteLine ();
										print (string.Format ("1/{0}=0.{1}", I, Syou));
								} else {
										print (Syou);
								}
								Wararerukazu = Amari * 10;
						} while (Amari != 0);
				}
				print ("");
				print (string.Format ("答えは{0}で、循環部の長さ={1}", MaxJyunkanVal, MaxJyunkan));
		}

		private struct defineOnePair
		{
				internal int Syou;
				internal int Amari;
		}

}

