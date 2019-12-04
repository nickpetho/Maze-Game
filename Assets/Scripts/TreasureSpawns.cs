using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureSpawns : MonoBehaviour
{
    public GameObject treasurePrefab;

    public Vector3[] positionArray = new[] {
        new Vector3(-35.5f, 0f, -2.5f),
        new Vector3(-25f, 0f, -2.5f),
        new Vector3(-20f, 0f, -13f),
        new Vector3(-5f, 0f, -18f),
        new Vector3(35f, 0f, -3f),
        new Vector3(35f, 0f, 2f),
        new Vector3(15f, 0f, 17f),
        new Vector3(-25f, 0f, 17f),
        new Vector3(-20f, 0f, 7f),
        new Vector3(5f, 0f, 12f)
    };

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnTreasure() {
        Vector3 spawnPos = new Vector3(0,0,0);
        Instantiate(treasurePrefab, spawnPos, treasurePrefab.transform.rotation);
    }
}
