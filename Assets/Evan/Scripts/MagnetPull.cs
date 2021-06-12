using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnetPull : MonoBehaviour
{
    [HideInInspector]
    public static bool pullingN = false; //Holds if pulling north
    [HideInInspector]
    public static bool pullingS = false; //Holds if pulling south

    public Sprite redBGround;
    public Sprite blueBGround;
    public Sprite purpleBGround;

    public AudioSource Asource;

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
            Score.currSprite = redBGround;
            if (!(Asource.volume == 1)) {
                Asource.pitch = .9f;
                Asource.time = 0;
                Asource.volume = 1;
            }
            pullingN = true;
            pullingS = false;
        }
        else if (Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.Mouse1))
        {
            //Toggle pulls
            Score.currSprite = blueBGround;
            if (!(Asource.volume == 1)) {
                Asource.pitch = 1f;
                Asource.time = 0;
                Asource.volume = 1;
            }
            pullingN = false;
            pullingS = true;
        }
        else //Resets if off
        {
            Score.currSprite = purpleBGround;
            Asource.volume = 0;
            pullingN = false;
            pullingS = false;
        }             
    }
}
