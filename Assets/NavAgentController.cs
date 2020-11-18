using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;

public class NavAgentController : MonoBehaviour {
    
    public Camera mCamera;
    public NavMeshAgent player;

    // Update is called once per frame
    void Update() {
    	/*
			0 -> for Left Mouse button
			1 -> for Right Mouse button 
    	*/
        if (Input.GetMouseButtonDown(0)) {
        	// to make player react to mouse clicks
        	Ray ray = mCamera.ScreenPointToRay(Input.mousePosition);
        	RaycastHit hit;

        	if(Physics.Raycast(ray, out hit) && !EventSystem.current.IsPointerOverGameObject()) {
        		// code to move the agent
        		Debug.Log("Valid");
        		player.SetDestination(hit.point);
        	}
        }
    }
}
