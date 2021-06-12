using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnetPull : MonoBehaviour
{
    [HideInInspector]
    public static bool pullingN = false; //Holds if pulling north
    [HideInInspector]
    public static bool pullingS = false; //Holds if pulling south

    // Start is called before the first frame update
    void Start()
    {
        //Resets staic varibles
        pullingN = false;
        pullingS = false;
    }

    // Update is called once per frame
    void Update()
    {
        //checks for Nough or South pull keys
        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.Mouse0))
        {
            //Toggle pulls
            pullingN = true;
            pullingS = false;
        }
        else if (Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.Mouse1))
        {
            //Toggle pulls
            pullingN = false;
            pullingS = true;
        }
        else //Resets if off
        {
            pullingN = false;
            pullingS = false;
        }             
    }
}
