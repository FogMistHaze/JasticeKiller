using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AnimCall : MonoBehaviour
{
    [SerializeField]
    UnityEvent callEvents = new UnityEvent();

    public void Call()
    {
        callEvents.Invoke();
    }
}

