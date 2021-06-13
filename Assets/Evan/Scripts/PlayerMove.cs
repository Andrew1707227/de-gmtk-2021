using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public float moveSpeed; //holds move speed
    public Transform movePoint; //Holds point to move to
    public LayerMask stoppers; //Holds wall layer

    Sprite down; //Holds moving down sprite
    public Sprite up; //Holds moving up sprite
    public Sprite horiz; //Holds moving horiz. sprite

    public AudioClip moveSo;

    SpriteRenderer sr;
    AudioSource aSource;

    // Start is called before the first frame update
    void Start()
    {
        //Seperates movepoint
        movePoint.parent = null;

        sr = gameObject.GetComponent<SpriteRenderer>();
        aSource = gameObject.GetComponent<AudioSource>();

        //Gets down sprite
        down = sr.sprite;
    }

    // Update is called once per frame
    void Update()
    {        
        //Move player to movepoint
        transform.position = Vector3.MoveTowards(transform.position, movePoint.position, moveSpeed * Time.deltaTime);

        //Makes sure player has caugt up to movepoint before moving
        if (Vector3.Distance(transform.position, movePoint.position) <= .1f)
        {
            //Key checks
            if (Input.GetKeyDown(KeyCode.W))
            {
                //Start move
                move(0, 1, up);
            }
            else if (Input.GetKeyDown(KeyCode.S))
            {
                //Start move
                move(0, -1, down);
            }
            else if (Input.GetKeyDown(KeyCode.A))
            {
                //Start move
                move(-1, 0, horiz);
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                //Start move
                move(1, 0, horiz);
            }
        }
    }

    private void move(float movementX, float movementY, Sprite s)
    {
        //Check stopper for colliders
        if (!Physics2D.OverlapCircle(movePoint.position + new Vector3(movementX, movementY, 0f), .2f, stoppers))
        {
            //Move movepoint
            movePoint.position += new Vector3(movementX, movementY, 0f);

            aSource.pitch = Random.Range(0.8f, 1.2f);
            aSource.clip = moveSo;
            aSource.Play();

            //Check if x or y
            if (Mathf.Abs(movementY) > 0)
            {
                //Swap sprite
                sr.sprite = s;
            }
            else
            {
                //Swap sprite
                sr.sprite = s;

                //Check which x
                if (movementX == 1)
                {
                    sr.flipX = false;
                }
                else
                {
                    sr.flipX = true;
                }
            }
        }
    }
}
