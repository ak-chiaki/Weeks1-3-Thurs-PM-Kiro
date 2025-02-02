using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ghost_2 : MonoBehaviour
{
    public AnimationCurve movementCurve; // create animation curve inspector
    public float speed = 2f; // the speed of movement
    private float time = 0f;

    void Start()
    {

    }
    void Update()
    {
        Vector3 mouseScreenPos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.nearClipPlane);//get the position of mouse
        Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(mouseScreenPos);
        Vector3 direction = mouseWorldPos - transform.position;//calculate the Vector
        transform.position += direction * movementCurve.Evaluate(time) * speed * Time.deltaTime;//move the ghost
        time += Time.deltaTime;
    }
}