using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResultPresenter : MonoBehaviour
{
    public void GoToTitle()
    {
            SceneManager.LoadScene("TitleScene");
    }
}
