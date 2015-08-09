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
	
	List<string> linesCount = new List<string>();
	public string[,] data;
	
	public string user = Environment.GetEnvironmentVariable("username");
	public string arquivin;
	public string[] qualquer;
	void Start()
	{
		arquivin = "MapSettings.lua";
		using (StreamReader file = new StreamReader("MapSettings.lua"))
		{
			string line;
			while ((line = file.ReadLine()) != null)
			{
				linesCount.Add(line);
			}
		}
		for (int i = 0; i < 100; i++)
		{
			for (int n = 0; n < 100; n++)
			{
				data[i,n] = linesCount[i,n].Split('|');
			}
		}

	}
}