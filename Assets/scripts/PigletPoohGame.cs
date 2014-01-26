using UnityEngine;
using System.Collections;

public class PigletPoohGame : MonoBehaviour
{

	public int playerTurnDuration = 30;
	public int switchLaptopDuration = 5;

	public GameObject cloak;

	public int startingPlayer = 0;

	private int playersTurn = 0;
	
	public piglet piglet;
	public pooh pooh;

	// Use this for initialization
	void Start ()
	{
		setPlayer (startingPlayer);
		initTurn ();
	}

	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.P)) {
			switchPlayer();
		}
	}

	void initTurn ()
	{
		UnCloak ();
		StartCoroutine( NextTurn() );
	}

	IEnumerator NextTurn ()
	{
//		Debug.Log ("Player " + playersTurn + "s turn");
	    yield return new WaitForSeconds (playerTurnDuration);

		Cloak ();

		yield return new WaitForSeconds (switchLaptopDuration);

		switchPlayer ();
	    initTurn ();
	}

	
	void switchPlayer () {
		playersTurn = 1 - playersTurn;
		setPlayer (playersTurn);
	}

	void setPlayer (int playerNumber) {
		playersTurn = playerNumber;

		if (playersTurn == 0) {
			piglet.GetComponent<controller>().isActive = true;
			pooh.GetComponent<controller>().isActive = false;
			pooh.GetComponent<AudioSource>().Stop();
			piglet.GetComponent<AudioSource>().Play();
		}
		else if (playersTurn == 1) {
			piglet.GetComponent<controller>().isActive = false;
			pooh.GetComponent<controller>().isActive = true;
			pooh.GetComponent<AudioSource>().Play();
			piglet.GetComponent<AudioSource>().Stop();
		}
	}
	
	void Cloak() {
		cloak.SetActive (true);
	}
	
	void UnCloak() {
		cloak.SetActive (false);
	}
}
