using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomController : MonoBehaviour
{
    float leftPoint = 5.5f,
            rightPoint = 18.5f;
    bool shouldGoRight = true;

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        if (shouldGoRight)
        {
            transform.Translate(Vector3.right * 0.2f, Space.World);

            if (transform.position.x > leftPoint)
                shouldGoRight = false;
        }

        else
        {
            transform.Translate(Vector3.right * -0.2f, Space.World);

            if (transform.position.x < rightPoint)
                shouldGoRight = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && 
            other.gameObject.transform.position.y > transform.position.y)
            Destroy(gameObject);
    }
}
