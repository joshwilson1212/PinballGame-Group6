using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flipper : MonoBehaviour{
    // Start is called before the first frame update

    private Rigidbody rb;
    public float force;
    
    void Start(){
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    public void Flip()
    {
        
        rb.AddForce(Vector3.forward * force, ForceMode.Impulse);
    }
}
