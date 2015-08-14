using UnityEngine;
using System.Collections;

public class MapData : MonoBehaviour
{
	GameObject te;
	Component code;
	public string Type;
	public int index;
	public int nindex;
	int population;
	void Start()
	{
		te = GameObject.Find ("GameManager");
		code = te.GetComponent<TileSettings> ();
		this.name = index.ToString() + nindex.ToString();
		Type = te.GetComponent<TileSettings> ().grid_type[index,nindex];
	}
	void OnMouseDown()
	{
		Type = MoveCamera.type;
		switch(MoveCamera.type)
		{
			case "Null":
				GetComponent<SpriteRenderer>().color = Color.green;
				Type = "Null";
				break;
			case "Street":
				GetComponent<SpriteRenderer>().color = Color.black;
				Type = "Street";
				break;
			case "Bulding1":
				GetComponent<SpriteRenderer>().color = Color.blue;
				population = 100;
				Type = "Bulding1";
				break;
			case "Bulding2":
				GetComponent<SpriteRenderer>().color = Color.yellow;
				population = 250;
				Type = "Bulding2";
				break;	
		}
	}
}
