using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFuse : MonoBehaviour
{
    public bool isBlue;
    public GameObject magenta;

    bool first = true;

    public Animator a;
    EnemyMove em;

    private void Start()
    {
        em = gameObject.GetComponent<EnemyMove>();
    }

    private void Update()
    {
        Collider2D[] collisions = Physics2D.OverlapCircleAll(transform.position, .5f);

        for (int i = 0; i < collisions.Length; i++)
        {
            if (collisions[i].gameObject != gameObject && collisions[i].transform.tag == "Enemy" && (isBlue ^ collisions[i].GetComponent<EnemyFuse>().isBlue))
            {
                //Destroy collision and itself
                a.SetTrigger("Dead");
                if (isBlue && first)
                {                  
                    first = false;

                    Score.numScore += 10;
                    Vector3 wantedPoint = transform.position + ((collisions[i].transform.position - transform.position) / 2);
                    GameObject magentaEffect = Instantiate(magenta, wantedPoint, Quaternion.identity);
                    Destroy(magentaEffect, 1.5f);
                }
                Destroy(collisions[i].gameObject, 0.3f);
                Destroy(gameObject, 0.3f);
            }
        }
    }
}
