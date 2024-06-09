using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static int Eggcount;
    public static int Chickcount;
    public static int Hencount;
    public static int Roostcount;

    public static float time;
    public TMP_Text Eggval;
    public TMP_Text Chickval;
    public TMP_Text Henval;
    public TMP_Text Roostval;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Eggval.SetText(Eggcount.ToString());
        Chickval.SetText(Chickcount.ToString());
        Henval.SetText(Hencount.ToString());
        Roostval.SetText(Roostcount.ToString());
        time += Time.deltaTime;
    }
}
