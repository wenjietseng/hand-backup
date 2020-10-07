using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
    private GameObject repositionHand;
    private float ringFingerPinchStrength;
    
    void Start()
    {
        repositionHand = GameObject.Find("LeftOVRHandPrefab");
        
    }

    void Update()
    {
        ringFingerPinchStrength = repositionHand.GetComponent<OVRHand>().GetFingerPinchStrength(OVRHand.HandFinger.Pinky);
        if (Input.GetKeyDown(KeyCode.Space) || ringFingerPinchStrength > 0.975)
        {
            OVRManager.display.RecenterPose();
            SceneManager.LoadScene(0);
        }
    }
}
