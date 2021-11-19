using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedMushroomControl : MonoBehaviour
{
    public PlayerController player;
    public EventSystemCustom eventSystem;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            eventSystem.OnGrowUpSound.Invoke();
            player.transform.localScale += new Vector3(0.3f, 0.3f, 0.3f);
            Destroy(this.gameObject);
        }
    }
}
