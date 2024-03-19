using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour{
    //name might be slightly messed up but its lowercase
    private Pinballinput input;
    public Ball ball;

    // Start is called before the first frame update
    void Start(){
        input = new Pinballinput();
        input.Enable();
        
    }

    // Update is called once per frame
    void Update(){
        if (input.Default.LaunchBall.WasReleasedThisFrame()){
            
            ball.Launch();
        }
    }
}
