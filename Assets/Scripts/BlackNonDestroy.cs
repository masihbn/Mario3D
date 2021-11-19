using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackNonDestroy : MonoBehaviour
{
    Vector3 initialPosition;

    void Start()
    {
        initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        transform.GetComponent<Collider>().isTrigger = false;
        if (other.gameObject.CompareTag("Player"))
        {
        }
            StartCoroutine(EnterPipe(this));
    }

    IEnumerator EnterPipe(BlackNonDestroy gameObject)
    {
        var moveVector = new Vector3(0, 0.2f, 0);
        transform.position = initialPosition + moveVector;
        yield return new WaitForSeconds(0.1f);
        transform.position = initialPosition;
    }
}
