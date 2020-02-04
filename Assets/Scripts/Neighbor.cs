using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Neighbor : MonoBehaviour
{

    //private float angle = 20.0f; // rotate at angle degrees/second
    private float speed = 3.0f;
    private float distance = 5.0f;
    private Vector3 axis = Vector3.forward; // rotation axis
    private Vector3 neighborDirection;
    private Vector3 origin;

    // Start is called before the first frame update
    void Start()
    {
        origin = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // update neighbor direction by a few degrees every frame
        transform.Rotate(axis * speed * Time.deltaTime); // this rotates the actual object, not a vector

        //transform.rotation()

        // update neighborDirection variable
        neighborDirection = transform.right;
        


        // use quaternion with neighborDirection ?

        

        if (CanSeePuppy())
        {
            // do something in PuppyController ? 
            // start level over ?

            // player dies, game over
            Debug.Log("Detected puppy");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
       
    }

    bool CanSeePuppy()
    {
        
        RaycastHit2D hit = Physics2D.Raycast(origin, neighborDirection, distance);
        Debug.DrawRay(origin, neighborDirection, Color.red, 10.0f);

     
        if (hit.collider != null)
        {
            Debug.Log("Hit an object: " + hit.transform.tag);
            
            if (hit.collider.CompareTag("Player"))
            {
                Debug.Log("Hit player");
                return true;
            }
        }
        return false;
    }
}
