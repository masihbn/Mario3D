using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManger : MonoBehaviour
{
    public EventSystemCustom eventSystem;
    public Text coinCounterText;
    public PlayerController mainCharacter;

    // Start is called before the first frame update
    void Start()
    {
        eventSystem.OnNearCoin.AddListener(UpdateKeyText);
    }

    private void UpdateKeyText()
    {
        coinCounterText.text = "Coins: " + mainCharacter.collectedCoins.ToString();
    }

}
