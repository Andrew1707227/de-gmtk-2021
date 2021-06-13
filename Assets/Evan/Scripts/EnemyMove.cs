using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    [HideInInspector]
    public float moveSpeed = 2; //Holds movement speed
    [HideInInspector]
    public bool pulled = false; //Holds if being pulled

    public LayerMask stoppers; //Layermask for hitting walls
    public bool horizFlip = false; //Holds which horizontal flip is wanted

    Transform movePoint; //Holds point to move to
    GameObject player; //Holds player
    Vector3[] direction = { new Vector3(0, 1, 0), new Vector3(0, -1, 0), new Vector3(1, 0, 0), new Vector3(-1, 0, 0)}; //Holds directions

    Coroutine coroutine; //Holds coroutine
    bool first = true; //Holds if restarted

    Sprite down; //Holds moving down sprite
    public Sprite up; //Holds moving up sprite
    public Sprite horiz; //Holds moving horiz. sprite

    public SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
        //Gets player
        player = GameObject.Find("Player");

        //Gets and seperates movepoint
        movePoint = transform.GetChild(0);
        movePoint.parent = null;

        //sr = gameObject.GetComponent<SpriteRenderer>();

        //Gets down sprite
        down = sr.sprite;

        //Starts movement
        coroutine = StartCoroutine(customPathfinder());
    }

    private void Update()
    {
        //Restarts once if pulling 
        if (pulled)
        {
            if (first)
            {
                first = false;
                StopCoroutine(coroutine);
                coroutine = StartCoroutine(customPathfinder());
            }
        }
        else
        {
            first = true;
        }

        
    }

    private IEnumerator customPathfinder()
    {
        //Forever
        while (true)
        {
            //Move enemy to movepoint (Faster if pulling)
            if (!pulled)
            {
                transform.position = Vector3.MoveTowards(transform.position, movePoint.position, moveSpeed * Time.deltaTime);
            }
            else
            {
                transform.position = Vector3.MoveTowards(transform.position, movePoint.position, (moveSpeed * 2) * Time.deltaTime);
            }

            //Makes sure enemy has caught up to movepoint before moving
            //And the they havent reached the player
            if (Vector3.Distance(transform.position, movePoint.position) == 0 &&
                transform.position != player.transform.position)
            {
                //Wait between jumps
                if (!pulled)
                {
                    yield return new WaitForSeconds(1);
                }

                //Get x and y differences to player
                float yDif = player.transform.position.y - transform.position.y;
                float xDif = player.transform.position.x - transform.position.x;

                //Holds which directions are good
                bool[] possible = { true, true, true, true };

                //Checks each dirrections for being alread done or the wrong way
                if (yDif < 0 || Mathf.Abs(yDif) < 1)
                {
                    possible[0] = false;
                }
                if ( yDif > 0 || Mathf.Abs(yDif) < 1)
                {
                    possible[1] = false;
                }
                if ( xDif < 0 || Mathf.Abs(xDif) < 1)
                {
                    possible[2] = false;
                }
                if ( xDif > 0 || Mathf.Abs(xDif) < 1)
                {
                    possible[3] = false;
                }

                int best = -1; //Holds best direction
                float distance = 0; //Holds best direction's distance

                //Finds best direction
                for (int i = 0; i < 4; i++)
                {
                    //Checks if possible
                    if (possible[i])
                    {
                        //Checks if x or y
                        if (direction[i].x != 0)
                        {
                            //Checks if father away from current distance
                            if(Mathf.Abs(xDif) > Mathf.Abs(distance))
                            {
                                //sets as new best
                                best = i;
                                distance = xDif;
                            }
                        }
                        else
                        {
                            //Checks if father away from current distance
                            if (Mathf.Abs(yDif) > Mathf.Abs(distance))
                            {
                                //sets as new best
                                best = i;
                                distance = yDif;
                            }
                        }
                    }
                }

                //Starts move with best direction
                move(direction[best]);
            }

            //Wait
            yield return new WaitForFixedUpdate();
        }
    }

    //Moves enemies's movepoint
    private void move(Vector3 movement)
    {
        //Check stopper for colliders
        if (!Physics2D.OverlapCircle(movePoint.position + movement, .2f, stoppers))
        {
            //Move movepoint
            movePoint.position += movement;

            //Check if x, up, or down
            if (movement.y > 0)
            {
                //Swap sprite
                sr.sprite = up;
            }
            else if (movement.y < 0)
            {
                //Swap sprite
                sr.sprite = down;
            }
            else
            {
                //Swap sprite
                sr.sprite = horiz;

                //Check which x
                if (movement.x == 1)
                {
                    sr.flipX = true;
                }
                else
                {
                    sr.flipX = false;
                }

                if (horizFlip)
                {
                    sr.flipX = !sr.flipX;
                }
            }
        }
    }
}
