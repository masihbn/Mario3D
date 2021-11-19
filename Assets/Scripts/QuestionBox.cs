using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionBox : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player") &&
            collision.gameObject.transform.position.y < transform.position.y)
        {
            transform.GetChild(0).gameObject.SetActive(false);
            transform.GetChild(1).gameObject.SetActive(true);
            transform.GetChild(2).gameObject.SetActive(true);

            GetComponent<QuestionBox>().enabled = false;
        }

    }
}
