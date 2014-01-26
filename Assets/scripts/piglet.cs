using UnityEngine;
using System.Collections;

public class piglet : MonoBehaviour {

	bool isInFrontOfAHidingPlace = false;
	private GameObject currentHidingPlace;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.Space)) {
			hide();
		}
	}

	void hide() {
		if (isInFrontOfAHidingPlace) {
			this.gameObject.SetActive(false);
		}
	}
	
	
	void OnTriggerEnter2D(Collider2D other) {
		//		if () {
		//
		//		}
		currentHidingPlace = other.gameObject;
		isInFrontOfAHidingPlace = true;
		//		Debug.Log ("OnTriggerEnter");
	}
	
	void OnTriggerExit2D(Collider2D other) {
		//		Debug.Log ("OnTriggerExit");
		isInFrontOfAHidingPlace = false;
	}
}
