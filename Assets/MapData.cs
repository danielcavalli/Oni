using UnityEngine;
using System.Collections;

public class MapData : MonoBehaviour
{
	public int type;
	public int vanity;
	public int value;
	public GameObject nullObj;
	
	public MapData(int type, int vanity, int value)
	{
		this.type = type;
		this.vanity = vanity;
		this.value = value;
	}
	public void Inst(int posx,int posy,int posz)
	{
		if(type == 0)
		{
			Instantiate(nullObj, new Vector3(posx, posy, posz), Quaternion.identity);
		}
	}
}
