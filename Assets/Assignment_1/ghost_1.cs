using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ghost_1 : MonoBehaviour
{
    public AnimationCurve movingCurve; // animation curve control the ghost
    public float speed = 8f; // spped of the ghost
    private float direction = 1f; // the direction of the moving
    private float time = 1f;

    void Start()
    {

    }
    void Update()
    {
        Vector2 screenPos = Camera.main.WorldToScreenPoint(transform.position);
        if (screenPos.x <= 1 || screenPos.x >= Screen.width-1)//if reach to the edge of the screen
        {
            direction *= -1; // change the direction when the ghost reach to the edge
            time = 1f;
        }
        float movement = movingCurve.Evaluate(time) * speed * direction * Time.deltaTime;//calculate the movement
        transform.position += new Vector3(movement, 0, 0);

        time += Time.deltaTime; //update the time
    }
}
