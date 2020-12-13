using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HighAndLowSequence : MonoBehaviour
{
    private enum GameSequece
    {
        Invalide,
        Init,
        Start,
        Deal,
        PlayerJudge,
        show,
        Result
    }

    private GameSequece gameSequece = GameSequece.Invalide;

    public Dealer dealer;

    public PlayerCard playerCard;

    public CPUCard cpuCard;

    public PlayerJudge playerJudge;

    public GameJudge gameJudge;

    public ScoreViewer scoreViewer;

    public float waitTime = 1f;

    void Update()
    {
        switch (gameSequece)
        {
            case GameSequece.Invalide:

                gameSequece = GameSequece.Init;
                break;

            case GameSequece.Init:

                playerCard.SetPlayerDeck();
                cpuCard.SetCPUDeck();
                gameSequece = GameSequece.Deal;
                break;

            case GameSequece.Start:

                gameJudge.GameJudgetextInit();

                gameSequece = GameSequece.Deal;
                break;

            case GameSequece.Deal:

                playerCard.SetPlayerCard();
                cpuCard.SetCPUCard();

                Debug.Log(playerCard.playerCard.Number);
                Debug.Log(cpuCard.cpuCard.Number);
                gameSequece = GameSequece.PlayerJudge;
                break;
            case GameSequece.PlayerJudge:

                if (playerJudge.Judge)
                {
                    gameSequece = GameSequece.show;
                }
                break;

            case GameSequece.show:

                cpuCard.ShowCPUCard();

                bool isWin = false;

                if (playerJudge.High)
                {
                    if (playerCard.playerCard.Number > cpuCard.cpuCard.Number)
                    {
                        isWin = true;
                    }
                }
                else
                {
                    if (playerCard.playerCard.Number < cpuCard.cpuCard.Number)
                    {
                        isWin = true;
                    }
                }

                gameJudge.GameJudgeTextView(isWin);
                waitTime -= Time.deltaTime;
                if (waitTime < 0f)
                {
                    playerJudge.Judge = false;
                    if(dealer.GameEnd(playerCard.GetPlayerDeck()))
                    {
                        gameSequece = GameSequece.Result;
                    }
                    else
                    {
                        gameSequece = GameSequece.Start;
                    }
                    gameSequece = GameSequece.Start;
                    scoreViewer.AddscoreViewer(isWin);
                    waitTime = 1f;
                }
                break;

            case GameSequece.Result:
              
                bool isResultWin = false;

                if (scoreViewer.playerScore>scoreViewer.cpuScore)
                {
                    isResultWin = true;
                }
                gameJudge.GameResultTextView(isResultWin);
                break;
        }
    }
}
   
