using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Move the sprite/object to toward the position where the player is touching on the screen.
*/

public class HandMovement : MonoBehaviour {

	//Vector3 newPosition;
	//SpriteRenderer spriteRenderer;

	//public float moveSensitivityX = 1f;
	//public float moveSensitivityY = 1f;

	// Use this for initialization
	//void Start () {
		//spriteRenderer = GetComponent<SpriteRenderer> ();
	//}
	
	// Update is called once per frame
	void Update () {
		if(Input.touchCount > 0) {
			transform.Translate(Input.GetTouch(0).deltaPosition * Time.deltaTime * 1f);
		}
		// if(Input.touchCount > 0) {
		// 	Debug.Log("Touching");
		// 	spriteRenderer.enabled = true;
		// 	Vector2 touchPos = Input.GetTouch(0).deltaPosition;
		// 	newPosition = new Vector3(touchPos.x, touchPos.y, 0f);
		// 	transform.position = newPosition;
		// } else {
		// 	spriteRenderer.enabled = false;
		// }

		// Touch[] touches = Input.touches;
		// if (touches.Length > 0) {
		// 	Debug.Log("Touched");
		// 	//single touch (move)
		// 	if (touches.Length == 1) {
		// 		if (touches [0].phase == TouchPhase.Moved) {
		// 			Debug.Log("Touching");
		// 			Vector2 delta = touches [0].deltaPosition;

		// 			float positionX = delta.x * moveSensitivityX * Time.deltaTime;
		// 			float positionY = delta.y * moveSensitivityY * Time.deltaTime;

		// 			transform.position += new Vector3 (positionX, positionY, 0f);
		// 		}
		// 	}
		// }
	}
}
