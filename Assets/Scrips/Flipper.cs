using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flipper : MonoBehaviour{
    // Start is called before the first frame update

    private Rigidbody rb;
    public float force;
    
    void Start(){
        //gets the ridigbody component of rb
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    public void Flip()
    {
        //adds force to the flippert
        rb.AddForce(Vector3.forward * force, ForceMode.Impulse);
    }
}
