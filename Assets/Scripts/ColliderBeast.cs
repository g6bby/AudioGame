using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderBeast : MonoBehaviour
{
    public GameObject beastAudio;

    void Start()
    {
        beastAudio.SetActive(false);
    }

void OnTriggerEnter(Collider other)
{
    if (other.gameObject.CompareTag("Player"))
    {
        beastAudio.SetActive(true);
    }
}
}
