using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cone : MonoBehaviour
{
    private GameObject cat;
    private float distance = 5.0f; // distance neighbor can see

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
            Vector2 dogPos = col.gameObject.transform.position;
            Vector2 catPos = cat.transform.position;
            RaycastHit2D hit = Physics2D.Raycast(catPos, dogPos - catPos);
            if (hit.collider.CompareTag("Player"))
            {
                Debug.Log("cat sees dog");
                Debug.Log(hit.transform.tag);
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}
