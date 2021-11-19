using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityStandardAssets.Characters.ThirdPerson;

public class PlayerController : MonoBehaviour
{
    public int collectedCoins = 0;
    public EventSystemCustom eventSystem;
    public bool isDead = false;
    public Text activateText;

    private void Start()
    {
        gameObject.GetComponent<ThirdPersonUserControl>().enabled = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
            collectCoin(other);

        if (other.CompareTag("DeathZone") ||
            other.CompareTag("DeathPoison") ||
            (other.CompareTag("Enemy") &&
            transform.position.y < other.transform.position.y))
            StartCoroutine(Die());

        if (other.gameObject.CompareTag("CastleDoor"))
            Debug.Log("Going to another world");

        if (other.gameObject.CompareTag("CastleDoor")) 
            SceneManager.LoadScene(4);
    }

    private void collectCoin(Collider other)
    {
        collectedCoins++;
        eventSystem.OnCoinCollectSound.Invoke();
        eventSystem.OnNearCoin.Invoke();
        Destroy(other.gameObject);
    }

    IEnumerator Die()
    {
        isDead = true;
        gameObject.GetComponent<ThirdPersonUserControl>().enabled = false;
        transform.localScale -= new Vector3(0, 0.9f, 0);
        eventSystem.OnDiedSound.Invoke();

        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(1);
    }
}
