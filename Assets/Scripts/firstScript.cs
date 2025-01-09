using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    float speed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        pos.x += speed;

        Vector2 suqareInScreenSpace = Camera.main.WorldToScreenPoint(pos);

        if (suqareInScreenSpace.x < -10 || suqareInScreenSpace.x > Screen.width)
        {
            speed = speed * 1;
        }





        transform.position = pos;




    }
}
