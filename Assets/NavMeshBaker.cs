using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshBaker : MonoBehaviour {
    // Start is called before the first frame update

	public NavMeshSurface[] navMeshSurfaces;

    public void bakeMesh() {

  //   	Debug.Log(navMeshSurfaces.Length);
		// Debug.Log("Baker method called");
    	
		// navMeshSurfaces[0].BuildNavMesh();	
    }

    void Start() {
    	navMeshSurfaces[0].BuildNavMesh();	
    }

    public void clearMesh() {
        // navMeshSurfaces[0].RemoveNavMeshData();
    }
}