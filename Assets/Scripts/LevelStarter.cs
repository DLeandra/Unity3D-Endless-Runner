using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelStarter : MonoBehaviour
{
    [SerializeField] GameObject countDown3;
    [SerializeField] GameObject countDown2;
    [SerializeField] GameObject countDown1;
    [SerializeField] GameObject countDownGo;
    [SerializeField] GameObject fadeIn;
    [SerializeField] AudioSource countDownFX;
    void Start()
    {
       StartCoroutine(CountSequence()); 
    }

    IEnumerator CountSequence()
    {
        yield return new WaitForSeconds(1);
        countDown3.SetActive(true);
        countDownFX.Play();
        yield return new WaitForSeconds(1);
        countDown2.SetActive(true);
       // countDownFX.Play();
        yield return new WaitForSeconds(1);
        countDown1.SetActive(true);
       // countDownFX.Play();
        yield return new WaitForSeconds(1);
        countDownGo.SetActive(true);
       // countDownFX.Play();
    }
   
    
}
