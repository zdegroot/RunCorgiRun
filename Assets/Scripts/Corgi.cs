using System.Collections;
using UnityEditorInternal;
using UnityEngine;

public class Corgi : MonoBehaviour
{
    private SpriteRenderer corgiSpriteRenderer;
    private bool isDrunk = false;
    
    public Sprite DrunkSprite;
    public Sprite SoberSprite;
    

    public void Awake()
    {
        corgiSpriteRenderer = GetComponent<SpriteRenderer>();
    }
    
    public void Move(Vector2 direction)
    {
        direction = ApplyDrunkenness(direction);
        
        FaceCorrectDirection(direction);
        
        Vector2 movement = direction * GameParameters.CorgiMoveSpeed * Time.deltaTime;
        corgiSpriteRenderer.transform.Translate(movement);

        corgiSpriteRenderer.transform.position = SpriteTools.ConstrainToScreen(corgiSpriteRenderer);
    }

    private Vector2 ApplyDrunkenness(Vector2 direction)
    {
        if (isDrunk)
        {
            direction.x = direction.x * -1;
            direction.y = direction.y * -1;
        }

        return direction;
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Beer"))
        {
            Destroy(other.gameObject);
            GetDrunk();
        }
        if (other.gameObject.CompareTag("Bone"))
        {
            ScorePoint();
            Destroy(other.gameObject);
        }

        if (other.gameObject.CompareTag("Pill"))
        {
            SoberUp();
            Destroy(other.gameObject);
        }
    }

    private void ScorePoint()
    {
        print("goal");
    }

    private void GetDrunk()
    {
        isDrunk = true;
        ChangeToDrunkSprite();
        StartSoberingUp();
    }

    private void StartSoberingUp()
    {
        StartCoroutine(CountdownUntilSober());
    }
    
    IEnumerator CountdownUntilSober()
    {
        yield return new WaitForSeconds(GameParameters.CorgiDrunkSeconds);
        SoberUp();
    }

    private void SoberUp()
    {
        isDrunk = false;
        ChangeToSoberSprite();
    }

    private void ChangeToSoberSprite()
    {
        corgiSpriteRenderer.sprite = SoberSprite;
    }

    private void ChangeToDrunkSprite()
    {
        corgiSpriteRenderer.sprite = DrunkSprite;
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

    public Vector3 GetPosition()
    {
        return transform.position;
    }
}
