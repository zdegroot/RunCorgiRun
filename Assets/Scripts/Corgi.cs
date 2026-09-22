using UnityEngine;

public class Corgi : MonoBehaviour
{
    private SpriteRenderer corgiSpritRenderer;

    public void Awake()
    {
        corgiSpritRenderer = GetComponent<SpriteRenderer>();
    }
    
    public void Move(Vector2 direction)
    {
        corgiSpritRenderer.transform.Translate(direction);
    }
}
