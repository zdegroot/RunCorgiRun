using UnityEngine;

public class Game : MonoBehaviour
{
    public GameTimer GameTimer;
    public UI UI;

    public void Start()
    {
        UI.HideGameOverScreen();
    }

    public void Update()
    {
        UI.ShowTime();
    }
    
    public void OnStartButtonClicked()
    {
        GameTimer.StartTimer(GameParameters.GameDurationInSeconds, OnTimerFinished);
        UI.HideStartScreen();
    }

    public void OnTimerFinished()
    {
        UI.ShowGameOverScreen();
    }
}
