using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOnClick : MonoBehaviour
{
    GameObject objPlayer;
    
    // Start is called before the first frame update
    void Start()
    {
        objPlayer = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        while(Input.GetMouseButtonDown(0)){
            //var x = objPlayer.transform.position.x;
            //Vector3 temp = new Vector3(x+1f,0f,0f);
            //objPlayer.transform.position += temp;
            Debug.Log("click hold");
        }

    }

}
