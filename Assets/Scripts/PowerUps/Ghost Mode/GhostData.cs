using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "GhostActivator")]

public class GhostData : ScriptableObject
{
    //Set default powerup amount
    int ghostAmount = 1;

    //Decrement the powerup count by 1
    public void decrementCount()
    {
        ghostAmount--;
    }

    //Gets the current powerup count
    public int GetCount()
    {
        return ghostAmount;
    }

    //Resets the powerup count to 1 each start
    public void ResetCount()
    {
        ghostAmount = 1;
    }
}
