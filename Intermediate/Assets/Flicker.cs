using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flicker : MonoBehaviour {

    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Random.value >= 0.3)
        {
            if(GetComponent<Light>().intensity == 2)
            {
                GetComponent<Light>().intensity = 1;
            }
            else
            {
                GetComponent<Light>().intensity = 2;
            }
        }
	}

    IEnumerator wait ()
    {
        yield return new WaitForSeconds(5);
    }
}
