using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Target : MonoBehaviour {
    public Ball ball;
    AudioSource Target_sound;

    void Start() {
        Target_sound = GetComponent<AudioSource>();
    }

    //plays the Target sound and is a section called when impact is made
    public void Bump() {
        //plays the Target sound

        Target_sound.Play();
    }
}
