using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultManager : MonoBehaviour
{
    [SerializeField] Text _scoreText;
    [SerializeField] GameObject _scoreTextUI;


    void Start()
    {
        StartCoroutine(Score());
    }


    IEnumerator Score()
    {
        _scoreText.text = ScoreManager._score.ToString("D5");
        _scoreTextUI.SetActive(false);
        yield return new WaitForSeconds(1);
        _scoreTextUI.SetActive(true);
    }
}
