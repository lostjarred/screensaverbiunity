using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextboxSlowTypeinEffect : MonoBehaviour
{
    string defaulttextboxstring;
    GameObject self;
    int curchar = 0;
    float eventTime;
    float delaytime = 0.1f;

    public bool Getcomplete(){
        string curstringtextbox = getTextBoxText(self);
        if (curstringtextbox.Length < defaulttextboxstring.Length){
            return true;
        }else{
            return false;
        }
    }
    public string getTextBoxText(GameObject gameObject){
        return gameObject.GetComponent<Text>().text;
    }

    public void updateTextBox(GameObject gameObject, string texttoupdate){
        gameObject.GetComponent<Text>().text=texttoupdate;
    }

    public void slowtypetexteffect(){
        string curstringtextbox = getTextBoxText(self);
        if (curstringtextbox.Length < defaulttextboxstring.Length){
            curstringtextbox = curstringtextbox + defaulttextboxstring[curchar];
            curchar = curchar + 1;
            updateTextBox(self, curstringtextbox);
        }
        
    }
    // Start is called before the first frame update
    void Start()
    {
        self = gameObject;
        defaulttextboxstring = getTextBoxText(self);
        updateTextBox(self, "");
        eventTime = Time.deltaTime + delaytime;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= eventTime){
            slowtypetexteffect();
            eventTime = eventTime + delaytime;
        }
    }
}
