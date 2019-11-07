using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draggable2 : MonoBehaviour
{
    private Vector3 screenPoint;
private Vector3 offset;
public float rightBound, leftBound, topBound, bottomBound;



private void checkBounds(Vector3 cursorPosition){
    if(cursorPosition.x>=rightBound)
        cursorPosition.x=rightBound;

    else if(cursorPosition.x<=leftBound)
        cursorPosition.x=leftBound;

    else if(cursorPosition.y>=topBound)
        cursorPosition.y=topBound;

    else if(cursorPosition.y<=bottomBound)
        cursorPosition.y=bottomBound;
}

void OnMouseDown()
{
screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);

offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));

}

void OnMouseDrag()
{
Vector3 cursorScreenPoint = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
Vector3 cursorPosition = Camera.main.ScreenToWorldPoint (cursorScreenPoint) + offset;

    
    if(cursorPosition.y<=bottomBound && cursorPosition.x >= rightBound){
            cursorPosition.x=rightBound;
            cursorPosition.y=bottomBound;
    }
    else if(cursorPosition.y<=bottomBound && cursorPosition.x <= leftBound){
            cursorPosition.y=bottomBound;
            cursorPosition.x=leftBound;
    }
    else if(cursorPosition.x>=rightBound && cursorPosition.y >= topBound){
            cursorPosition.x=rightBound;
            cursorPosition.y=topBound;
    }
    else if(cursorPosition.x<=leftBound && cursorPosition.y >= topBound){
            cursorPosition.x=leftBound;
            cursorPosition.y=topBound;
    }
    else if(cursorPosition.x>=rightBound)
        cursorPosition.x=rightBound;
    else if(cursorPosition.x<=leftBound)
        cursorPosition.x=leftBound;
    else if(cursorPosition.y>=topBound)
        cursorPosition.y=topBound;
    else if(cursorPosition.y<=bottomBound)
        cursorPosition.y=bottomBound;
    else if(cursorPosition.y> topBound/2)
        cursorPosition.y = topBound;
    else   
        cursorPosition.y = bottomBound;


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
