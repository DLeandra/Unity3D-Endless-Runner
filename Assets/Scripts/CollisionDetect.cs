using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetect : MonoBehaviour
{
    [SerializeField] GameObject thePlayer;
    [SerializeField] GameObject playerAnimate;
    [SerializeField] AudioSource crashThudFX;
    [SerializeField] GameObject mainCam;
    [SerializeField] GameObject levelControl;

    //void OnTriggerEnter(Collider other)
    //{
    //   thePlayer.GetComponent<PlayerMovement>().enabled = false;
    //    crashThudFX.Play();
    //    levelControl.GetComponent<LevelDistance>().enabled = false;
    //    mainCam.GetComponent<Animator>().enabled = true;
    //   playerAnimate.GetComponent<Animator>().Play("Stumble Backwards");
    //    levelControl.GetComponent<EndRunSequence>().enabled = true;
    //}
    void OnTriggerEnter(Collider other)
    {
        thePlayer.GetComponent<PlayerMovement>().enabled = false;
        crashThudFX.Play();
        levelControl.GetComponent<LevelDistance>().enabled = false;
        mainCam.GetComponent<Animator>().enabled = true;
        playerAnimate.GetComponent<Animator>().Play("Stumble Backwards");

        // Start the end sequence coroutine directly
        levelControl.GetComponent<EndRunSequence>().StartCoroutine("EndSequence");
        
    }

}
