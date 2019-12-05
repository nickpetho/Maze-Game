using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawns : MonoBehaviour
{
    public GameObject enemyPrefab;
    public int spawnAmount = 3;

    public Vector3[] positionArray = new[] {
        new Vector3(-35f, 0f, 17f),
        new Vector3(35f, 0f, 17f),
        new Vector3(35f, 0f, -17f),
        new Vector3(-35f, 0f, -18f),
        new Vector3(-5f, 0f, 2f)
    };

    // Start is called before the first frame update
    void Start()
    {
        List<int> samples = SampleSpawns(spawnAmount);

        for (int i = 0; i < spawnAmount; i++)
        {
            Vector3 spawnPos = positionArray[samples[i]];
            Instantiate(enemyPrefab, spawnPos, enemyPrefab.transform.rotation);
            //Debug.Log(samples[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    List<int> SampleSpawns(int num)
    {
        HashSet<int> set = new HashSet<int>();
        ArrayList samples = new ArrayList();

        for (int i = 0; i < num; i++)
        {
            int sample;

            do
            {
                sample = Random.Range(0, positionArray.Length);
            } while (set.Contains(sample));

            set.Add(sample);
        }

        return new List<int>(set);
    }
}
