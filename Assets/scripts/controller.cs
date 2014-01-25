﻿using UnityEngine;
using System.Collections;

public class controller : MonoBehaviour {
	
	public float moveSpeed = 0.1f;
	public float jumpSpeed = 0.1f;

	public float horzFriction = 0.5f;

	private bool jumped;

	// Use this for initialization
	void Start () {
	
	}

	void OnCollisionEnter2D(Collision2D collision) {
		if (collision.gameObject.tag == "Floor") {
			jumped = false;
		}
	}

	void FixedUpdate(){
//		rigidbody2D.angularVelocity = Vector3.zero;
//		Vector3 vel = rigidbody.velocity;
//		vel.z = 0;
//		rigidbody.velocity = vel;
//		transform.rotation = Quaternion.identity;
//
		Vector2 move = rigidbody2D.velocity;
		move.x *= horzFriction;
		rigidbody2D.velocity = move;

	}


	// Update is called once per frame
	void Update () {
		
		heroPickupBehaviour hero = GetComponent<heroPickupBehaviour> ();
		if (hero.switching) {
			return;
		}

		if (Input.GetKey (KeyCode.RightArrow) || Input.GetKey (KeyCode.D)) {
			Vector2 move = rigidbody2D.velocity;
			move.x += moveSpeed;
			rigidbody2D.velocity = move;
		}
		else if (Input.GetKey (KeyCode.LeftArrow) || Input.GetKey (KeyCode.A)) {
			Vector2 move = rigidbody2D.velocity;
			move.x -= moveSpeed;
			rigidbody2D.velocity = move;

		}


<<<<<<< HEAD
		if (Input.GetKeyDown (KeyCode.UpArrow) || Input.GetKeyDown (KeyCode.W)) {
=======
		if ((Input.GetKeyDown (KeyCode.UpArrow) || Input.GetKeyDown (KeyCode.W)) && !jumped) {
//			Vector3 move = transform.position;
//			move.y += moveSpeed;
//			transform.position = move;
>>>>>>> 7bc57fec9df1434faf02488ba32f7ace36c196b8
			rigidbody2D.AddForce(Vector2.up * jumpSpeed);

			jumped = true;
		}

	}

}
