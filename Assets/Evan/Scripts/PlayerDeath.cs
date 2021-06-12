using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        Collider2D[] collisions = Physics2D.OverlapCircleAll(transform.position, .5f);

        for (int i = 0; i < collisions.Length; i++)
        {
            if (collisions[i].gameObject != gameObject && 
                (collisions[i].transform.tag == "Death" || collisions[i].transform.tag == "Enemy"))
            {
                //Destroy itself
                Destroy(gameObject);
            }
        }
    }
}
