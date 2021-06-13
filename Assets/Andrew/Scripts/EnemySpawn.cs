using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour {

    public GameObject blue;
    public GameObject red;

    public float fireRate;

    public Vector2 min;
    public Vector2 max;

    void Start() {
        StartCoroutine(SpawnEnemies());
    }

    public IEnumerator SpawnEnemies() {
        Vector3 playerPos = GameObject.Find("Player").transform.position;
        Vector3 bluePos = playerPos;
        while (Vector3.Distance(playerPos,bluePos) < 2) {
            bluePos = new Vector3Int((int)Random.Range(min.x, max.x), (int)Random.Range(min.y, max.y), 0);
        }
        Vector3 redPos = playerPos;
        while (Vector3.Distance(playerPos, redPos) < 2) {
            redPos = new Vector3Int((int)Random.Range(min.x, max.x), (int)Random.Range(min.y, max.y), 0);
        }
        Instantiate(blue, bluePos, Quaternion.identity);
        Instantiate(red, redPos, Quaternion.identity);
        yield return new WaitForSeconds(fireRate);
        StartCoroutine(SpawnEnemies());
    }
}
