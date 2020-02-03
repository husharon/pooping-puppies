using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoopSpawn : MonoBehaviour
{
    [SerializeField]
    private GameObject poopPrefab;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Poop();
        }
    }

    void Poop()
    {
        Instantiate(poopPrefab, this.gameObject.transform.position, Quaternion.identity);
    }
}
