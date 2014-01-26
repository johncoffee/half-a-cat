using UnityEngine;
using System.Collections;

public class pooh : MonoBehaviour {

	public GameObject currentHidingPlace;

	private bool isInFrontOfAHidingPlace = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
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
