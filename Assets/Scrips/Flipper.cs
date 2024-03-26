using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flipper : MonoBehaviour{
    private Rigidbody rb;
    public float force;
    AudioSource Flipper_Sound;

    //gets the ridigbody component of rb
    void Start(){
        rb = GetComponent<Rigidbody>();
        Flipper_Sound = GetComponent<AudioSource>();
    }

    //adds force to the flippert
    public void Flip(){
        rb.AddForce(Vector3.forward * force, ForceMode.Impulse);

        if (!Flipper_Sound.isPlaying)
        {
            Flipper_Sound.Play();
        }
        
    }
}
