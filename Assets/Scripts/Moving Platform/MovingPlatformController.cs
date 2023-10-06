using UnityEngine;
using DG.Tweening;
using System;
using Unity.AI.Navigation;
using System.Collections;
using System.Collections.Generic;

public class MovingPlatformController : MonoBehaviour
{
    [SerializeField] private bool isRunning;
    [SerializeField] private NavMeshSurface _surface;

    private void Start()
    {
        isRunning = false;
    }

    private void Update()
    {
        if(EventService.Instance.InvokeHasSatisfiedAtomCondition() && !isRunning)
        {
            isRunning = true;
            StartCoroutine(Move(gameObject.transform));
        }
    }

    IEnumerator Move(Transform obj)
    {
        obj.DOMoveY(0f, 5f, false).SetEase(Ease.InOutSine);
        yield return new WaitForSeconds(5f);
        _surface.BuildNavMesh();
    }
}
