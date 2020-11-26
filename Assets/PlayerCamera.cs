using UnityEngine;


public class PlayerCamera : MonoBehaviour {

    public Transform target;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;
    public FixedJoystick cameraStick;

    protected float cameraAngleSpeed = 2f;
    
    

	void Update () {
		float verticalMovement = cameraStick.input.y * cameraAngleSpeed;
		float horizontalMovement = cameraStick.input.x * cameraAngleSpeed;
		Camera.main.transform.Rotate (-verticalMovement, horizontalMovement, 0);

		Vector3 desiredPosition = target.position + offset;
    	Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
    	transform.position = smoothedPosition;
	}

	public void zoomCamera() {
		offset.x = 0;
		offset.y = 0;
		offset.z = 0;
		Debug.Log("zoom called!");
	}

	public void farCamera() {
		offset.x = 0;
		offset.y = 1;
		offset.z = 1;
		Debug.Log("far called!");
	}
}