using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    public AudioSource player;
    public AudioClip sound1, sound2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            player.clip = sound1;
            player.Play();
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            player.Stop();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            player.clip = sound2;
            player.Play();
        }
        if (Input.GetKeyUp(KeyCode.R))
        {
            player.Stop();
        }
    }
}
