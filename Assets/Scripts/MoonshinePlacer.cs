using UnityEngine;

public class MoonshinePlacer : TimedObjectPlacer
{
    public Sounds Sounds;
    public void Start()
    {
        MinimumSecondsToWait = GameParameters.MoonshineMinimumSecondsToWait;
        MaximumSecondsToWait =  GameParameters.MoonshineMaximumSecondsToWait;
    }

    public override void Place()
    {
        Instantiate(TimedObjectPrefab, SpawnTools.RandomTopOfScreenLocationWorldSpace(), Quaternion.identity);
        Sounds.PlayFallingSound();
    }
}
