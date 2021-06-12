using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPulled : MonoBehaviour
{

    public bool n = false; //Holds if on northern or southern pole
    GameObject player; //Holds player

    EnemyMove em;

    // Start is called before the first frame update
    void Start()
    {
        em = gameObject.GetComponent<EnemyMove>();

        //Gets player
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if ((MagnetPull.pullingN && n) &&
            (transform.position.y == player.transform.position.y || transform.position.x == player.transform.position.x))
        {
            em.pulled = true;
        }
        else if ((MagnetPull.pullingS && !n) &&
            (transform.position.y == player.transform.position.y || transform.position.x == player.transform.position.x))
        {
            em.pulled = true;
        }
        else 
        {
            em.pulled = false;
        }
    }
}
