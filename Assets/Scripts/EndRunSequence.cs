using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndRunSequence : MonoBehaviour
{
    [SerializeField] GameObject liveCoins;
    [SerializeField] GameObject liveDistance;
    [SerializeField] GameObject endScreen;
    [SerializeField] GameObject fadeOut;
    //void Start()
    //{
    //    StartCoroutine(EndSequence());
    //}

    //IEnumerator EndSequence()
    //{
    //    yield return new WaitForSeconds(5);
    //    liveCoins.SetActive(false);
    //    liveDistance.SetActive(false);
    //    endScreen.SetActive(false);
    //    yield return new WaitForSeconds(5);
    //    fadeOut.SetActive(false);
    //    //   countDownFX.Play();

    //}
    public IEnumerator EndSequence()
    {
        Debug.Log("EndSequence started");

        // Wait 5 seconds before starting the sequence
        yield return new WaitForSeconds(3);

        Debug.Log("Disabling liveCoins and liveDistance");
        liveCoins.SetActive(false);
        liveDistance.SetActive(false);
        endScreen.SetActive(true); // Show end screen

        yield return new WaitForSeconds(3);
        Debug.Log("Activating fadeOut");
        fadeOut.SetActive(false);

        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(0);

    }


}
