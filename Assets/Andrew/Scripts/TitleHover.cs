using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleHover : MonoBehaviour {

    void Start() {
        
    }

    void Update() {
        transform.position += Vector3.up * Mathf.Sin(Time.time) / 10;
    }
}
