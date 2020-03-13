using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using screensaver;
public class MainObject : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] timeTextboxs;
    public GameObject[] dataFlowTextBoxs;
    public GameObject usertextbox;
    string textoutput;
    string stringchunk;
    int curtxtbox = 0;

    float eventTime;
    float delaytime = 0.05f;

    TextboxSlowTypeinEffect textboxSlowTypeinEffect;
    
    public void updateTextBox(GameObject gameObject, string texttoupdate){
        gameObject.GetComponent<Text>().text=texttoupdate;
    }
    
    public string getTextBoxText(GameObject gameObject){
        return gameObject.GetComponent<Text>().text;
    }

    public void UpdateDataFlowTextBoxs(){
        if(curtxtbox < dataFlowTextBoxs.Length){
                textoutput= "";
                stringchunk = Stringchunkgenerator.GetCharacterChunk(Stringchunkgenerator.GetCharacterString(), Stringchunkgenerator.Getrandomnumber(1, 7));
                textoutput = screensaver.Converters.convertStringBineary(stringchunk);
                for(int i = 0; i < Stringchunkgenerator.Getrandomnumber(0,5); i ++){
                    stringchunk = Stringchunkgenerator.GetCharacterChunk(Stringchunkgenerator.GetCharacterString(), Stringchunkgenerator.Getrandomnumber(1, 7));
                    textoutput = textoutput + " " + screensaver.Converters.convertStringBineary(stringchunk);
                }
                updateTextBox(dataFlowTextBoxs[curtxtbox], textoutput);
            curtxtbox = curtxtbox + 1;
        }else{
            curtxtbox = 0;
        }
    }
    void Start()
    {   
        eventTime = UnityEngine.Time.deltaTime + delaytime;
        for(int i = 0; i < dataFlowTextBoxs.Length; i++){
            updateTextBox(dataFlowTextBoxs[i], "");
        }
    }

    // Update is called once per frame
    void Update()
    {
        textoutput = screensaver.Time.Gettime(screensaver.Time.GetDateTime());
        updateTextBox(timeTextboxs[0], textoutput);

        textoutput = screensaver.Converters.convertIntBineary(screensaver.Time.GetHour(screensaver.Time.GetDateTime())) + " " + screensaver.Converters.convertIntBineary(screensaver.Time.GetMinute(screensaver.Time.GetDateTime())) + " " + screensaver.Converters.convertIntBineary(screensaver.Time.GetSecond(screensaver.Time.GetDateTime()));
        updateTextBox(timeTextboxs[1], textoutput);

        textoutput = screensaver.Converters.convertIntHex(screensaver.Time.GetHour(screensaver.Time.GetDateTime())) + " " + screensaver.Converters.convertIntHex(screensaver.Time.GetMinute(screensaver.Time.GetDateTime())) + " " + screensaver.Converters.convertIntHex(screensaver.Time.GetSecond(screensaver.Time.GetDateTime()));
        updateTextBox(timeTextboxs[2], textoutput);
        
        if (usertextbox.GetComponent<TextboxSlowTypeinEffect>().Getcomplete() == false){
            if (UnityEngine.Time.time >= eventTime){
                UpdateDataFlowTextBoxs();
                eventTime = eventTime + delaytime;
            }
        }

        if (Input.GetKeyDown(KeyCode.Escape)){
            Application.Quit();
        }
        
    }
}
