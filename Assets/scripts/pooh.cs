using UnityEngine;
using System.Collections;

public class pooh : MonoBehaviour {
	
	private pigletsHidingPlace currentHidingPlace;
	private bool isInFrontOfAHidingPlace = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (gameObject.GetComponent<controller> ().isActive) {

						if (Input.GetKeyDown (KeyCode.Space)) {
								seek ();
						}
				}
	}


	
	void seek() {
		Debug.Log ("seeking...");
		if (isInFrontOfAHidingPlace && currentHidingPlace.hasPiglet) 
		{
			Debug.Log("pooh wins!");
		}

	}
	
	void OnTriggerEnter2D(Collider2D other) {
//		Debug.Log ("OnTriggerEnter2D");
		pigletsHidingPlace hidingPlace = other.gameObject.GetComponent<pigletsHidingPlace>();
		if (hidingPlace != null) 
		{
			isInFrontOfAHidingPlace = true;
			currentHidingPlace = hidingPlace;
		}
	}
	
	void OnTriggerExit2D(Collider2D other) {
		//		Debug.Log ("OnTriggerExit");
		pigletsHidingPlace hidingPlace = other.gameObject.GetComponent<pigletsHidingPlace>();
		if (hidingPlace != null) 
		{
			isInFrontOfAHidingPlace = false;
		}
	}



}
