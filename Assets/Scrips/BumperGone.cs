using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperGone : MonoBehaviour{
    private List<MeshCollider> meshes;

    void Start(){
        meshes = new List<MeshCollider>(GetComponentsInChildren<MeshCollider>());
    }
    public void TurnOffMesh(){
        foreach(var mesh in meshes){
            mesh.enabled = false; 
        }
    }
    public void TurnOnMesh(){
        foreach (var mesh in meshes){
            mesh.enabled = true;
        }
    }
}
