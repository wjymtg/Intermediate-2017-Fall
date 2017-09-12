using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRInputTest : MonoBehaviour {

    public float WalkSpeed;
    public GameObject camera;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        OVRInput.Update();

        Vector2 primStick = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick);
        Vector2 secStick = OVRInput.Get(OVRInput.Axis2D.SecondaryThumbstick);
        if (!primStick.Equals(Vector2.zero))
        {
            //Debug.Log("PrimaryJoystick clicked");
            gameObject.transform.position = gameObject.transform.position + camera.transform.forward * primStick.x * WalkSpeed;
            gameObject.transform.position = gameObject.transform.position + camera.transform.right * primStick.y * WalkSpeed;
        }
        if (!secStick.Equals(Vector2.zero))
        {
            Debug.Log("SecondaryJoystick Clicked");
        }
        if (OVRInput.Get(OVRInput.Button.PrimaryHandTrigger))
        {
            Debug.Log("Primary Grip Clicked");
        }
	}
}
