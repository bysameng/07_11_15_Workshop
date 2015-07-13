using UnityEngine;
using System.Collections;

public class PlayerMotor1 : MonoBehaviour {

	void Start(){
		Debug.Log(5);
	}

	void Update(){
		float t = Time.deltaTime;
		bool leftIsPressed = Input.GetKey(KeyCode.LeftArrow);

		if (leftIsPressed){
			Vector3 newPosition = transform.position + new Vector3(-10, 0, 0) * t;
			transform.position = newPosition;
		}

		bool rightIsPressed = Input.GetKey(KeyCode.RightArrow);
		if (rightIsPressed){
			Vector3 newPosition = transform.position + new Vector3(10, 0, 0) * t;
			transform.position = newPosition;
		}

	}


}