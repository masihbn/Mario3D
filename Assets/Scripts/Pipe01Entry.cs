using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe01Entry : MonoBehaviour
{
    public bool stoodOn = false;
    public GameObject player, fadeScreen;
    public Camera mainCamera;
    public EventSystemCustom eventSystem;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && stoodOn && player.transform.position.y > transform.position.y)
        {
            StartCoroutine(EnterPipe(this));
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        stoodOn = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        stoodOn = false;
    }

    IEnumerator EnterPipe(Pipe01Entry gameObject)
    {
        eventSystem.OnEnterPipeSound.Invoke();
        GetComponent<Animator>().enabled = true;
        yield return new WaitForSeconds(1.9f);
        GetComponent<Animator>().enabled = false;

        fadeScreen.SetActive(true);
        yield return new WaitForSeconds(0.6f);

        gameObject.player.transform.position = new Vector3(0, 0, 0);
        fadeScreen.SetActive(false);
    }
}
