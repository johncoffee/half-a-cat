using UnityEngine;
using System.Collections;

public class hidingplace : MonoBehaviour {

	private int numberOfThings = 0;

	public bool canHideHere = true;

	public int NumberOfThings {
		get {
			return numberOfThings;
		}
		set {
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
