using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GlobalBaker : MonoBehaviour
{
    public GameObject fakeButton;
    public GameObject fakeText;
    public GameObject realButton;
    public GameObject realText;
    public int currentCash;
    public static int bakerValue = 50;
    public static bool turnOffButton = false;
    public GameObject bakerStats;
    public static int numberOfBakers;
    public static int bakePerSec;

    void Update()
    {
        currentCash = GlobalCash.CashCount;
        bakerStats.GetComponent<TextMeshProUGUI>().text = "Bakers: " + numberOfBakers + " @ " + bakePerSec + " Per Second";
        fakeText.GetComponent<TextMeshProUGUI>().text = "Buy Baker - $" + bakerValue;
        realText.GetComponent<TextMeshProUGUI>().text = "Buy Baker - $" + bakerValue;
        if (currentCash >= bakerValue)
        {
            fakeButton.SetActive(false);
            realButton.SetActive(true);
        }

        if (turnOffButton == true)
        {
            realButton.SetActive(false);
            fakeButton.SetActive(true);
            turnOffButton= false;
        }
    }
}
