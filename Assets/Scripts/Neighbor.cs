using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Neighbor : MonoBehaviour
{

    private float angle = 20.0f; // rotate at angle degrees/second
    private Vector3 axis = Vector3.forward; // rotation axis
    private Vector3 neighborDirection;

    // Start is called before the first frame update
    void Start()
    {
        neighborDirection = Vector3.up;
    }

    // Update is called once per frame
    void Update()
    {
        // update neighbor direction by a few degrees every frame
        transform.RotateAround(Vector3.zero, axis, angle * Time.deltaTime);

        if (CanSeePuppy())
        {
            // do something in PuppyController ? 
            // start level over ?
        }
       
    }

    bool CanSeePuppy()
    {
        RaycastHit2D hit;


        return false;
    }
}
