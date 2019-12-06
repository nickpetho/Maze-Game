using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "XRayActivator")]

public class XRayData : ScriptableObject
{
    //Set default powerup amount
    int xrayAmount = 1;

    //Decrement the powerup count by 1
    public void decrementCount()
    {
        xrayAmount--;
    }

    //Gets the current powerup count
    public int GetCount()
    {
        return xrayAmount;
    }

    //Resets the powerup count to 1 each start
    public void ResetCount()
    {
        xrayAmount = 1;
    }
}
