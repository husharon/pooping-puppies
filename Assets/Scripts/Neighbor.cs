using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Neighbor : MonoBehaviour
{

    private float angle = 20.0f; // rotate at angle degrees/second
    private float distance = 5.0f; // distance neighbor can see
    private Vector3 axis = Vector3.forward; // rotation axis
    private Vector3 origin;
    private Vector3 neighborDirection = Vector3.up;

    // Start is called before the first frame update
    void Start()
    {
        origin = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // update neighbor direction by a few degrees every frame
        //transform.RotateAround(Vector3.zero, axis, angle * Time.deltaTime); // this rotates the actual object, not a vector

        // use quaternion with neighborDirection ?

        

        if (CanSeePuppy())
        {
            // do something in PuppyController ? 
            // start level over ?

            // player dies, game over
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
       
    }

    bool CanSeePuppy()
    {
        RaycastHit2D hit = Physics2D.Raycast(origin, neighborDirection, distance);

        if (hit.collider != null)
        {
            if (hit.collider.CompareTag("Player"))
            {
                return true;
            }
        }
        return false;
    }
}
