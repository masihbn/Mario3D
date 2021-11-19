using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public float distanceFromCharacter;
    public float cameraY;

    private void Start()
    {
        distanceFromCharacter = 8;
        cameraY = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if (!player.GetComponent<PlayerController>().isDead)
            transform.position = new Vector3(player.position.x, cameraY, player.position.z - distanceFromCharacter);
    }
}
