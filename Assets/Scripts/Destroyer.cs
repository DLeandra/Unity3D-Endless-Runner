using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    public string parentName;
   
  
    void Start()
    {
        parentName = transform.name;
        StartCoroutine(DestroyClone());
    }
     
    IEnumerator DestroyClone()
    {
    yield return new WaitForSeconds(50);
        if (parentName == "Segment(Clone)")
        {
            Destroy(gameObject);
        }
    }
}
 