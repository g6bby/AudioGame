using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderBird : MonoBehaviour
{
    public GameObject birdAudio;

    void Start()
    {
        birdAudio.SetActive(false);
    }

void OnTriggerEnter(Collider other)
{
    if (other.gameObject.CompareTag("Player"))
    {
        birdAudio.SetActive(true);
    }
}
}
