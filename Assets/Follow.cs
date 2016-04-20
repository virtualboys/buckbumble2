using UnityEngine;
using System.Collections;

public class Follow : MonoBehaviour {

	// Use this for initialization
    public Transform target;
    float zDistance;

	void Start () {
        zDistance = (target.transform.position.z - transform.position.z);
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(transform.position.x, transform.position.y, target.transform.position.z - zDistance);
        //transform.LookAt(target);

	}
}
