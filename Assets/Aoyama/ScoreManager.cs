using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    /// <summary>ゲーム内のスコアを表す</summary>
    public static int _score;
    static int _addScore = 100;
    [SerializeField] Text _scoreText;

    void Awake()
    {
        _score = 0;
    }

    
    void Update()
    {
        _scoreText.text = _score.ToString("D6");
    }


    public static void AddScore()
    {
        _score += _addScore;
    }
}
