using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarkerTo : MonoBehaviour
{
    public bool marker1;

    public bool isAudioPlaying;

    public AudioSource audioSource;

    public GameObject video;

    private void Start()
    {

    }

    private void Update()
    {
        if (marker1)
        {
            if (!audioSource.isPlaying)
            {
                audioSource.Play();
                Debug.Log("Audio Play");
            }
        }
        else if (!marker1)
        {
            if (audioSource.isPlaying)
            {
                audioSource.Stop(); // ¾ÈµÊ
            }
        }
    }

    public void OnMarker1()
    {
        marker1 = true;
    }

    public void OffMarker1()
    {
        marker1 = false;
    }


}
