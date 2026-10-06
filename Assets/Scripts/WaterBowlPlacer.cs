using UnityEngine;

public class WaterBowlPlacer : TimedObjectPlacer
{
    public void Start()
    {
        MinimumSecondsToWait = GameParameters.WaterBowlMinimumSecondsToWait;
        MaximumSecondsToWait =  GameParameters.WaterBowlMaximumSecondsToWait;
    }
}
