using UnityEngine;
using System.Collections;

public class Bus : MonoBehaviour {

	int i = 1;
	void Start () {
	
	}

	void Update () 
	{
		Debug.Log (i);
		if(Linha.stops != 0)
		{
			if(transform.position.x < Rota.pos[i].x)
			{
				transform.position += new Vector3(0.01f,0,0);
			}
			if(transform.position.z < Rota.pos[i].z)
			{
				transform.position += new Vector3(0,0,0.01f);
			}
			if(transform.position.x > Rota.pos[i].x)
			{
				transform.position += new Vector3(-0.01f,0,0);
			}
			if(transform.position.z > Rota.pos[i].z)
			{
				transform.position += new Vector3(0,0,-0.01f);
			}
			if(transform.position.z > Rota.pos[i+1].z && transform.position.x > Rota.pos[i+1].x)
			{
				i++;
			}
		}
	}
}
