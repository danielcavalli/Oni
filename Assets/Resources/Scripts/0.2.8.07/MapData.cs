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
	public Sprite line;
	void Start()
	{
		te = GameObject.Find ("GameManager");
		code = te.GetComponent<TileSettings> ();
		this.name = nindex.ToString();
		Type = te.GetComponent<TileSettings> ().grid_type[index,nindex];
		line = Resources.Load<Sprite>("Line");
		switch(Type)
		{
			case "Null":
				//GetComponent<MeshRenderer>().color = Color.white;
				Type = "Null";
				break;
			case "Street":
				//GetComponent<MeshRenderer>().color = Color.white;
				//GetComponent<MeshRenderer>().renderer = Resources.Load<Material>("Art/Chao");
				Type = "Street";
				break;
			case "Bulding1":
				//GetComponent<MeshRenderer>().color = Color.blue;
				population = 100;
				Type = "Bulding1";
				break;
			case "Bulding2":
				//GetComponent<MeshRenderer>().color = Color.yellow;
				population = 250;
				Type = "Bulding2";
				break;	
		}
	}
	void OnMouseDown()
	{
		//Type = MoveCamera.type;
		/*switch(MoveCamera.type)
		{
			case "Null":
				GetComponent<SpriteRenderer>().color = Color.white;
				Type = "Null";
				break;
			case "Street":
				GetComponent<SpriteRenderer>().sprite = line;
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
		}*/
	}
}
