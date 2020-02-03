using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Neighbor : MonoBehaviour
{

    Vector2 neighborDirection;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    float angle = 360.0f; // rotate 360 degrees
    float time = 1.0f; // Time unit in sec
    Vector3 axis = Vector3.up; // rotation axis

    // Update is called once per frame
    void Update()
    {
        // update neighbor direction by a few degrees every frame
        gameObject.GetComponent<Transform>().RotateAround(Vector3.zero, axis, angle * Time.deltaTime / time);
        
        // need a direction vector



    }

    bool CanSeePuppy()
    {
        RaycastHit2D hit;


        return false;
    }
}
