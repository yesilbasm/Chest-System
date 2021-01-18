using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public static class EventManager
{
    public static UnityEvent OnGameStart = new UnityEvent();
    public static UnityEvent OnGameEnd = new UnityEvent();

    public static UnityEvent OnKeyPickUp = new UnityEvent();

    public static UnityEvent OnChestOpened = new UnityEvent();
    public static UnityEvent OnAllKeysUsed = new UnityEvent();
    public static UnityEvent OnKeyUsed = new UnityEvent();
    public static UnityEvent OnGetKeys = new UnityEvent();
}

