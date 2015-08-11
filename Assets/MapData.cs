using UnityEngine;
using System.Collections;

public class MapData : MonoBehaviour
{
	GameObject Camera1;
	void OnMouseDown()
	{
		switch(MoveCamera.type)
		{
			case "Null":
				GetComponent<SpriteRenderer>().color = Color.green;
				break;
			case "Street":
				GetComponent<SpriteRenderer>().color = Color.black;
				break;
		}
		
	}
}
