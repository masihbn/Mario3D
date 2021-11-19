using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public EventSystemCustom eventSystem;
    public AudioSource pipeEntry, coinCollect, growUp, die;

    // Start is called before the first frame update
    void Start()
    {
        UnityEngine.Events.UnityAction PlayCoinCollectSound = () => coinCollect.Play();
        UnityEngine.Events.UnityAction PlayPipeEntrySound = () => pipeEntry.Play();
        UnityEngine.Events.UnityAction PlayGrowUpSound = () => growUp.Play();
        UnityEngine.Events.UnityAction PlayDieSound = () => die.Play();
        
        eventSystem.OnCoinCollectSound.AddListener(PlayCoinCollectSound);
        eventSystem.OnEnterPipeSound.AddListener(PlayPipeEntrySound);
        eventSystem.OnGrowUpSound.AddListener(PlayGrowUpSound);
        eventSystem.OnDiedSound.AddListener(PlayDieSound);
    }
}
