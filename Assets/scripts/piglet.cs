using UnityEngine;
using System.Collections;

public class piglet : MonoBehaviour {

	bool isInFrontOfAHidingPlace = false;
	private pigletsHidingPlace currentHidingPlace;


	public bool isHiding = false;

	private float z;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Space)) {
			hide();
		}
	}

	void hide() {

		if (isInFrontOfAHidingPlace) 
		{
			Vector3 loc = transform.position;
			if (isHiding) 
			{
//				Debug.Log("unhide..");
				isHiding = false;
				loc.z += 20f;
			}
			else if (currentHidingPlace.canHideHere)
			{
//				Debug.Log("hide..");
				isHiding = true;
				loc.z -= 20f;
			}
			transform.position = loc;

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
		isInFrontOfAHidingPlace = false;
	}
}
