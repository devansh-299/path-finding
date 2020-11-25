using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BakeMeshAction : MonoBehaviour {
    
	private NavMeshBaker baker;

	public void Start() {
		baker = gameObject.GetComponent<NavMeshBaker>();
    }

    public void bakeMesh() {
		baker.bakeMesh();
    }
}
