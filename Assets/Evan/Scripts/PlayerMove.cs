using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public float moveSpeed;
    public Transform movePoint;
    public LayerMask stoppers;

    KeyCode logMove;
    //int firstDir = 0;

    // Start is called before the first frame update
    void Start()
    {
        movePoint.parent = null;
    }

    // Update is called once per frame
    void Update()
    {
        /*
        //Move player to movepoint
        transform.position = Vector3.MoveTowards(transform.position, movePoint.position, moveSpeed * Time.deltaTime);

        //Makes sure player has caugt up to movepoint before moving
        if (Vector3.Distance(transform.position, movePoint.position) <= .05f)
        {
            //Horizontal key check
            if (Mathf.Abs(Input.GetAxisRaw("Horizontal")) == 1f && (firstDir == 0 || firstDir == 1))
            {
                //Check stopper for colliders
                if (!Physics2D.OverlapCircle(movePoint.position + new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f), .2f, stoppers))
                {
                    //Move movepoint
                    movePoint.position += new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f);

                    if (firstDir == 0)
                    {
                        firstDir = 1;
                    }
                }
            }
            else if(Mathf.Abs(Input.GetAxisRaw("Horizontal")) == 0f)
            {
                firstDir = 0;
            }

            //Vertical key check
            if (Mathf.Abs(Input.GetAxisRaw("Vertical")) == 1f && (firstDir == 0 || firstDir == 2))
            {
                 //Check stopper for colliders
                 if (!Physics2D.OverlapCircle(movePoint.position + new Vector3(0f, Input.GetAxisRaw("Vertical"), 0f), .2f, stoppers))
                {
                    //Move movepoint
                    movePoint.position += new Vector3(0f, Input.GetAxisRaw("Vertical"), 0f);

                    if (firstDir == 0)
                    {
                        firstDir = 2;
                    }
                }
            }
            else if (Mathf.Abs(Input.GetAxisRaw("Vertical")) == 0f)
            {
                firstDir = 0;
            }
        }
        */

        //Move player to movepoint
        transform.position = Vector3.MoveTowards(transform.position, movePoint.position, moveSpeed * Time.deltaTime);

        //Makes sure player has caugt up to movepoint before moving
        if (Vector3.Distance(transform.position, movePoint.position) <= .1f)
        {
            //Key checks
            if (Input.GetKeyDown(KeyCode.W))
            {
                //Start move
                move(0, 1);
            }
            else if (Input.GetKeyDown(KeyCode.S))
            {
                //Start move
                move(0, -1);
            }
            else if (Input.GetKeyDown(KeyCode.A))
            {
                //Start move
                move(-1, 0);
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                //Start move
                move(1, 0);
            }
        }
    }

    private void move(float movementX, float movementY)
    {
        //Check stopper for colliders
        if (!Physics2D.OverlapCircle(movePoint.position + new Vector3(movementX, movementY, 0f), .2f, stoppers))
        {
            //Move movepoint
            movePoint.position += new Vector3(movementX, movementY, 0f);
        }
    }
}
