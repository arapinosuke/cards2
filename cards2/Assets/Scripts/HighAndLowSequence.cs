using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighAndLowSequence : MonoBehaviour
{
   private enum GameSequece
    {
        Invalide,
        Init,
        Start,
        Deal,
        PlayerJudge,
        show
    }

    private GameSequece gameSequece = GameSequece.Invalide;

    public Dealer dealer;

    public PlayerCard playerCard;

    public CPUCard cpuCard;

    public PlayerJudge playerJudge;

    public bool GameOver = false;
   

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

                if (playerJudge.High)
                {
                    if (playerCard.playerCard.Number>cpuCard.cpuCard.Number)
                    {
                        Debug.Log("勝ち");
                    }
                    else
                    {
                        Debug.Log("負け");
                    }
                }
                else
                {
                    if (playerCard.playerCard.Number < cpuCard.cpuCard.Number)
                    {
                        GameOver = false;
                        Debug.Log("勝ち");
                    }
                    else
                    {
                        Debug.Log("負け");
                    }
                }
                playerJudge.Judge = false;
                gameSequece = GameSequece.Start;
                break;
        }
    }
}
