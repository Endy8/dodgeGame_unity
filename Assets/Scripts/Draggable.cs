using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draggable : MonoBehaviour
{
    private Vector3 screenPoint;
private Vector3 offset;

void OnMouseDown()
{
screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);

offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));

}

void OnMouseDrag()
{
Vector3 cursorScreenPoint = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
Vector3 cursorPosition = Camera.main.ScreenToWorldPoint (cursorScreenPoint) + offset;
//freeze Y axis
cursorPosition.y = -1.4f;
if(cursorPosition.x<=8){

}
else{
    cursorPosition.x=8;

}
transform.position = cursorPosition;
}

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
