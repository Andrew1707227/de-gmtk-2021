using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBob : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.up * Mathf.Sin(Time.time) / 2500;
    }
}
