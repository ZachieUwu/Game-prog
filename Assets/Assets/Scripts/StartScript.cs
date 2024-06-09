using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScript : MonoBehaviour
{
    public Transform spawnPos;
    public GameObject Egg;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Egg, spawnPos.position, spawnPos.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
