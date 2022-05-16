using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSounds : MonoBehaviour
{
    [SerializeField]
    private AudioClip[] audioClips;

    private AudioSource audioSource;
    // Start is called before the first frame update
    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void step()
    {
        AudioClip clip = getRandom();
        audioSource.PlayOneShot(clip);
    }

    private void jump()
    {
        audioSource.PlayOneShot(audioClips[2]);
    }

    private AudioClip getRandom()
    {
        //return audioClips[Random.Range(0,audioClips.Length)];
        return audioClips[Random.Range(0,1)];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
