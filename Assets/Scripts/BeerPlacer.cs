using System.Collections;
using UnityEngine;

public class BeerPlacer : TimedObjectPlacer
{
    public void Start()
    {
        MinimumSecondsToWait = GameParameters.BeerMinimumSecondsToWait;
        MaximumSecondsToWait =  GameParameters.BeerMaximumSecondsToWait;
    }
}
