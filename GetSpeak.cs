using UnityEngine;
using System.Collections;

public class GetSpeak : MonoBehaviour {
    public GameObject NPCDialog;
    void Start () {
        readyToSpeak();//遊戲載入後即啟動語音辨識
    }
	
	// Update is called once per frame
	void Update () {
	
	}
    private void readyToSpeak()
    {
        //呼叫html的google語音
        Application.ExternalEval("recognition.start();");
    }
    //供外部html呼叫
    public void speakCallBack(string speakInput)
    {
        NPCDialog = GameObject.Find("NPCDialog");
        NPCDialog.SendMessage("TextContrast",speakInput);
    }
}
