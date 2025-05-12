using System;
using System.Collections;
using UnityEngine;

public class Counter : MonoBehaviour
{
    [SerializeField] private InputService _inputService;
    private float _count = 0;
    private Coroutine _coroutine;
    private float _delay = 0.5f;

    public event Action CountUpdated;

    public float Count => _count;

    private void OnEnable()
    {
        _inputService.CountChanged += IncreaseCount;
    }

    private void OnDisable()
    {
        _inputService.CountChanged -= IncreaseCount;
    }

    private void IncreaseCount()
    {
        if(_coroutine == null)
        {
            _coroutine = StartCoroutine(IncreaseAfterTime());
        }
        else
        {
            StopCoroutine(_coroutine);
            _coroutine = null;
        }
    }

    private IEnumerator IncreaseAfterTime()
    {
        var wait = new WaitForSecondsRealtime(_delay);

        while (enabled)
        {
            _count++;
            CountUpdated?.Invoke();
            yield return wait;
        }
    }
}
