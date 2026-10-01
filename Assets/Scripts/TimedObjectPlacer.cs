using System.Collections;
using UnityEngine;
using UnityEngine.Serialization;

public class TimedObjectPlacer : MonoBehaviour
{
    public GameObject TimedObjectPrefab;

    private bool isOkToCreate = true;

    public float MinimumSecondsToWait = 1f;
    public float MaximumSecondsToWait = 3f;

    public void Update()
    {
        if (isOkToCreate)
        {
            StartCoroutine(CountdownUntilCreation());
        }
    }
    
    IEnumerator CountdownUntilCreation()
    {
        isOkToCreate = false;
        float secondsToWait = Random.Range(MinimumSecondsToWait, MaximumSecondsToWait);
        yield return new WaitForSeconds(secondsToWait);
        Place();
        isOkToCreate = true;
    }
    
    public void Place()
    {
        Instantiate(TimedObjectPrefab, SpawnTools.RandomLocationWorldSpace(), Quaternion.identity);
    }
}
