using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Counter : MonoBehaviour
{
    private float _delay = 0.5f;
    private int _count;

    private bool _isActive = false;

    private Coroutine _countRoutine;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && _countRoutine == null)
        {
            StartRoutine();
        }
        else if(Input.GetMouseButtonDown(0))
        {
            Stop();
        }
    }

    private void StartRoutine()
    {      
        _isActive = true;
        _countRoutine = StartCoroutine(Count(_delay));
    }

    private void Stop()
    {
        if (_countRoutine != null)
        {
            StopCoroutine(_countRoutine);
            _countRoutine = null;
            _isActive = false;
        }
    }

    private IEnumerator Count(float delay)
    {
        var wait = new WaitForSeconds(delay);

        while (_isActive)
        {
            _count++;
            DisplayCounter();

            yield return wait;
        }
    }

    private void DisplayCounter()
    {
        Debug.Log(_count);
    }
}
