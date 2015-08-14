using UnityEngine;
using System.Collections;

public class Time : MonoBehaviour {

	public float timer; 
	public bool timeStarted = true;

	void Update () 
	{
		if (timeStarted) 
		{
			timer += UnityEngine.Time.deltaTime; 
			Debug.Log("ALO");
		}       
	}



	void OnGUI() {

		int minutes = Mathf.FloorToInt(timer / 60);
		int seconds = Mathf.FloorToInt(timer - minutes * 60);
		
		string niceTime = string.Format("{0:00}:{1:00}", minutes, seconds);
		
		GUI.Label(new Rect(10,10,250,100), niceTime);
	} 
}
