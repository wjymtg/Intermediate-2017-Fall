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
            Debug.Log("Prim Stick: " + primStick.ToString());
            Vector3 forwardDir = camera.transform.forward;
            forwardDir.z = 0;
            Vector3 rightDir = camera.transform.right;
            rightDir.z = 0;
            gameObject.transform.position = gameObject.transform.position + forwardDir * primStick.y * WalkSpeed;
            gameObject.transform.position = gameObject.transform.position + rightDir * primStick.x * WalkSpeed;
        }
        if (!secStick.Equals(Vector2.zero))
        {
            Debug.Log("SecondaryJoystick:" + secStick.ToString());
        }
        if (OVRInput.Get(OVRInput.Button.PrimaryHandTrigger))
        {
            Debug.Log("Primary Grip Clicked");
        }
	}
}
