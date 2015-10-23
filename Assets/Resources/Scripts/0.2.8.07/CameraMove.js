var ScrollSpeed:float = 15;
var ScrollEdge:float = 0.01;
 
private var HorizontalScroll:int = 1;
private var VerticalScroll:int = 1;
private var DiagonalScroll:int = 1;
 
var PanSpeed:float = 10;
@Range (5.0, 25.0)
var GlobalRange: int;
var ZoomRange:Vector2;
var CurrentZoom:float = 0;
var ZoomZpeed:float = 1;
var ZoomRotation:float = 1;
 
private var InitPos:Vector3;
private var InitRotation:Vector3;
var mycamera: Camera;
 
 
 
function Start()
{
    //Instantiate(Arrow, Vector3.zero, Quaternion.identity);
   
    InitPos = transform.position;
    InitRotation = transform.eulerAngles;
    mycamera=GameObject.Find("Main Camera").GetComponent.<Camera>();
    ZoomRange = new Vector2(-GlobalRange,GlobalRange);
   
}
 
function Update ()
{
    //PAN
    if(Input.GetKey("mouse 2"))
    {
        Debug.Log("Clicou");
    }
    else
    {
        if ( Input.GetKey("d") || Input.mousePosition.x >= Screen.width * (1 - ScrollEdge) )
        {
            transform.Translate(Vector3.right * Time.deltaTime * ScrollSpeed, Space.World);
        }
        else if ( Input.GetKey("a") || Input.mousePosition.x <= Screen.width * ScrollEdge )
        {
            transform.Translate(Vector3.right * Time.deltaTime * -ScrollSpeed, Space.World);
        }
       
        if ( Input.GetKey("w") || Input.mousePosition.y >= Screen.height * (1 - ScrollEdge) )
        {
            transform.Translate(Vector3.forward * Time.deltaTime * ScrollSpeed, Space.World);
        }
        else if ( Input.GetKey("s") || Input.mousePosition.y <= Screen.height * ScrollEdge )
        {
            transform.Translate(Vector3.forward * Time.deltaTime * -ScrollSpeed, Space.World);
        }
    }
   
//ZOOM IN/OUT
   
    CurrentZoom -= Input.GetAxis("Mouse ScrollWheel") * Time.deltaTime * 1000 * ZoomZpeed;
   
    CurrentZoom = Mathf.Clamp(CurrentZoom,ZoomRange.x,ZoomRange.y);
   
    transform.position.y -= (transform.position.y - (InitPos.y + CurrentZoom));
    transform.eulerAngles.x -= (transform.eulerAngles.x - (InitRotation.x + CurrentZoom * ZoomRotation));
   
}