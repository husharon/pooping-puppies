using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Neighbor : MonoBehaviour
{

    //private float angle = 20.0f; // rotate at angle degrees/second
    private float speed = 7.0f;
    private Vector3 axis = Vector3.forward; // rotation axis

    // Update is called once per frame
    void Update()
    {
        // update neighbor direction by a few degrees every frame
        transform.Rotate(axis * speed * Time.deltaTime); // this rotates the actual object, not a vector
       
    }
    
    public bool CanSeePuppy(Vector3 dogPos)
    {
        Vector3 dirToDog = dogPos - transform.position;
        
        RaycastHit2D hit = Physics2D.Raycast(transform.position, dirToDog);
        Debug.DrawRay(transform.position, dirToDog, Color.red, 25.0f);

     
        if (hit.collider != null)
        {
            Debug.Log("Message: Raycast hit an object: " + hit.transform.tag);
            
            if (hit.collider.CompareTag("Player"))
            {
                Debug.Log("Message: Hit player in CanSeePuppy");
                return true;
            }
        }
        return false;
    }
}
