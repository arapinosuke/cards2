using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJudge : MonoBehaviour
{
    public bool High = false;

    public bool Judge = false;

    public void HighJudge()
    {
        Judge = true;
        High = true;
    }

    public void LowJudge()
    {
        Judge = true;
        High = false;
    }
}
