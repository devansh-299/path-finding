using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCameraAction : MonoBehaviour {
    
    private PlayerCamera camera;

    public void Start() {
		camera = gameObject.GetComponent<PlayerCamera>();
    }

    public void zoomCameraButtonAction() {
    	camera.zoomCamera();
    }

    public void farCameraButtonAction() {
    	camera.farCamera();
    }

}
