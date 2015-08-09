//#pragma strict
import System;
import System.Collections.Generic;
import System.ComponentModel;
import System.Linq;
import System.Text;
import System.Text.RegularExpressions;
import System.Runtime.InteropServices;
import System.IO;
 
var  fileName = "MapSettings.lua";
var grid_x = new Array();
var grid_y = new Array();
var linha : int = 2;
var coluna : int = 2;
var grid_type = new Array();
var T : GameObject;

function grid()
{
    for(var i = 0;i < linha;i++)
    {
        grid_type[i] = new Array(coluna);
        for (var n = 0;n < coluna;n++)
        {
            grid_x[i] = i;
            grid_y[n] = n;
            	grid_type[i][n] = gameObject.GetComponent("TileSetting").data[1];
            if(grid_type[i][n] == "True")
            	Instantiate(T, new Vector3(grid_x[i], 0, grid_y[n]), Quaternion.identity);
        }
    }
}
grid();
/*function Start()
{
        var sr = File.CreateText(fileName);
        for(var i = 0;i < linha;i++)
	    {
	        for (var n = 0;n < coluna;n++)
	        {
	            sr.WriteLine("|" + grid_type[i][n]);
	        }
	    }
        sr.Close();
}*/
//ReadFile(fileName);