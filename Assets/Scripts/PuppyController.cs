using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuppyController : MonoBehaviour
{
    public float speed = 3;
    private Rigidbody2D rb;
    private PolygonCollider2D pc2;
    public Sprite[] frames;
    private SpriteRenderer sr;

    private void Start()
    {
        pc2 = GetComponent<PolygonCollider2D>();
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal") * speed;
        float y = Input.GetAxis("Vertical") * speed;
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            sr.flipX = true;
            StartCoroutine(PlayAnimationSIDE());
            sr.sprite = frames[0];
        }
        else
        {
            StopCoroutine(PlayAnimationSIDE());
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            sr.flipX = false;
            StartCoroutine(PlayAnimationSIDE());
            sr.sprite = frames[0];
        }
        else
        {
            StopCoroutine(PlayAnimationSIDE());
        }
        rb.velocity = new Vector2(x, y);
    }
    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.CompareTag("Target"))
        {
            Physics2D.IgnoreCollision(col.collider, GetComponent<Collider2D>());
        }

    }
    IEnumerator PlayAnimationSIDE()
    {
        foreach (Sprite temp in frames)
        {
            sr.sprite = temp;
            yield return new WaitForSeconds(0.2f);
        }
    }

}
