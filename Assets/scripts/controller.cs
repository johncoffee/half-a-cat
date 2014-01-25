using UnityEngine;
using System.Collections;

public class controller : MonoBehaviour {
	
	public float moveSpeed = 0.04f;
	public float jumpSpeed = 5f;

	private int jumpCount = 0;
	
	// Use this for initialization
	void Start () {
	}

	void FixedUpdate(){
		rigidbody.angularVelocity = Vector3.zero;
		Vector3 vel = rigidbody.velocity;
		vel.z = 0;
		rigidbody.velocity = vel;
		transform.rotation = Quaternion.identity;

	}

	void OnCollisionEnter (Collision hit)
	{
		if(hit.gameObject.tag == "Floor")
		{
			jumpCount = 0;
		}
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.RightArrow)) {
//			Vector3 move = transform.position;
//			move.x += moveSpeed;
//			transform.position = move;
			
			rigidbody.AddForce(Vector3.right * moveSpeed);
		}
		else if (Input.GetKey (KeyCode.LeftArrow)) {
//			Vector3 move = transform.position;
//			move.x -= moveSpeed;
//			transform.position = move;
			
			rigidbody.AddForce(Vector3.left * moveSpeed);
		}

		if (Input.GetKeyDown (KeyCode.UpArrow) && jumpCount == 0) {

//			Vector3 move = transform.position;
//			move.y += moveSpeed;
//			transform.position = move;
			rigidbody.AddForce(Vector3.up * jumpSpeed);

			jumpCount = 1;
		}

	}
}
