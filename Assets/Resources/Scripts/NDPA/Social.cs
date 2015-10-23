using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;
using System.IO;
using UnityEngine.UI;

public class Social : MonoBehaviour 
{
	
	public string text;
	
	public List<string> lines = new List<string>();
	public List<string> linesCount = new List<string>();
	public List<string> linesCount2 = new List<string>();

	public string[] grid_type;
	public int coluna = 2;
	public int linha = 5;
	int map = 0;
	int type;
	string[] name;
	int random;
	int tiles;
	int timer = 0;
	public Text SocialText;
	public TextAsset file;
	int limit;
	public static string TutorialString;
	//Read the Text file
	void SetGridType(string filename, List<string> lists)
	{	
		/*file = Resources.Load(filename) as TextAsset;
		string line;
		while ((line = file.text.Split('|')[1]) != null)
		{
			lists.Add(line);
			lines.Add (line);
		}*/
		//if((line = file.text.Split('|')[1]) == null)
	//	{
		while (limit <= linha)
		{
			linesCount.Add("|Esta faltando onibus para os alunos irem a escola! Faça uma rota ate ela!@ #Absurdo #SeraQueVaiTerCopa #ChoraBangu");
			linesCount2.Add ("|PrefeituraBusInc");
			lines.Add (linesCount[limit]);
			limit++;
		}
	}
	public void Type1()
	{
		limit = 0;
		linesCount = new List<string>() ;
		linesCount2 = new List<string>();
		lines = new List<string>();
		while (limit <= linha)
		{
			linesCount.Add(TutorialString);
			linesCount2.Add ("|PrefeituraBusInc");
			lines.Add (linesCount[limit]);
			limit++;
		}
		nome ();
		Read ();
	}
	void nome()
	{
		name = new string[linesCount2.Count];
		for (int i = 0; i < linesCount2.Count; i++)
		{
			name[i] = linesCount2[i].Split('|')[1];
		}
	}
	//Set Grid
	void grid()
	{
		grid_type = new string[linha];
		for(int i = 0;i < linha;i++)
		{
			grid_type[i] = "Null";
		}
	}
	// Storage the Text in grid_type variables
	void Read()
	{
		random  = Random.Range (0,name.Length-1);
		//Debug.Log(random);
		for (int i = 0; i < linha; i++)
		{
			lines[i] = linesCount[i].Split('@')[1];
			lines[i] = "<color=#5784B4>" + lines[i] + "</color>";
			grid_type[i] = "<color=#5784B4>@" + name[random] + "</color>: " + (linesCount[i].Split('|','#')[1] + lines[i]).Replace("@", "");
		}
	}
	
	void Start () 
	{
		SocialText = gameObject.GetComponent<Text>();
		grid ();
		SetGridType("Events.txt",linesCount);
		//SetGridType("Names.txt",linesCount2);
		nome ();
		Read ();
		Debug.Log (grid_type[0]);
	}
	
	void Update () 
	{	
		timer--;
		if(timer <= 0)
		{
			type = Random.Range (0,grid_type.Length);
			timer = 300;
		}
		SocialText.text = grid_type[type];
	}
}
