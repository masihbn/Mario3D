using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventSystemCustom : MonoBehaviour
{
    public UnityEvent OnNearCoin, 
        OnCoinCollectSound, OnEnterPipeSound, OnGrowUpSound, OnDiedSound;

    // Start is called before the first frame update
    void Start()
    {
        OnNearCoin = new UnityEvent();
        OnEnterPipeSound= new UnityEvent();
        OnCoinCollectSound = new UnityEvent();
        OnGrowUpSound = new UnityEvent();
        OnDiedSound = new UnityEvent();
    }
}
