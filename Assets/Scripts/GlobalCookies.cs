using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class GlobalCookies : MonoBehaviour
{
    public static int CookieCount;
    public GameObject CookieDisplay;
    public int InternalCookie;

    void Update()
    {
        InternalCookie = CookieCount;
        CookieDisplay.GetComponent<TextMeshProUGUI>().text = "Cookies: " + InternalCookie;
    }
}
