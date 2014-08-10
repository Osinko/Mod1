using UnityEngine;
using System.Collections;

public class LoopNum3 : MonoBehaviour
{
		enum MenuItem
		{
				GAMESTART,
				LEADERSBORD,
				CONFIG,
				QUIT,
		};

		[SerializeField]
		MenuItem
				menuItem;
	
		int itemLength = 4;
		float count;

		void Start ()
		{
				count = 0;
				print (menuItem);
		}

		int gauge;
		bool prev;

		const int firstStoppingFPSwait = 30;
		const int repeatFPSwait = 4;

		void FixedUpdate ()
		{
				if (Input.GetKey (KeyCode.UpArrow)) {
						menuItem = (MenuItem)(((int)menuItem + itemLength - 1) % itemLength);
				}

				if (Input.GetKey (KeyCode.DownArrow)) {
						if (!prev) {
								gauge = firstStoppingFPSwait;
								menuItem = (MenuItem)(((int)menuItem + 1) % itemLength);
						} else {
								gauge--;
								if (gauge < 0) {
										gauge = repeatFPSwait;
										menuItem = (MenuItem)(((int)menuItem + 1) % itemLength);
								}
						}
						prev = true;
				} else {
						prev = false;
				}
		}
}
