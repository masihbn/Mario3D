using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManger : MonoBehaviour
{
    public EventSystemCustom eventSystem;
    public Text coinCounterText, activateTextBox;
    public PlayerController mainCharacter;

    // Start is called before the first frame update
    void Start()
    {
        string activateText = "Press 'E' to activate";

        UnityEngine.Events.UnityAction UpdateKeyText = () => coinCounterText.text = "Coins: " + mainCharacter.collectedCoins.ToString();
        UnityEngine.Events.UnityAction ShowActivateText = () => activateTextBox.text = activateText;
        UnityEngine.Events.UnityAction HideActivateText = () => activateTextBox.text = "";

        eventSystem.OnNearCoin.AddListener(UpdateKeyText);
        eventSystem.OnNearUseableItemEnter.AddListener(ShowActivateText);
        eventSystem.OnNearUseableItemExit.AddListener(HideActivateText);
    }
}
