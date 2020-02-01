using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    public float speed = 0.3f;
    public GameObject toEnd; 
    float x=0;
    float y=0;
    public float valueJump=0;
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(Time.deltaTime);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.position,toEnd.transform.position,Time.deltaTime);
        toEnd.transform.position = new Vector2(x,y);//перемещение обьекта toEnd на новую позицию (x,y)
        if( Input.GetKeyDown( KeyCode.Space ) )
        {
        //выполнение клавиши Space
        valueJump=Time.time;  
        }
        if( Input.GetKeyDown( KeyCode.D ) ) // нажатие клавиши W
        {   
            x++;
            Debug.Log("Press X" + "Value X=" + x);
        }
        if( Input.GetKeyDown( KeyCode.A ) ) // нажатие клавиши A
        {   
            x--;
            Debug.Log("Press X" + "Value X=" + x);
        }
        if( Input.GetKeyDown( KeyCode.W) ) // нажатие клавиши W
        {   
            y++;
            Debug.Log("Press Y" + "Value Y=" + y);
        }
        if( Input.GetKeyDown( KeyCode.S) ) // нажатие клавиши W
        {   
            y--;
            Debug.Log("Press Y" + "Value Y=" + y);
        }

    }
}

