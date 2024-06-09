using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoosterScript : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
    
        StartCoroutine(RoostTime());
        GameManager.Roostcount++;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

        IEnumerator RoostTime()
    {
        
          yield return new WaitForSeconds(40f); 
         GameManager.Roostcount--;
          Destroy(this.gameObject);

    }
}
