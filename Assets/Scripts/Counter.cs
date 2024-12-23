using System.Collections;
using UnityEngine;
using System;

public class Counter : MonoBehaviour
{
    private float _elapsedTime;
    private float _delay = 0.5f;
    private float _incrementStep = 1f;
    private bool _isRunning = false;
    private Coroutine _countingCoroutine;
    private WaitForSeconds _wait;

    public event Action<float> CounterUpdated;

    public void ToggleCounter()
    {
        if (!_isRunning)
        {
            StartCounter();
        }
        else
        {
            StopCounter();
        }
    }

    private void Start()
    {
        _wait = new WaitForSeconds(_delay);
    }

    private void StartCounter()
    {
        _isRunning = true;

        _countingCoroutine = StartCoroutine(Counting());
    }

    private void StopCounter()
    {
        _isRunning = false;

        if (_countingCoroutine != null)
        {
            StopCoroutine(_countingCoroutine);
        }
    }

    private IEnumerator Counting()
    {
        while (_isRunning)
        {
            yield return _wait;

            _elapsedTime += _incrementStep;

            CounterUpdated?.Invoke(_elapsedTime);
        }
    }
}