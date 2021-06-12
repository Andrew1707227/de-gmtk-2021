using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFuse : MonoBehaviour
{

    private void Update()
    {
        Collider2D[] collisions = Physics2D.OverlapCircleAll(transform.position, .5f);

        for (int i = 0; i < collisions.Length; i++)
        {
            if (collisions[i].gameObject != gameObject && collisions[i].transform.tag == "Enemy")
            {
                //Destroy collision and itself
                Destroy(collisions[i].gameObject);
                Destroy(gameObject);
            }
        }
    }
}
