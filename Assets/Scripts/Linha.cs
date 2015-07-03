using UnityEngine;
using System.Collections;

public class Linha : MonoBehaviour {

	public Material st;
	public Material st2;
	public Material st3;
	public Material cross3;
	public Material cross4;
	public Material cross3R;
	public Material cross4R;
	public Material curve;
	public Material curveR;

	float routes;
	static public int stops = 0;

	public bool StopCreated = false;
	
	void Start () 
	{
		Rota.pos = new Vector3[1000];
	}

	void Update () 
	{
	}
	void OnMouseDown() 
	{
		if(Rota.canCreate)//&& renderer.sharedMaterial != st && renderer.sharedMaterial != st2) 
		{
			renderer.sharedMaterial = st3;
			StopCreated = true;
			stops += 1;
			Rota.pos[stops] = transform.position;
		}
		if(StopCreated && renderer.sharedMaterial != st && renderer.sharedMaterial != st2)
		{
			StopCreated = false;
			renderer.sharedMaterial = st3;
		}

		if (Rota.canCreate && renderer.sharedMaterial == st3) 
		{
			Rota.canCreate = false; 
			StopCreated = true;
		} 
	}
	void OnMouseOver()
	{
		if(Rota.canCreate && renderer.sharedMaterial == st) 
		{
			renderer.sharedMaterial = st2;
		}
		if(Rota.canCreate && renderer.sharedMaterial == cross3) 
		{
			renderer.sharedMaterial = cross3R;
		}
		if(Rota.canCreate && renderer.sharedMaterial == cross4) 
		{
			renderer.sharedMaterial = cross4R;
		}
		if(Rota.canCreate && renderer.sharedMaterial == curve) 
		{
			renderer.sharedMaterial = curveR;
		}
	}
}
