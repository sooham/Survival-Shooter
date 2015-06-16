using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public Transform target;
	public float smoothing = 5f;

	Vector3 offset;
	// Use this for initialization
	void Start () {
		// Calculate the initial offset
		offset = transform.position - target.position;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		// Create a position the camera is aiming for based on the offset of from the target
		Vector3 targetCamPos = target.position + offset;

		// Smoothly move
		transform.position = Vector3.Lerp (transform.position, targetCamPos, smoothing * Time.deltaTime);
	}
}
