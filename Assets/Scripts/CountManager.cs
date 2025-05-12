using System.Collections;
using UnityEngine;

public class CountManager : MonoBehaviour
{
    [SerializeField] private Counter _counter;
    [SerializeField] private CounterViewer _viewer;

    private Coroutine _coroutine;
    private float _delay = 0.5f;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) & _coroutine == null)
        {
            _coroutine = StartCoroutine(IncreaseCounter());
        }
        else if (Input.GetMouseButtonDown(0) & _coroutine != null)
        {
            StopCoroutine(_coroutine);
            _coroutine = null;
        }
    }

    private IEnumerator IncreaseCounter()
    {
        bool isActiveCycle = true;

        while(isActiveCycle)
        {
            _counter.IncreaseValue();
            var wait = new WaitForSecondsRealtime(_delay);
            yield return wait;
        }
    }
}
