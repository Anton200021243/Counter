using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Counter : MonoBehaviour
{
    private float _delay = 0.5f;
    private int _count;
    private bool _isActive = false;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (_isActive == false)
            {
                _isActive = true;
                StartCoroutine(Count(_delay));
            }
            else
            {
                _isActive = false;
                StopCoroutine(Count(_delay));
            }
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
