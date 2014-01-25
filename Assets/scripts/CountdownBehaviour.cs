using UnityEngine;
using System.Collections;

public class CountdownBehaviour : MonoBehaviour {
	private float end_time = 0f;

	public void reset(int countdown){
		end_time = Time.time + countdown;
	}

	void Update(){
		float time_left = end_time - Time.time;
		guiText.text = time_left.ToString ("F0");
	}
}
