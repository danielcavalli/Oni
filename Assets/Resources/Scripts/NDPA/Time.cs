using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Time : MonoBehaviour {

	//public float timer; 
	//public bool timeStarted = true;
	public int minutes;
	public int seconds;
	public Text text;
	float count = 0; 
	public GameObject person; 


			

	void Start () 
	{
		minutes = 6;
	} 
	
	 


	void FixedUpdate() 
		{

		count++; 	

		if (count == 5) {

			seconds++; 
			count = 0;
		} 

		if (seconds == 60) {
			
			minutes += 1;
			seconds = 0;
		} 
		
		if (minutes == 24) {
			
			minutes = 0; 
			
		} 


	
	}





			
	public void OnGUI() {

	
		string niceTime = string.Format("{0:00}:{1:00}", minutes, seconds);

				text = gameObject.GetComponent<Text>();
				text.text = niceTime;

		} 
}
