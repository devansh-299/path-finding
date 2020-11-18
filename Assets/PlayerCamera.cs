using UnityEngine;


public class PlayerCamera : MonoBehaviour {

    public Transform target;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;
    public FixedJoystick cameraStick;

    protected float cameraAngle;
    protected float cameraAngleSpeed = 2f;
    
	void Update () {
		float horizontalMovement = cameraStick.input.x * cameraAngleSpeed;
		float verticalMovement = cameraStick.input.y * cameraAngleSpeed;
		Camera.main.transform.Rotate (-verticalMovement, horizontalMovement, 0);

		Vector3 desiredPosition = target.position + offset;
    	Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
    	transform.position = smoothedPosition;
	}
}