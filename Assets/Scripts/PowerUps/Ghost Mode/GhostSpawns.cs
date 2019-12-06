using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostSpawns : MonoBehaviour
{
    public GameObject GhostPrefab;
    public int spawnAmount = 1;
    public GhostData g;

    public Vector3[] positionArray;

    // Start is called before the first frame update
    void Start()
    {
        List<int> samples = SampleSpawns(spawnAmount);

        for (int i = 0; i < spawnAmount; i++)
        {
            Vector3 spawnPos = positionArray[samples[i]];
            Instantiate(GhostPrefab, spawnPos, GhostPrefab.transform.rotation);
            //Debug.Log(samples[i]);
        }

        g.ResetCount();
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
