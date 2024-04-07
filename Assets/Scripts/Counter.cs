using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Counter : MonoBehaviour
{
    private int _iterationsCount = 10;
    private float _delay = 0.5f;
    private int _count;

    private void Start()
    {
        StartCoroutine(Count(_delay));
    }

    private IEnumerator Count(float delay)
    {
        var wait = new WaitForSeconds(delay);

        for (int i = 0; i < _iterationsCount; i++)
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
