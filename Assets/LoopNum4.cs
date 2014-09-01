using UnityEngine;
using System.Collections;

public class LoopNum4 : MonoBehaviour
{

		void Start ()
		{
				int r = 0;        // counter
				int s = 0;        // bit-reversal of r/2<
				int N = 256;      // N can be any power of 2
				int N2 = N << 1;  // N<<1 == N*2
		
				do {
						print (s);
						r += 2;
						s ^= N - (N / (r & -r));
				} while (r < N2);
		}
	
}
