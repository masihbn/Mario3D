using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public int collectedCoins = 0;
    public EventSystemCustom eventSystem;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            collectedCoins++;
            eventSystem.OnCoinCollectSound.Invoke();
            eventSystem.OnNearCoin.Invoke();
            Destroy(other.gameObject);
        }

        else if (other.CompareTag("DeathZone"))
        {
            StartCoroutine(Die());
        }
    }

    IEnumerator Die()
    {
        eventSystem.OnDiedSound.Invoke();
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(1);
    }
}
