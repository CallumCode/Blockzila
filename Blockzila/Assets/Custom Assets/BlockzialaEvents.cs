using UnityEngine;
using System.Collections;

public class BlockzialaEvents : MonoBehaviour {

    public Animator animatorCam;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void ShakeCamera()
    {
        animatorCam.SetTrigger("Shake");
    }

}
