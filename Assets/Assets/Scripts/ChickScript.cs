using System.Collections;
using UnityEngine;

public class ChickScript : MonoBehaviour
{
    private float time2;
    public GameObject Hen;
    public GameObject Rooster;

    void Start()
    {
        time2 = GameManager.time;
        GameManager.Chickcount++;

        if (time2 > 21)
        {
            StartCoroutine(Growing());
        }
        else
        {
            StartCoroutine(HenSpawn());
        }
    }

    IEnumerator HenSpawn()
    {
        yield return new WaitForSeconds(10f);
        Instantiate(Hen, transform.position, transform.rotation);
        GameManager.Chickcount--;
        Destroy(gameObject);
    }

    IEnumerator Growing()
    {
        yield return new WaitForSeconds(10f);
        HenRoost();
    }


    void HenRoost()
    {
        int randomChance = Random.Range(0, 2);
        GameObject spawnedObject;

        if (randomChance == 0)
        {
            spawnedObject = Instantiate(Hen, transform.position, transform.rotation);
        }
        else
        {
            spawnedObject = Instantiate(Rooster, transform.position, transform.rotation);
        }

        GameManager.Chickcount--;
        Destroy(gameObject);
    }
}
