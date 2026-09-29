using System.Collections;
using UnityEngine;

public class BeerPlacer : MonoBehaviour
{
    public GameObject BeerPrefab;

    public void Update()
    {
        StartCoroutine(CountdownUntilCreation());
    }
    
    IEnumerator CountdownUntilCreation()
    {
        yield return new WaitForSeconds(2f);
        Place();
    }
    
    public void Place()
    {
        Instantiate(BeerPrefab, SpawnTools.RandomLocationWorldSpace(), Quaternion.identity);
    }
}
