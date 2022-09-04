using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlusScore_OnClickBtton : MonoBehaviour
{
    public void OnClickButton()
    {
        ScoreManager.AddScore();
    }
}
