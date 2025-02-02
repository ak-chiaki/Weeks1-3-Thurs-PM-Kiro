using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class curtain : MonoBehaviour
{
   
    public float speed = 5f;  // Speed of the curtain
    bool isMoving = false;  // if moving
    Vector3 startPos;  // the start position of the curtain
    public bool direction = false;

    void Start()
    {
        startPos = transform.position; 
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !isMoving && transform.position == startPos)// the curtain only can be triggered on it's start position
        {
            isMoving = true; // start moving
        }

        if (isMoving&&!direction)//jusge the direction
        {
            transform.position += new Vector3(speed * Time.deltaTime, 0, 0);//move to the right
            Vector2 screenPos = Camera.main.WorldToScreenPoint(transform.position);// get the screen position
            if (screenPos.x >= Screen.width)
            {
                isMoving = false; // stop moving while reach to the edge of screen
            }
        }
        if (isMoving && direction)
        {
            transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);//move to the left
            Vector2 screenPos = Camera.main.WorldToScreenPoint(transform.position);// get the screen position

            if (screenPos.x <= 0)
            {
                isMoving = false; // stop moving while reach to the edge of screen
            }
        }
    }
}
