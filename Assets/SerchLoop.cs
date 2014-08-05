using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System;

public class SerchLoop : MonoBehaviour
{
		public double baseNumber, day;

		List<string> str = new  List<string> ();
		void Start ()
		{
				string folder = Application.dataPath;
				for (int i = 0; i <= 8; i++) {
						double ans = Math.Pow (baseNumber, i);
						str.Add (string.Format ("{0}^{1} = {2} {2}÷{3}={4} …{5}", baseNumber, i, ans, day, (int)(ans / day), ans % day));
				}

				SaveText (folder, @"\test.txt", str.ToArray ());
		}

		//テキストファイルとしてセーブ
		public void SaveText (string fileFolder, string filename, string[] dataStr)
		{
				using (StreamWriter w = new StreamWriter(fileFolder+filename)) {
						foreach (var item in dataStr) {
								w.WriteLine (item);
						}
				}
		}
}
