using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Bumper : MonoBehaviour{
    private Renderer ren;
    //private float time;

    AudioSource Bumper_sound;

    void Start()
    {
        //we get the Render Componnent and save it in ren
        ren = GetComponent<Renderer>();
        Bumper_sound = GetComponent<AudioSource>();
        //time = 0;
    }

    
    void Update(){
        
    }

    public void Bump() {
        //plays the bumper sound
        print("impact");
        Bumper_sound.Play(0);
    }
}
