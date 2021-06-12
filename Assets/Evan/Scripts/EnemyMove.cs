using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{

    float moveSpeed = 1;
    Transform movePoint;
    GameObject player;
    Vector3[] direction = { new Vector3(0, 1, 0), new Vector3(0, -1, 0), new Vector3(1, 0, 0), new Vector3(-1, 0, 0)};

    public LayerMask stoppers;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");

        movePoint = transform.GetChild(0);
        movePoint.parent = null;

        StartCoroutine(customPathfinder());
    }

    private IEnumerator customPathfinder()
    {
        while (true)
        {
            //Move enemy to movepoint
            transform.position = Vector3.MoveTowards(transform.position, movePoint.position, moveSpeed * Time.deltaTime);

            //Makes sure enemy has caught up to movepoint before moving
            if (Vector3.Distance(transform.position, movePoint.position) == 0)
            {

                yield return new WaitForSeconds(2);

                float yDif = player.transform.position.y - transform.position.y;
                float xDif = player.transform.position.x - transform.position.x;

                bool[] possible = { true, true, true, true };

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

                int best = -1;
                float distance = 0;


                for (int i = 0; i < 4; i++)
                {
                    if (possible[i])
                    {
                        if (direction[i].x != 0)
                        {
                            if(Mathf.Abs(xDif) > Mathf.Abs(distance))
                            {
                                best = i;
                                distance = xDif;
                            }
                        }
                        else
                        {
                            if (Mathf.Abs(yDif) > Mathf.Abs(distance))
                            {
                                best = i;
                                distance = yDif;
                            }
                        }
                    }
                }

                move(direction[best]);
            }

            yield return new WaitForFixedUpdate();
        }
    }

    private void move(Vector3 movement)
    {
        //Check stopper for colliders
        if (!Physics2D.OverlapCircle(movePoint.position + movement, .2f, stoppers))
        {
            //Move movepoint
            movePoint.position += movement;
        }
    }
}
