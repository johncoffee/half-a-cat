using UnityEngine;
using System.Collections;

public class GameLogic : MonoBehaviour
{

	public int playerTurnDuration = 10;
	public int switchLaptopDuration = 5;

	public GameObject cloak;


	public GameObject player1ui, player2ui;
	public GUIText player1PointsGUI, player2PointsGUI;

	public int playersTurn = 0;

	public heroPickupBehaviour hero;

	// Use this for initialization
	void Start ()
	{
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
		hero.personality = playersTurn;
		
		hero.renderer.material.SetColor( "_Color", (playersTurn == 0) ? Color.red : Color.blue );
		Debug.Log ("current Player " + playersTurn);


		if (playersTurn == 0) {


		}
	}
	
	void Cloak() {
		cloak.SetActive (true);
	}
	
	void UnCloak() {
		cloak.SetActive (false);
	}
}
