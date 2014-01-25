using UnityEngine;
using System.Collections;

public class controller : MonoBehaviour {
	
	public float moveSpeed = 0.1f;
	public float jumpSpeed = 0.1f;

	// Use this for initialization
	void Start () {
	
	}

//	void FixedUpdate(){
//		rigidbody2D.angularVelocity = Vector3.zero;
//		Vector3 vel = rigidbody.velocity;
//		vel.z = 0;
//		rigidbody.velocity = vel;
//		transform.rotation = Quaternion.identity;
//
//	}


	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.RightArrow)) {
//			Vector3 move = transform.position;
//			move.x += moveSpeed;
//			transform.position = move;
			
			rigidbody2D.AddForce(Vector2.right * moveSpeed);
		}
		else if (Input.GetKey (KeyCode.LeftArrow)) {
//			Vector3 move = transform.position;
//			move.x -= moveSpeed;
//			transform.position = move;
			
			rigidbody2D.AddForce(Vector2.right * -moveSpeed);
		}

		if (Input.GetKeyDown (KeyCode.UpArrow) && rigidbody2D.collider) {
//			Vector3 move = transform.position;
//			move.y += moveSpeed;
//			transform.position = move;
			rigidbody2D.AddForce(Vector2.up * jumpSpeed);
		}

	}
}
