using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargerScript : MonoBehaviour {
    public GameObject falle1;
    // Use this for initialization
    void Start () {
		
	}

    private void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    { //Hier lasse ich die Animation ein letztes mal abspielen, damit sie danach gestoppt und an der ersten Frame stehen bleibt
        falle1.GetComponent<Animation>().wrapMode = WrapMode.Once;
      
    }
}
