using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreViewer : MonoBehaviour
{
    public Text PlayerScoreText;
    public Text CPUScoreText;
    public int playerScore = 0;
    public int cpuScore=0;

    public void ScoreTextInit()
    {
        PlayerScoreText.text = string.Empty;
        CPUScoreText.text = string.Empty;
    }

    public void AddscoreViewer(bool isWin)
    {
        if(isWin)
        {
            playerScore += 2;
            PlayerScoreText.text = $"{playerScore}";
        }
        else
        {
            cpuScore += 2;
            CPUScoreText.text = $"{cpuScore}";
        }
    }
}
