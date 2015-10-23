using UnityEngine;
using System.Collections;

public class Build_Inst : MonoBehaviour {
	
	public GameObject PersonP; 
	public GameObject person;
	int pessoas = 0;
	int vaiqueneh;
	int timer = 180;

	void Start () 
	{
		PersonP = GameObject.Find ("Timer");
		person = Resources.Load("Prefabs/People") as GameObject;
	}

	void Update () 
	{
		timer--;
		vaiqueneh = Random.Range (0, 100);
		if(vaiqueneh >= 99 && timer <= 0)
		{
			pessoas = Random.Range (1,4);
			timer = 180;
		}
		if (timer <= -10) 
		{
			timer = 180;
		}
		if(pessoas >=1)
		{
			GameObject people = Instantiate(person, new Vector3(this.transform.position.x, 0, this.transform.position.z), Quaternion.identity) as GameObject;
			pessoas--;
		}
		//Debug.Log (timer);
	}
}
