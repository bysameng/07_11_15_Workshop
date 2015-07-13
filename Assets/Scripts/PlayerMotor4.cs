using UnityEngine;
using System.Collections;

public class PlayerMotor4 : MonoBehaviour {

	Rigidbody rbody;

	void Awake(){
		rbody = GetComponent<Rigidbody>();
	}

	void Update(){
		DoMovement();
	}

	void DoMovement(){
		rbody.AddForce(PlayerMotor2.GetMovementBasedOnInput() * 10);
	}

}
