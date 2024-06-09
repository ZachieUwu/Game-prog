using System.Collections;
using UnityEngine;

public class EggScript : MonoBehaviour
{
    public GameObject Chick;

    void Start()
    {
        GameManager.Eggcount++;
        StartCoroutine(EggTimer());
    }

    IEnumerator EggTimer()
    {
        yield return new WaitForSeconds(10f);
        Instantiate(Chick, transform.position, transform.rotation);
        GameManager.Eggcount--;
        Destroy(gameObject);
    }
}
