//#pragma strict
import System;
import System.IO;
 
var  fileName = "MyFile.txt";

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
            grid_type[i][n] = false;
        }
    }
}
grid();
/*function Start()
{
        if (File.Exists(fileName))
        {
            Debug.Log(fileName+" already exists.");
            return;
        }
        var sr = File.CreateText(fileName);
        for(var i = 0;i < linha;i++)
	    {
	        for (var n = 0;n < coluna;n++)
	        {
	            sr.WriteLine(" " + grid_type[i][n]);
	        }
	    }
        sr.Close();
}*/
//ReadFile(fileName);
function Update () 
{
	
}