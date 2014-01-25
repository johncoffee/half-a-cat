using UnityEngine;
using System.Collections;

public class hidingplace : MonoBehaviour {

	private int numberOfThings = 3;

	public int NumberOfThings {
		get {
			return numberOfThings;
		}
		set {
			Debug.Log("hide 1 thing");
			numberOfThings = value;
		}
	}


	public bool HasThings() {
		return numberOfThings > 0;
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


}
