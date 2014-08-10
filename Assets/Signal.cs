using UnityEngine;
using System.Collections;

public class Signal : MonoBehaviour
{
		public float interval;
		float counter = 0;

		void FixedUpdate ()
		{
				counter += Time.deltaTime;
				if (counter / interval > 1) {
						counter %= interval;
						print ("!");
				}
		}
}
