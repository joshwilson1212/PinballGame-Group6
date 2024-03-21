using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flipper : MonoBehaviour{
    // Start is called before the first frame update

    private Rigidbody rb;
    public float force;
    AudioSource Flipper_Sound;
    void Start(){
        //gets the ridigbody component of rb
        rb = GetComponent<Rigidbody>();
        Flipper_Sound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    public void Flip()
    {
        //adds force to the flippert
        rb.AddForce(Vector3.forward * force, ForceMode.Impulse);
        Flipper_Sound.Play();
    }
}
