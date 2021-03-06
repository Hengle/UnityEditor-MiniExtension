﻿/*  
    Autor: Antonio Mateo Tomas (lPinchol)
    Date: 14/04/2015
    GitHub: https://github.com/lPinchol
*/

using UnityEngine;
using System.Collections;
#if UNITY_4_6 || UNITY_4_6_1 || UNITY_5_0_0 || UNITY_5_0_1 || UNITY_5_1_0 || UNITY_5_1_2 || UNITY_5_1_3 || UNITY_5_3_4
using UnityEngine.UI;
#endif

//[ExecuteInEditMode]
[AddComponentMenu("EditorExt/Localization/Localization")]
public class Localization : MonoBehaviour 
{
    private GameObject prefab;
    public string txtEnglish;
    public string txtSpanish;
    public string txtFrench;


    void Start()
    {
        prefab = this.gameObject;
    }

    void Update()
    {
        if (prefab.GetComponent<GUIText>())
        {
            switch (GeneralVar._LanguageGame)
            { 
                case "ENG":
                    prefab.GetComponent<GUIText>().text = txtEnglish;
                    break;

                case "ESP":
                    prefab.GetComponent<GUIText>().text = txtSpanish;
                    break;

                case "FRE":
                    prefab.GetComponent<GUIText>().text = txtFrench;
                    break;

                default:
                    prefab.GetComponent<GUIText>().text = txtEnglish;
                    break;
            }
            
        }

        if (prefab.GetComponent<Text>())
        {
            switch (GeneralVar._LanguageGame)
            {
                case "ENG":
                    prefab.GetComponent<Text>().text = txtEnglish;
                    break;

                case "ESP":
                    prefab.GetComponent<Text>().text = txtSpanish;
                    break;

                case "FRE":
                    prefab.GetComponent<Text>().text = txtFrench;
                    break;

                default:
                    prefab.GetComponent<Text>().text = txtEnglish;
                    break;
            }
        }
    }
}
