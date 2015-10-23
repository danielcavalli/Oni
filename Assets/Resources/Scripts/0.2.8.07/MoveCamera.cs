using UnityEngine;
using System.Collections;

public class MoveCamera : MonoBehaviour 
{
	
	void Update () {
		
		float mousePosX = Input.mousePosition.x; 
		float mousePosY = Input.mousePosition.y; 
		int scrollDistance = 5; 
		float scrollSpeed = 1;
		
		if (mousePosX < scrollDistance) 
		{ 
			transform.Translate(Vector3.right * -scrollSpeed); 
		} 
		if (mousePosX >= Screen.width - scrollDistance) 
		{ 
			transform.Translate(Vector3.right * scrollSpeed); 
		}
		
		if (mousePosY < scrollDistance) 
		{ 
			transform.Translate(Vector3.up * -scrollSpeed); 
		} 
		if (mousePosY >= Screen.height - scrollDistance) 
		{ 
			transform.Translate(Vector3.up * scrollSpeed); 
		}
		
		if (mousePosX < scrollDistance) 
		{ 
			transform.Translate(Vector3.right * -scrollSpeed); 
		} 
		if (mousePosX >= Screen.width - scrollDistance) 
		{ 
			transform.Translate(Vector3.right * scrollSpeed); 
		}
		
		if (mousePosY < scrollDistance) 
		{ 
			transform.Translate(Vector3.up * -scrollSpeed); 
		} 
		if (mousePosY >= Screen.height - scrollDistance) 
		{ 
			transform.Translate(Vector3.up * scrollSpeed); 
		}
	}
}
