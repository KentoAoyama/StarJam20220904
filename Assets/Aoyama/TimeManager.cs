using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeManager : MonoBehaviour
{
    [SerializeField] Text _timerText;
    [SerializeField] Text _countDownText;
    [SerializeField] float _endTime;
    [SerializeField] string _resultSceneName;

    float _countDown = 3.5f;
    float _timer;

    bool _isGame;


    void Awake()
    {
        _timer = _endTime;
    }


    void FixedUpdate()
    {
        TextChange();
        GameStateChange();
    }


    void TextChange()
    {
        if (!_isGame)
        {
            _countDown -= Time.deltaTime;

            _countDownText.text = Mathf.Floor(_countDown).ToString();
        }
        else
        {
            _timer -= Time.deltaTime;

            _timerText.text = _timer.ToString("F2");
        }
    }


    void GameStateChange()
    {
        if (_countDown < 1)
        {
            _countDownText.text = "";
            _isGame = true;
        }

        if (_timer <= 0)
        {
            _timerText.text = "0000";
            StartCoroutine(GameOver());
        }
    }


    IEnumerator GameOver()
    {
        _countDownText.text = "Finish";
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(_resultSceneName);
    }
}
