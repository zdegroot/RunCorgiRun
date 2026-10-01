using System.Collections;
using UnityEngine;

public class BonePlacer : TimedObjectPlacer
{
    public void Start()
    {
        MinimumSecondsToWait = GameParameters.BoneMinimumSecondsToWait;
        MaximumSecondsToWait =  GameParameters.BoneMaximumSecondsToWait;
    }
}
