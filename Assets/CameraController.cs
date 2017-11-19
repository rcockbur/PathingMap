using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    public float cameraSpeed;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        float dy = Input.GetAxis("Vertical") * cameraSpeed;
        float dx = Input.GetAxis("Horizontal") * cameraSpeed;

        transform.Translate(dx, dy, 0);
    }
}
