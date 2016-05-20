using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Speak : MonoBehaviour {

	public Text text;//畫面上的文字

	// Use this for initialization
	void Start () {
		readyToSpeak();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	private void readyToSpeak(){
		//呼叫html的google語音
		Application.ExternalEval("recognition.start();");
	}

	//供外部html呼叫
	public void speakText(string speakInput){
		text.text = speakInput;
	}
}
