using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectIdCard : MonoBehaviour
{
    public AudioSource audio;

    private void Start()
    {
        audio = GetComponent<AudioSource>();

    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("trying to collect id cards" +collision.transform.tag);

        if (collision.transform.tag == "Player")
        {
           
            Debug.Log("collecting id cards"+collision.transform.tag);
            // audio.Play();
            gameObject.SetActive(false);

        }
    }
}
