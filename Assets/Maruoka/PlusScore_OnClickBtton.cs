using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlusScore_OnClickBtton : MonoBehaviour
{
    ButtonIntervalControl _buttonIntervalControl;
    void Start()
    {
        _buttonIntervalControl = GetComponent<ButtonIntervalControl>();
    }
    public void OnClickButton()
    {
        ScoreManager.AddScore();
        _buttonIntervalControl._timer = _buttonIntervalControl._drawTime;
    }
}
