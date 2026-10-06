using UnityEngine;

public class WaterBowl : TimedObject
{
    public void Start()
    {
        secondsOnScreen = GameParameters.WaterBowlSecondsOnScreen;
        base.Start();
    }
}
