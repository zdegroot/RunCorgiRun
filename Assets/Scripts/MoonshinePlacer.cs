using UnityEngine;

public class MoonshinePlacer : TimedObjectPlacer
{
    public void Start()
    {
        MinimumSecondsToWait = GameParameters.MoonshineMinimumSecondsToWait;
        MaximumSecondsToWait =  GameParameters.MoonshineMaximumSecondsToWait;
    }

    public override void Place()
    {
        Instantiate(TimedObjectPrefab, SpawnTools.RandomTopOfScreenLocationWorldSpace(), Quaternion.identity);
    }
}
