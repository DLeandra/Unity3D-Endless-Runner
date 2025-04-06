using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MasterInfo : MonoBehaviour
{
    public static int coinCount;
    [SerializeField] GameObject coinDisplay;
    [SerializeField] GameObject coinEndDisplay;

    void Update()
    {
        coinDisplay.GetComponent<TMPro.TMP_Text>().text = coinCount.ToString();
        coinEndDisplay.GetComponent<TMPro.TMP_Text>().text = coinCount.ToString();

    }
}
