using UnityEngine;

public class PoopPlacer : MonoBehaviour
{
    public Sounds Sounds;
    public GameObject PoopPrefab;
    
    public void Place(Vector3 position)
    {
        Instantiate(PoopPrefab, position, Quaternion.identity);
        Sounds.PlayPoopSound();
    }
}
