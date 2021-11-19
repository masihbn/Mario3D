using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level01Preload : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EnterPipe());
    }

    IEnumerator EnterPipe()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(3);
    }
}
