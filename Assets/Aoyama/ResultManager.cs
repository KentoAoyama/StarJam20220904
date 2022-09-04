using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultManager : MonoBehaviour
{
    [SerializeField] Text _scoreText;
    [SerializeField] Text _score;


    void Start()
    {
        _score.text = ScoreManager._score.ToString("D6");
    }
}
