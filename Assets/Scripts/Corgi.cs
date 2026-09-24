using UnityEngine;

public class Corgi : MonoBehaviour
{
    private SpriteRenderer corgiSpriteRenderer;

    public void Awake()
    {
        corgiSpriteRenderer = GetComponent<SpriteRenderer>();
    }
    
    public void Move(Vector2 direction)
    {
        FaceCorrectDirection(direction);
        
        Vector2 movement = direction * GameParameters.CorgiMoveSpeed * Time.deltaTime;
        corgiSpriteRenderer.transform.Translate(movement);

        corgiSpriteRenderer.transform.position = SpriteTools.ConstrainToScreen(corgiSpriteRenderer);
    }
    
    public void FaceCorrectDirection(Vector2 direction)
    {
        if (direction.x > 0)
        {
            corgiSpriteRenderer.flipX = false;
        }
        else if (direction.x < 0)
        {
            corgiSpriteRenderer.flipX = true;
        }
    }
}
