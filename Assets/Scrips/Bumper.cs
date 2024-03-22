using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Bumper : MonoBehaviour{
    public Ball ball;
    AudioSource Bumper_sound;
    
    void Start(){
        Bumper_sound = GetComponent<AudioSource>();
    }

    //plays the bumper sound and is a section called when impact is made
    public void Bump() {
        //plays the bumper sound
    
        Bumper_sound.Play();
    }
}
