using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "TreasureCounter")]
public class TreasureData : ScriptableObject
{
    //Set default treasure amount
    int treasureAmount = 5;

    //Decrement the treasure count by 1
    public void decrementCount()
    {
        treasureAmount--;
    }

    //Gets the current treasure count
    public int GetCount()
    {
        return treasureAmount;
    }

    //Resets the treasure count to 5 each start
    public void ResetCount()
    {
        treasureAmount = 5;
    }
}
