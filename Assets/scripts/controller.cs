using UnityEngine;
using System.Collections;

public class controller : MonoBehaviour {

	public float moveSpeed = 0.1f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.RightArrow)) {
			Vector3 move = transform.position;
			move.x += moveSpeed;
			transform.position = move;
		}
		else if (Input.GetKey (KeyCode.LeftArrow)) {
			Vector3 move = transform.position;
			move.x -= moveSpeed;
			transform.position = move;
		}

		if (Input.GetKey (KeyCode.UpArrow)) {
			Vector3 move = transform.position;
			move.y += moveSpeed;
			transform.position = move;
		}

	}
}
