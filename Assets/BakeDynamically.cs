using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class BakeDynamically : MonoBehaviour {
    
    public NavMeshSurface navMeshSurface;

    /**
		In order to bake the mesh only once i.e. when starting the game,
		un-comment the below lines and comment out the `Update` method's body
    */

	/*
		void Start() {
			navMeshSurface.BuildNavMesh();
	        Debug.Log("Start Method: baked surface dynamically but only once");
		}
	*/

    // Update is called once per frame
    void Update() {
        navMeshSurface.BuildNavMesh();
        Debug.Log("Update Method: baked surface dynamically");
    }
}
