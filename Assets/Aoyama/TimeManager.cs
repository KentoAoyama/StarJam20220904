using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    [SerializeField] Text _timerText;
    [SerializeField] Text _countDownText;
    [SerializeField] float _endTime;

    float _countDown;
    float _timer;

    bool _isGame;


    //void Awake()
    //{
    //    _countDown = 0;
    //    _timer = 0;
    //    _isGame = false;
    //}


    void Update()
    {
        TextChange();

    }


    void TextChange()
    {
        if (!_isGame)
        {
            _countDown += Time.deltaTime;

            _countDownText.text = Mathf.Floor(_countDown).ToString();
        }
        else
        {
            _timer += Time.deltaTime;

            _countDownText.text = "";
            _timerText.text = Mathf.Floor(_countDown).ToString();
        }
    }


    void GameOver()
    {
        if (_countDown < 0)
        {
            _isGame = true;
        }

        if (_timer > _endTime)
        {

        }
    }
}
