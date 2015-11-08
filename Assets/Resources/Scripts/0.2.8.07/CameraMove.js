var ScrollSpeed:float = 25;
var ScrollEdge:float = 0.01;
 
@Range (5.0, 25.0)
var GlobalRange: int;
var ZoomRange:Vector2;
var CurrentZoom:float = 0;
var ZoomZpeed:float = 1;
var ZoomRotation:float = 1;
 
private var InitPos:Vector3;
private var InitRotation:Vector3;
var mycamera: Camera;
var AxisSpeed : float;
 
 
 
function Start()
{  
    InitPos = transform.position;
    InitRotation = transform.eulerAngles;
    mycamera=GameObject.Find("Main Camera").GetComponent.<Camera>();
    ZoomRange = new Vector2(-GlobalRange,GlobalRange+5);
}
 
function Update ()
{
	//Jump
	    if(Input.GetKey("mouse 2"))
	    {
	        Debug.Log("Clicou");
	        //Under Development
	    }
	    else
	    {
	        if((Input.GetKey("d") || Input.mousePosition.x >= Screen.width * (1 - ScrollEdge)))
	        {
	        	if(transform.position.x <= 125)
	       		{
	           		transform.Translate(Vector3.right * Time.deltaTime * ScrollSpeed, Space.World);
	           	}
	           	else
	           	{
	           		transform.position = new Vector3(125,transform.position.y,transform.position.z);
	           	}
	        }
	        else if((Input.GetKey("a") || Input.mousePosition.x <= Screen.width * ScrollEdge))
	        {
	        	if(transform.position.x >= -15)
	       		{
	           		transform.Translate(Vector3.right * Time.deltaTime * -ScrollSpeed, Space.World);
	           	}
	           	else
	           	{
	           		transform.position = new Vector3(-15,transform.position.y,transform.position.z);
	           	}
	        }
	       
	        if ((Input.GetKey("w") || Input.mousePosition.y >= Screen.height * (1 - ScrollEdge)))
	        {
	        	if(transform.position.z <= 110)
	       		{
	            	transform.Translate(Vector3.forward * Time.deltaTime * ScrollSpeed, Space.World);
	           	}
	           	else
	           	{
	           		transform.position = new Vector3(transform.position.x,transform.position.y,110f);
	           	}
	        }
	        else if ((Input.GetKey("s") || Input.mousePosition.y <= Screen.height * ScrollEdge))
	        {
	       		if(transform.position.z >= -9.5f)
	       		{
	           		transform.Translate(Vector3.forward * Time.deltaTime * -ScrollSpeed, Space.World);
	           	}
	           	else
	           	{
	           		transform.position = new Vector3(transform.position.x,transform.position.y,-9.5f);
	           	}
	        }
	    }

    CurrentZoom -= Input.GetAxis("Mouse ScrollWheel") * Time.deltaTime * 1000 * ZoomZpeed;
    CurrentZoom = Mathf.Clamp(CurrentZoom,ZoomRange.x,ZoomRange.y);
    transform.position.y -= (transform.position.y - (InitPos.y + CurrentZoom));
    transform.eulerAngles.x -= (transform.eulerAngles.x - (InitRotation.x + CurrentZoom * ZoomRotation));
    
    if(Input.GetKey(KeyCode.LeftControl) && Input.GetKey(KeyCode.LeftAlt) && Input.GetKey("r"))
    {
    	Application.LoadLevel(0);
    }
   
}