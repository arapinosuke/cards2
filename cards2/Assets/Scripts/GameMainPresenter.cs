using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMainPresenter : MonoBehaviour
{
    public HighAndLowSequence m_highAndLowSequence;
   
    public void GoToResult()
    {
        SceneManager.LoadScene("ResultScene");
    }
}
