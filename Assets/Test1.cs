using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Test1 : MonoBehaviour
{
		void Start ()
		{
				DispLoopNumber (2581);
		}

		void DispLoopNumber (int denominator)
		{
				LoopNumber lp = new LoopNumber (denominator);
				print (string.Format ("1/{0} : 循環開始位置=小数点{1}桁目：循環部の長さ={2}", lp.Denominator, lp.StartLoop, lp.Digits));
				print ("計算結果：" + lp.Number);
				print ("循環部：" + lp.LoopNum);
		}

		//循環小数を生成
		class LoopNumber
		{
				int denominator;		//分数の分母部
				int digits;
				string number = "";
				bool noLoop = false;

				List<Num> numList = new List<Num> ();
				
				//ctor
				public LoopNumber (int denominator)
				{
						this.denominator = denominator;
						int numerator = 10;		//分子
						int div, remaind;

						do {
								div = numerator / denominator;
								remaind = numerator % denominator;
								number += div;
								//初回時は初期化されていないのでマイナスの値になる
								digits = numList.FindIndex (x => x.div == div && x.remaind == remaind);
								numList.Add (new Num (){div=div,remaind=remaind});
								if (digits >= 0) {
										break;
								}	
								numerator = remaind * 10;
						} while (remaind!=0);

						if (numerator == 0) {
								noLoop = true;
						}
				}

				//計算した値
				public string Number {
						get{ return "0." + number;}
				}

				//循環部分のみ取り出した文字列
				public string LoopNum {
						get{ return noLoop ? "割り切れたので循環小数ではありません" : number.Substring (digits, number.Length - digits - 1);}
				}

				//循環開始桁
				public int StartLoop {
						get{ return digits + 1;}
				}

				//循環部分の数
				public int Digits {
						get{ return noLoop ? 0 : numList.Count - digits - 1;}
				}

				//循環部分の数
				public int Denominator {
						get{ return denominator;}
				}

				//割った答えと余りを保存して置き後で参照する
				struct Num
				{
						internal int div;
						internal int remaind;
				}
		}
}