using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cone : Neighbor
{
    private GameObject cat;

    // Start is called before the first frame update
    void Start()
    {
        cat = GetComponentInParent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(cat.transform.position, cat.transform.right, 100 * Time.deltaTime); 
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            Debug.Log("Message: Collided with the player, there might be a bush in the way");
            if (CanSeePuppy(col.gameObject.transform.position))
            {
                Debug.Log("Message: Puppy has been seen, game should end");
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
            
        
        }
    }
}
