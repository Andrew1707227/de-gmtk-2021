using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputV2 : MonoBehaviour {
    PlayerControls controls;
    PlayerControls.DefaultActions device;

    public static bool magnetNeg;
    public static bool magnetPos;

    public static bool moveUp;
    public static bool moveDown;
    public static bool moveLeft;
    public static bool moveRight;

    public static bool anyKey;
    public static bool pause;

    void Awake() {
        controls = new PlayerControls();
        controls.Enable();
        device = controls.Default;

    }
    void Update() {
        moveUp = device.MoveUp.triggered;
        moveDown = device.MoveDown.triggered;
        moveLeft = device.MoveLeft.triggered;
        moveRight = device.MoveRight.triggered;

        magnetNeg = device.MagnetNeg.ReadValue<float>() > 0;
        magnetPos = device.MagnetPos.ReadValue<float>() > 0; //hold down

        anyKey = device.AnyKey.triggered;
        pause = device.Pause.triggered; //press once
    }
}
