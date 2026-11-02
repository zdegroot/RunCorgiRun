using UnityEngine;

public class Game : MonoBehaviour
{
    public GameTimer GameTimer;
    public UI UI;
    public BonePlacer BonePlacer;
    public BeerPlacer BeerPlacer;
    public MoonshinePlacer MoonshinePlacer;
    public PillPlacer PillPlacer;
    public Corgi Corgi;
    public Music Music;
    public Sounds Sounds;

    public void Start()
    {
        UI.HideGameOverScreen();
        Music.PlayMenuMusic();
    }

    public void Update()
    {
        UI.ShowTime();
    }
    
    public void OnStartButtonClicked()
    {
        InitializeGame();
        Sounds.PlayPoopSound();
    }

    public void OnPlayAgainButtonClicked()
    {
        InitializeGame();
        UI.HideGameOverScreen();
        Sounds.PlayPoopSound();
    }

    private void StartPlacers()
    {
        BonePlacer.StartPlacing();
        BeerPlacer.StartPlacing();
        MoonshinePlacer.StartPlacing();
        PillPlacer.StartPlacing();
    }

    public void StopPlacers()
    {
        BonePlacer.StopPlacing();
        BeerPlacer.StopPlacing();
        MoonshinePlacer.StopPlacing();
        PillPlacer.StopPlacing();
    }

    public void OnTimerFinished()
    {
        UI.ShowGameOverScreen();
        StopPlacers();
        Music.PlayMenuMusic();
    }

    public void InitializeGame()
    {
        GameTimer.StartTimer(GameParameters.GameDurationInSeconds, OnTimerFinished);
        UI.HideStartScreen();
        StartPlacers();
        Corgi.Reset();
        ScoreKeeper.ResetScore();
        UI.SetScoreText(ScoreKeeper.GetScore());
        Music.PlayGameMusic();
    }
}
