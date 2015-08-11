using UnityEngine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;
using System.IO;

public class TileSettings : MonoBehaviour
{
	List<MapData> map_data = new List<MapData>();
	List<string> lines = new List<string>();
	
	public static List<string> linesCount = new List<string>();
	public string[,] data;
	
	float[] grid_x;
	float[] grid_y;
	string[,] grid_type; 
	public int coluna;
	public int linha;
	int map = 0;
	public string arquivin;
	public GameObject Tile;
	public GameObject Tile2;
	public int typo;
	
	Void Meu_grid()
	{
		grid_x = new float[linha];
		grid_y = new float[coluna];
		grid_type = new string[linha,coluna];
		for(int i = 0;i < linha;i++)
		{
			for (int n = 0;n < coluna;n++)
			{
				grid_x[i] = i*1.2f;
				grid_y[n] = n*1.2f;
				grid_type[i,n] = "Null";
				/*grid_type[i][n] = gameObject.GetComponent("TileSetting").data[1];
           		if(grid_type[i][n] == "True")
            		Instantiate(T, new Vector3(grid_x[i], 0, grid_y[n]), Quaternion.identity);*/
			}
		}
	}
	void ReadPorraToda()
	{
		arquivin = "MapSettings.mps";
		using (StreamReader file = new StreamReader(arquivin))
		{
			string line;
			while ((line = file.ReadLine()) != null)
			{
				linesCount.Add(line);
			}
		}
		if(linesCount.Count != (linha*coluna))
		{
			using (StreamWriter file = new StreamWriter(arquivin))
			{
				for(var i = 0;i < linha;i++)
				{
					for (var n = 0;n < coluna;n++)
					{
						file.WriteLine("|" + grid_type[i,n]);
					}
				}
				file.Close();
			}
			ReadPorraToda();
		}
	}
	void Start()
	{
		Meu_grid ();
		ReadPorraToda();
		for (int i = 0; i < linha; i++)
		{
			for (int n = 0; n < coluna; n++)
			{
				grid_type[i,n] = linesCount[map].Split('|')[1];
				map++;
				switch(grid_type[i,n])
				{
					case "Null":
						Tile.GetComponent<SpriteRenderer>().color = Color.green;
						Instantiate(Tile, new Vector3((float)grid_x[i], 0, (float)grid_y[n]), Tile.transform.rotation);
						break;
					case "Street":
					Tile.GetComponent<SpriteRenderer>().color = Color.black;
						Instantiate(Tile, new Vector3((float)grid_x[i], 0, (float)grid_y[n]), Tile.transform.rotation);
					break;
				}
			}
		}
		
	}
}