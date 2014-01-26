using UnityEngine;
using System.Collections;

public class splashScreen : MonoBehaviour {
	public float waitTime = 4f;
	public string levelToLoad = "level 1 test";


	private float timer;
	// Use this for initialization
	void Start () {
		StartCoroutine ("DisplayScene");
	}
	
	// Update is called once per frame

	IEnumerator DisplayScene(){
		yield return new WaitForSeconds(waitTime);
		Application.LoadLevel (levelToLoad);

	}
}
