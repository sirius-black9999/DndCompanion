using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoiceMod : MonoBehaviour
{
    private AudioClip baseVoice;
    public AudioSource src1;
    public AudioSource src2;
    public AudioSource src3;

    // Start is called before the first frame update
    void Start()
    {
        baseVoice = Microphone.Start(Microphone.devices[0], true, 1, 44100);
        src1.Play();
        src2.Play();
        src3.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
