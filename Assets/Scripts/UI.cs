using TMPro;
using UnityEngine;

public class UI : MonoBehaviour
{
    public TMP_Text ScoreText;
    
    public void SetScoreText(int score)
    {
        ScoreText.text = "Score: " + score;
    }
}
