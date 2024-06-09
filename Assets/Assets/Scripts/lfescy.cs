using System.Collections;
using UnityEngine;
using TMPro;

public class lfescy : MonoBehaviour
{
    private int eggCount = 1;
    private int chickCount = 0;
    private int roosterCount = 0;
    private int henCount = 0;

    public TMP_Text eggCountText;
    public TMP_Text chickCountText;
    public TMP_Text roosterCountText;
    public TMP_Text henCountText;

    public GameObject Egg;
    public GameObject Chick;
    public GameObject Hen;
    public GameObject Rooster;

    private void Start()
    {
        UpdateUI();
        SpawnEgg();
        StartCoroutine(HatchEggs());
    }

    private IEnumerator HatchEggs()
    {
        yield return new WaitForSeconds(10);
        eggCount--;
        chickCount++;
        UpdateUI();
        SpawnChick();
        StartCoroutine(GrowChick());
    }

    private IEnumerator GrowChick()
    {
        yield return new WaitForSeconds(10);
        chickCount--;
        int gender = Random.Range(0, 2);
        if (gender == 0)
        {
            henCount++;
            UpdateUI();
            SpawnHen();
            StartCoroutine(HenLifecycle());
        }
        else
        {
            roosterCount++;
            UpdateUI();
            SpawnRooster();
            StartCoroutine(RoosterLifecycle());
        }
    }

    private IEnumerator HenLifecycle()
    {
        yield return new WaitForSeconds(30);
        int newEggs = Random.Range(2, 11);
        eggCount += newEggs;
        UpdateUI();
        for (int i = 0; i < newEggs; i++)
        {
            SpawnEgg();
            StartCoroutine(HatchEggs());
        }

        yield return new WaitForSeconds(10);
        eggCount -= newEggs;
        UpdateUI();

        yield return new WaitForSeconds(10);
        henCount--;
        UpdateUI();
    }

    private IEnumerator RoosterLifecycle()
    {
        yield return new WaitForSeconds(40);
        roosterCount--;
        UpdateUI();
    }

    private void UpdateUI()
    {
        eggCountText.text = "Eggs: " + eggCount;
        chickCountText.text = "Chicks: " + chickCount;
        roosterCountText.text = "Roosters: " + roosterCount;
        henCountText.text = "Hens: " + henCount;
    }

    private void SpawnEgg()
    {
        Instantiate(Egg, GetRandomPosition(), Quaternion.identity);
    }

    private void SpawnChick()
    {
        Instantiate(Chick, GetRandomPosition(), Quaternion.identity);
    }

    private void SpawnHen()
    {
        Instantiate(Hen, GetRandomPosition(), Quaternion.identity);
    }

    private void SpawnRooster()
    {
        Instantiate(Rooster, GetRandomPosition(), Quaternion.identity);
    }

    private Vector3 GetRandomPosition()
    {
        return new Vector3(Random.Range(-5f, 5f), 0, Random.Range(-5f, 5f));
    }
}
