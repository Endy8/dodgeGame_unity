using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;


public class SpawnSpiral : MonoBehaviour
{



void readTextFile(string file_path)
{
   StreamReader inp_stm = new StreamReader(file_path);

   file_path = "C:\\Users\\Andilozaur\\Test\\Assets\\Text\\matrix.txt";

   string inp_ln = inp_stm.ReadToEnd();
      
   inp_stm.Close( );  

   //return inp_ln;
}

    [SerializeField]
    string fileName;


    [SerializeField]
    GameObject objectCreate;

    [SerializeField]
    float fTimeIntervalSpawn;

    [SerializeField]
    Vector3 v3SpawnPositionJitter;

    public float rightBound, leftBound, topBound, bottomBound;

    float fTimer = 0;
    string content;
    int offset = 0;
    int offset2 = 0;

    Vector3 v3SpawnPos = new Vector3(0,0,50);

    // Start is called before the first frame update
    void Start()
    {
        //readTextFile(fileName);
        fTimer = fTimeIntervalSpawn;
        v3SpawnPos.x=leftBound;
        v3SpawnPos.y=topBound;
    }

    // Update is called once per frame
    void Update()
    {
        
        fTimer -= Time.deltaTime;
        if (fTimer <= 0)
        {
            fTimer = fTimeIntervalSpawn;


    
            if(v3SpawnPos.x <= rightBound && v3SpawnPos.y==topBound)
            {

                v3SpawnPos.x++;


                Instantiate(objectCreate, v3SpawnPos, Quaternion.Euler (0f, 0f, 0f));
            }
            else if(v3SpawnPos.y >= bottomBound && v3SpawnPos.x >= rightBound)
            {

                v3SpawnPos.y--;

                Instantiate(objectCreate, v3SpawnPos, Quaternion.Euler (0f, 0f, 90f));
            } 
            else if(v3SpawnPos.x >= leftBound && v3SpawnPos.y <= bottomBound)
            {

                v3SpawnPos.x--;

                Instantiate(objectCreate, v3SpawnPos, Quaternion.Euler (0f, 0f, 0f));
            }            
            else if(v3SpawnPos.y <= topBound && v3SpawnPos.x <= leftBound)
            {

                v3SpawnPos.y++;

                Instantiate(objectCreate, v3SpawnPos, Quaternion.Euler (0f, 0f, 90f));
            }

            

            
        }
    }
}
