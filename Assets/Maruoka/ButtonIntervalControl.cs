using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonIntervalControl : MonoBehaviour
{
    [Header("�C���^�[�o���̍ő�l�ƍŏ��l"), SerializeField] RandomMinAndMaxValue _randomValue;
    float _interval = 0f;
    [Header("�m�F�p : OnOff���Ǘ�����l"), SerializeField] public bool _activeController;
    [Header("�\������"), SerializeField] float _drawTime = 2f;
    float _timer;
    bool _isCoroutineNow = false;

    Button _buttonComponent;
    Image _imageComponent;

    void Start()
    {
        _buttonComponent = GetComponent<Button>();
        _imageComponent = GetComponent<Image>();
    }

    void Update()
    {
        if (_timer < _drawTime)
        {
            _timer += Time.deltaTime;
        }
        else if(!_isCoroutineNow)
        {
            Set_Interval();
            StartCoroutine(WaitInterval());
        }
    }

    void Set_Interval()
    {
        _interval = Random.Range(_randomValue._minValue, _randomValue._maxValue);
    }

    IEnumerator WaitInterval()
    {
        _isCoroutineNow = true;
        _buttonComponent.enabled = false;
        _imageComponent.enabled = false;
        yield return new WaitForSeconds(_interval);
        _isCoroutineNow = false;
        _buttonComponent.enabled = true;
        _imageComponent.enabled = true;
        _timer = 0f;
    }
}

[System.Serializable]
public struct RandomMinAndMaxValue
{
    public float _minValue;
    public float _maxValue;
}
