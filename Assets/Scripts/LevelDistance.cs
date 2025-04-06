using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LevelDistance : MonoBehaviour
{

    [SerializeField] GameObject disDisplay;
    [SerializeField] int disRun;
    [SerializeField] bool addingDis = false;
    [SerializeField] float disDelay=0.35f;
    [SerializeField] GameObject disEndDisplay;
    void Update()
    {
       if (addingDis==false)
        {
            addingDis = true;
            StartCoroutine(AddingDis());
        }
    }

    IEnumerator AddingDis()
    {
        disRun +=1;
        disDisplay.GetComponent<TMPro.TMP_Text>().text = disRun.ToString();
        disEndDisplay.GetComponent<TMPro.TMP_Text>().text = disRun.ToString();
        yield return new WaitForSeconds(disDelay);
        addingDis=false;
    }

}
