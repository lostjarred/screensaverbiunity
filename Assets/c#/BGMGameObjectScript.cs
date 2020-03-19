using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BGMGameObjectScript : MonoBehaviour
{
    public GameObject volumetextbox;
    GameObject self;
    public float maxvolume = 1f;
    public float modifyvolumeammount = 0.10f;

    public int getvolumepercent(float curvolume){
        float volumepercent = (curvolume / maxvolume) * 100;
        return (int)volumepercent;
    }
    
    public float getmusicvolume(){
        return self.GetComponent<AudioSource>().volume;
    }

    public void setmusicvolume(float musicvolume){
        self.GetComponent<AudioSource>().volume = musicvolume;
    }

    public void updateTextBox(GameObject gameObject, string texttoupdate){
        gameObject.GetComponent<Text>().text=texttoupdate;
    }

    // Start is called before the first frame update
    void Start()
    {
        self = gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.KeypadPlus) && getmusicvolume() < maxvolume){
            setmusicvolume(getmusicvolume() + modifyvolumeammount);
        }

        if(Input.GetKeyDown(KeyCode.KeypadMinus) && getmusicvolume() > 0.0f){
            setmusicvolume(getmusicvolume() - modifyvolumeammount);
        }
        updateTextBox(volumetextbox, getvolumepercent(getmusicvolume()).ToString());
    }
}
