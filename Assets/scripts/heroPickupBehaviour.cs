using UnityEngine;
using System.Collections;

public class heroPickupBehaviour : MonoBehaviour {

	public bool switching;

	public bool isInFrontOfAHidingPlace = false;
	public GameObject currentHidingPlace;

	public int numberOfThings = 5;
	public int personality;

	public int player1Points = 0, player2Points = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space)) {
			if (personality == 0 && isInFrontOfAHidingPlace && numberOfThings > 0) 
			{
				currentHidingPlace.GetComponent<hidingplace>().NumberOfThings += 1;
				numberOfThings--;
				player1Points++;
				Debug.Log("placed thing");
			}
			else if (personality == 1 && isInFrontOfAHidingPlace) {
				if (currentHidingPlace.GetComponent<hidingplace>().HasThings()) 
				{
					currentHidingPlace.GetComponent<hidingplace>().NumberOfThings -= 1;
					numberOfThings++;
					Debug.Log("took thing");
					player2Points++;
				}
			}

//			numberOfThingsGUIText.text = numberOfThings.ToString();
		}
	}
//
//	void OnCollisionEnter(Collision collision) {
//		Debug.Log ("OnCollisionEnter");
//	}
	
	void OnTriggerEnter2D(Collider2D other) {
		currentHidingPlace = other.gameObject;
		isInFrontOfAHidingPlace = true;
//		Debug.Log ("OnTriggerEnter");
	}
}
