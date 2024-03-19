using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//we put this here in case we forget to add a rigidbody to the ball
[RequireComponent(typeof(Rigidbody))]

public class Ball : MonoBehaviour {
        private Rigidbody rb;
        public float launchforce;
    
    void Start(){
        rb = GetComponent<Rigidbody>();
        
    }
    public void Launch() {
        
        rb.AddForce(Vector3.forward * launchforce, ForceMode.Impulse);
    }

    
    void Update()
    {
        
    }
}
