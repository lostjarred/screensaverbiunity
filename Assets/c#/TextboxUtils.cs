using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TextboxUtils : MonoBehaviour
{
    public static void updateTextBox(GameObject gameObject, string texttoupdate){
        gameObject.GetComponent<Text>().text=texttoupdate;
    }

    public static string getTextBoxText(GameObject gameObject){
        return gameObject.GetComponent<Text>().text;
    }
}
