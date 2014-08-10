using UnityEngine;
using System.Collections;

public class LoopNum2 : MonoBehaviour
{
		public int loopUnit;
		public int speed;
		Transform _transform;
		float moveDirection;

		void Start ()
		{
				_transform = transform;
				_transform.position = Vector3.zero;
		}
	
		void Update ()
		{
				moveDirection = Input.GetAxis ("Horizontal");
				moveDirection *= speed * Time.deltaTime;

				float moveX;
				if (moveDirection >= 0) {
						moveX = (_transform.position.x + moveDirection) % loopUnit;
				} else {
						moveX = (_transform.position.x + loopUnit + moveDirection) % loopUnit;
				}

				_transform.position = new Vector3 (moveX, 0, 0);
		}
}
