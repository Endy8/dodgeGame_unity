using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draggable1 : MonoBehaviour
{
    private Vector3 screenPoint;
private Vector3 offset;
public GameObject gameObj;
public string wall;
public float rightBound, leftBound, topBound, bottomBound;

void OnMouseDown()
{
    Debug.Log(gameObj.transform.position);
    screenPoint = Camera.main.WorldToScreenPoint(gameObj.transform.position);
    offset = gameObj.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));

}

void OnMouseDrag()
{
    Vector3 cursorScreenPoint = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
    Vector3 cursorPosition = Camera.main.ScreenToWorldPoint (cursorScreenPoint) + offset;


    switch(wall)
    {
        case "UP":
            cursorPosition.y = topBound;

            if(cursorPosition.x>=rightBound)
                cursorPosition.x=rightBound;

            if(cursorPosition.x<=leftBound)
                cursorPosition.x=leftBound;
        break;

        case "DOWN":
            cursorPosition.y = bottomBound;

            if(cursorPosition.x>=rightBound)
                cursorPosition.x=rightBound;

            if(cursorPosition.x<=leftBound)
                cursorPosition.x=leftBound;

        break;

        case "LEFT":
            cursorPosition.x = leftBound;

            if(cursorPosition.y>=topBound)
                cursorPosition.y=topBound;

            if(cursorPosition.y<=bottomBound)
                cursorPosition.y=bottomBound;

        break;

        case "RIGHT":
            cursorPosition.x = rightBound;

            if(cursorPosition.y>=topBound)
                cursorPosition.y=topBound;

            if(cursorPosition.y<=bottomBound)
                cursorPosition.y=bottomBound;

        break;
        default:
        break;
    }


    gameObj.transform.position = cursorPosition;
}

    // Start is called before the first frame update
    void Start()
    {
        gameObj = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {

    }


}
