using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceTransition : Transition
{
    [SerializeField] private float _transitionRange;
    [SerializeField] private float _rangespread;

    private void Start()
    {
        _transitionRange += Random.Range(-_rangespread, _rangespread);
    }

    private void Update()
    {
        if(Vector2.Distance(transform.position, Target.transform.position) < _transitionRange)
        {
            NeedTransit = true;
        }
    }
}
