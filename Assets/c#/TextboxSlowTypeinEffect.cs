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
        string curstringtextbox = TextboxUtils.getTextBoxText(self);
        if (curstringtextbox.Length < defaulttextboxstring.Length){
            return true;
        }else{
            return false;
        }
    }

    public void slowtypetexteffect(){
        string curstringtextbox = TextboxUtils.getTextBoxText(self);
        if (curstringtextbox.Length < defaulttextboxstring.Length){
            curstringtextbox = curstringtextbox + defaulttextboxstring[curchar];
            curchar = curchar + 1;
            TextboxUtils.updateTextBox(self, curstringtextbox);
        }
        
    }
    // Start is called before the first frame update
    void Start()
    {
        self = gameObject;
        defaulttextboxstring = TextboxUtils.getTextBoxText(self);
        TextboxUtils.updateTextBox(self, "");
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
