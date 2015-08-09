#pragma strict


var grid_x = new Array();
var grid_y = new Array();

var linha : int = 2;
var coluna : int = 2;

var grid_type = [];

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
            //grid_type[i][1] = true;
            if(grid_type[i][n] == true)
    		{ 
				Instantiate(T,new Vector3(grid_x[i],0,grid_y[n]),T.transform.rotation);
			}
        }
    }
}
grid();
function Update () 
{
}