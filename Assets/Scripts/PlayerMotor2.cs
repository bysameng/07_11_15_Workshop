using UnityEngine;
using System.Collections;

public class PlayerMotor2 : MonoBehaviour {

	public float maxSpeed = 10;

	public KeyCode left = KeyCode.LeftArrow;
	public KeyCode right = KeyCode.RightArrow;


	void Update(){
		DoMovement();
	}


	void DoMovement(){
		transform.position += GetMovementBasedOnInput() * maxSpeed * Time.deltaTime;
	}


	public static Vector3 GetMovementBasedOnInput(){
		Vector3 movement = new Vector3(0,0,0);
		movement.x = Input.GetAxis("Horizontal");
		movement.y = Input.GetAxis("Vertical");
		return movement;
	}


}
