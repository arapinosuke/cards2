using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMainPresenter : MonoBehaviour
{
    public HighAndLowSequence m_highAndLowSequence;
    private void Update()
    {
        if(m_highAndLowSequence.)
        {
            GoToResult();
        }
    }

    private void GoToResult()
    {
        SceneManager.LoadScene("ResultScene");
    }
}
