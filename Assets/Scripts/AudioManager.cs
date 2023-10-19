using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public GameObject secondWelcome;
    public GameObject firstWelcome;

    void Start()
    {
        firstWelcome.SetActive(true);
        secondWelcome.SetActive(false);
        StartCoroutine(VODelay());
    }

    IEnumerator VODelay()
    {
        yield return new WaitForSeconds(10f);

        firstWelcome.SetActive(false);
        secondWelcome.SetActive(true);
    }
}
