using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour {
    
    public Camera mCamera;
    public NavMeshAgent player;

    // Update is called once per frame
    void Update() {
    	/*
			0 -> for Left Mouse button
			1 -> for Right Mouse button 
    	*/
        if (Input.GetMouseButtonDown(0)) {
        	Debug.Log("Mouse Clicked");
        	// to make player react to mouse clicks
        	Ray ray = mCamera.ScreenPointToRay(Input.mousePosition);
        	RaycastHit hit;

        	if(Physics.Raycast(ray, out hit)) {
        		// code to move the agent
        		Debug.Log("Valid");
        		player.SetDestination(hit.point);
        	}
        }
    }
}
