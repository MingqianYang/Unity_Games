using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public AudioSource source0;
    public AudioSource source1;

    // Start is called before the first frame update
    void Start()
    {
        AudioSource[] sources = GetComponents<AudioSource>();
        source0 = sources[0];
        source1 = sources[1];
        source1.loop = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayStopRollingClip()
    {
       
        source1.Play();
         
    }

    public void PlayRollingClip()
    {
        source0.Play();
    }
}
