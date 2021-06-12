using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFuse : MonoBehaviour
{

    private void Update()
    {
       // Physics2D.OverlapCircle(transform.position, .5f).transform.tag == "Enemy";



        if (Physics2D.OverlapCircle(transform.position, .5f))
        { 
            
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("hi");

        //Check if enemy
        if (collision.transform.tag == "Enemy")
        {
            //Destroy collision and itself
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }

    private void OncolliderEnter(Collider2D collision)
    {
        Debug.Log("hi");

        //Check if enemy
        if (collision.transform.tag == "Enemy")
        {
            //Destroy collision and itself
            Destroy(collision);
            Destroy(gameObject);
        }
    }
}
