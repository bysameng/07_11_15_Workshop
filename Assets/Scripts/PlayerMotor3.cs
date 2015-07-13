using UnityEngine;
using System.Collections;

public class PlayerMotor3 : MonoBehaviour {

	public float maxSpeed = 5;
	public float rotationSpeed = 360;



	void Update () {
		DoMovement();
	}

	void DoMovement(){
		float forwardSpeed = Input.GetAxis("Vertical") * maxSpeed;
		transform.position += transform.forward * forwardSpeed * Time.deltaTime;

		float rotateSpeed = Input.GetAxis("Horizontal") * rotationSpeed;
		transform.Rotate(new Vector3(1,0,0), rotateSpeed * Time.deltaTime);
	}



}
