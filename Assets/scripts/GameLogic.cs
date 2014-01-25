using UnityEngine;
using System.Collections;

public class GameLogic : MonoBehaviour
{

	public int playerTurnDuration = 20;
	public int switchLaptopDuration = 10;

	public int playersTurn = 0;
	
	public bool state = true;

	public heroPickupBehaviour hero;

	// Use this for initialization
	void Start ()
	{
			Debug.Log ("Player ");
<<<<<<< HEAD
			initTurn ();
=======
//			initTurn ();
>>>>>>> origin/master
	}

	// Update is called once per frame
	void Update ()
	{
<<<<<<< HEAD
		if (Input.GetKeyDown (KeyCode.KeypadEnter)) {
=======
		if (Input.GetKeyDown (KeyCode.P)) {
>>>>>>> origin/master
			
			switchPlayer();
		}
	}

	void initTurn ()
	{
		StartCoroutine( NextTurn() );
	}

	IEnumerator NextTurn ()
	{
//		Debug.Log ("Player " + playersTurn + "s turn");
	    yield return new WaitForSeconds (playerTurnDuration);
		switchPlayer ();
	    initTurn ();
	}
	
	void switchPlayer () {
		playersTurn = 1 - playersTurn;
<<<<<<< HEAD
		hero.SetPersonality(playersTurn);
=======
		hero.personality = playersTurn;
>>>>>>> origin/master
		Debug.Log ("current Player " + playersTurn);
	}
}
