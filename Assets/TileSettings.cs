using UnityEngine;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Form_Servant;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;
using System.IO;
using System.Diagnostics;

public class TileSettings : MonoBehaviour 
{

	List<string> user_lines = new List<string> { };
	string[] userDatas = new string[] { };
	
	static public void ReadFile1()
	{
		using (StreamReader sr = new StreamReader("MyFile.txt"))
		{
			string line;
			while ((line = sr.ReadLine()) != null)
			{
				user_lines.Add(line);
				string lastLine = sr.ReadLine("MyFile.txt").Last();
				userDatas = lastLine.Split('|');
			}
		}
		for (int i = 0; i < user_lines.Count; i++)
		{
			userDatas = user_lines[i].Split('|');
			servantBox.DisplayMember = "Name";
		}
			
	}
	/*void Start()
	{
		for(var i = 0;i < linha;i++)
		{
			for(var n = 0;n < coluna;n++)
			{
				if(grid_type[i][n] != false)
				{
					Instantiate(T,new Vector3(grid_x[i],0,grid_y[n]),T.transform.rotation);
				}
			}
		}
	}*/
}
