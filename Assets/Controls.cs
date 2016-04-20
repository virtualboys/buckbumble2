using UnityEngine;
using System.Collections;

public class Controls : MonoBehaviour {

    public float xMoveSize;
    public float yMoveSize;

    private Vector3 localPos;

	// Use this for initialization
	void Start () {
        localPos = transform.localPosition;
	}
	
	// Update is called once per frame
	void Update () {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        transform.localPosition = localPos + transform.localRotation * (Vector3.right * x * xMoveSize + Vector3.up * y * yMoveSize);
	}
}
