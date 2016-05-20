using UnityEngine;
using System.Collections;
using System.IO;
using System.Collections.Generic;
using System;
using UnityEngine.UI;
public class Scence1CatchRecog : MonoBehaviour {
	public string TxtRecognize;//讀取辨識的txt檔內容是否符合
	public GameObject SceneControl;//場景控制物件
	public bool WriteMessage;//設定要寫入的訊息是否成功
	public GameObject RecognizeResult;//老闆要講的話
	string TxtPath="C:\\A.txt";
	int linenumber=0;
	void Start()
	{
		SceneControl=GameObject.Find("SceneControl");
	}
void FixedUpdate()
	{
		TxtRecognize = ReadFile (TxtPath, linenumber);
		//TxtRecognize = Atxt.text;//設定要辨識的字元來自於文字檔
		RecognizeResult.GetComponentInChildren<Text> ().text = TxtRecognize;//說話者:顧客
		Debug.Log(TxtRecognize);
	}
public void CheckRecog(string RecoText)//語音檢測
{
bool Status;
/*************************不管使用者說哪句都會通過*****************************/
if(TxtRecognize=="我要一間大")//我要一間大街風景房
    {
		Status = true;//辨識成功
		SceneControl.SendMessage ("ReturnCheck",Status);
    }
if(TxtRecognize=="我要一間日")//我要一間日月潭美景房
    {
		Status = true;//辨識成功
		SceneControl.SendMessage ("ReturnCheck",Status);
    }
if(TxtRecognize=="我要付現金")//我要一間日月潭美景房
    {
		Status = true;//辨識成功
		SceneControl.SendMessage ("ReturnCheck",Status);
    }
if(TxtRecognize=="我要刷卡請")//我要一間日月潭美景房
    {
		Status = true;//辨識成功
		SceneControl.SendMessage ("ReturnCheck",Status);
    }
if(TxtRecognize=="我要手機支")//我要一間日月潭美景房
    {
		Status = true;//辨識成功
		SceneControl.SendMessage ("ReturnCheck",Status);
    }

/*************************不管使用者說哪句都會通過*****************************/
if (RecoText == TxtRecognize)
	{
		Status = true;//辨識成功
		SceneControl.SendMessage ("ReturnCheck",Status);
	}

else
    {
		Status = false;
		SceneControl.SendMessage ("ReturnCheck",Status);
	}

}
	//讀取txt
	string ReadFile(string FileName,int linenumber)
	{
		System.Text.Encoding.GetEncoding ("utf-8");
		string[] strs=File.ReadAllLines(FileName,System.Text.Encoding.Default);
		linenumber=strs.Length;
		if (linenumber==0)
		{
			return "";
		}
		else
		{
			return strs[linenumber-1];
		}
	}
}

