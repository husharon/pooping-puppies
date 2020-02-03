using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    // Start is called before the first frame update
    SpriteRenderer sr;
    public int score;
    public Sprite successPoop;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log(col.gameObject.name + " : " + gameObject.name + " : " + Time.time);
        if (col.CompareTag("Poop"))
        {
            sr.sprite = successPoop;
            Debug.Log("Hurray it pooped");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
