using UnityEngine;
using System.Collections;

public class heroPickupBehaviour : MonoBehaviour {

	public bool isInFrontOfAHidingPlace = false;
	public GameObject currentHidingPlace;

	public int numberOfThings = 3;
	public int personality;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space)) {
			if (personality == 0 && isInFrontOfAHidingPlace && numberOfThings > 0) {
				currentHidingPlace.GetComponent<hidingplace>().NumberOfThings += 1;
				numberOfThings--;
				Debug.Log("got thing " + numberOfThings);
			}
			else if (personality == 1 && isInFrontOfAHidingPlace) {
				if (currentHidingPlace.GetComponent<hidingplace>().HasThings()) {
					currentHidingPlace.GetComponent<hidingplace>().NumberOfThings -= 1;
					numberOfThings++;
					Debug.Log("placed thing. " + numberOfThings);
				}
				else {
					Debug.Log("has no things");
				}
			}
//			currentHidingPlace
		}
	}
//
//	void OnCollisionEnter(Collision collision) {
//		Debug.Log ("OnCollisionEnter");
//	}
	
	void OnTriggerEnter(Collider other) {
		currentHidingPlace = other.gameObject;
		isInFrontOfAHidingPlace = true;
//		Debug.Log ("OnTriggerEnter");
	}

	void OnTriggerExit(Collider other) {
//		Debug.Log ("OnTriggerExit");
		isInFrontOfAHidingPlace = false;
	}
}
