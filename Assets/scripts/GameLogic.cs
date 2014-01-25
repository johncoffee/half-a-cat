using UnityEngine;
using System.Collections;

public class GameLogic : MonoBehaviour
{

	public int playerTurnDuration = 10;
	public int switchLaptopDuration = 5;

	public GameObject cloak;


	public GameObject player1ui, player2ui;
	public GUIText player1PointsGUI, player2PointsGUI, numberOfThingsGUIText;

	public int playersTurn = 0;

	public heroPickupBehaviour hero;
	public CountdownBehaviour countdownTimer;

	// Use this for initialization
	void Start ()
	{
		setPlayer (0);
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
		int dur = playerTurnDuration;
		countdownTimer.reset (dur);
	    yield return new WaitForSeconds (playerTurnDuration);

		hero.rigidbody2D.velocity = new Vector2 (0,0);
		hero.switching = true;

		Debug.Log (hero.rigidbody2D.velocity);
		Cloak ();

		yield return new WaitForSeconds (switchLaptopDuration);

		switchPlayer ();
	    initTurn ();

		hero.switching = false;
	}

	
	void switchPlayer () {
		playersTurn = 1 - playersTurn;
		setPlayer (playersTurn);
	}

	void setPlayer (int playerNumber) {
		playersTurn = playerNumber;
		hero.personality = playerNumber;
		hero.renderer.material.SetColor( "_Color", (playerNumber == 0) ? Color.red : Color.blue );
		Debug.Log("current Player " + playerNumber);

		numberOfThingsGUIText.text = hero.numberOfThings.ToString ();

		if (playerNumber == 0) {
			player1ui.SetActive(true);
			player2ui.SetActive(false);
		}
		if (playerNumber == 1) {
			player1ui.SetActive(false);
			player2ui.SetActive(true);
		}
	}
	
	void Cloak() {
		cloak.SetActive (true);
	}
	
	void UnCloak() {
		cloak.SetActive (false);
	}
}
