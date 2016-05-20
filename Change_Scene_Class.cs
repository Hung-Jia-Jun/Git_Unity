using UnityEngine;
using System.Collections;
using System.IO;
public class Change_Scene_Class {
	public string ScenceName;//可填入場景名稱
	int Control;
	int int_Sound_Str;
	int int_Scenes_Deside;
	int int_Language_Deside;
	public void ChangeScence(string ScenceName)
	{
		Application.LoadLevel(ScenceName);
	}
	public string ReadFile(string FileName,int linenumber)
	{
		System.Text.Encoding.GetEncoding ("utf-8");
		string[] strs=File.ReadAllLines(FileName,System.Text.Encoding.Default);
		if (linenumber==0)
		{
			return "";
		}
		else
		{
			return strs[linenumber-1];
		}
	}
	public int Control_Deside()
	{
		//控制方式偵測
		if (ReadFile ("C:\\Player_Setting.txt", 1) == "Player Control=Mouse And KeyBord")
		{
			//滑鼠+鍵盤控制方式
			Debug.Log("滑鼠+鍵盤控制方式");
			Control = 1;
		}
		else if (ReadFile ("C:\\Player_Setting.txt", 1) == "Player Control=")
		{
			//控制方式未設定
			Debug.Log("控制方式未設定");
			Control = 0;
		}
		else if (ReadFile ("C:\\Player_Setting.txt", 1) == "Player Control=Rocker And headset")
		{
			//搖桿+耳機控制方式
			Debug.Log("搖桿+耳機控制方式");
			Control = 2;
		}
		return Control;
	}


	public int Sound_Str_Content() //劇本內容判斷
	{
		/*去讀取文字檔的第一行
				判斷裡面有沒有內容
					有內容就直接進入場景
						沒內容的話進入可編輯版本*/
		if (ReadFile("C:\\Sound_Str.txt",1)=="")
		{
			//文字檔沒有內容
			Debug.Log("劇本檔沒有內容");
			int_Sound_Str=0;
		}
		else
		{
			//文字檔有內容
			Debug.Log("劇本檔有內容");
			int_Sound_Str=1;
		}
		return int_Sound_Str;
	}

	public int Scenes_Deside() //場景樣式選擇
	{
		//場景樣式 旅館場景or餐廳場景
		if (ReadFile ("C:\\Player_Setting.txt", 2) == "Scenes Mode=Restaurant")
		{
			//場景樣式 餐廳場景
			Debug.Log("場景樣式 餐廳場景");
			int_Scenes_Deside=1;
		}
		else if (ReadFile ("C:\\Player_Setting.txt", 2) == "Scenes Mode=")
		{
			//尚未選擇場景樣式
			Debug.Log("尚未選擇場景樣式");
			int_Scenes_Deside=0;
		}
		else if (ReadFile ("C:\\Player_Setting.txt", 2) == "Scenes Mode=Hotel")
		{
			//場景樣式 旅館場景
			Debug.Log("場景樣式 旅館場景");
			int_Scenes_Deside=2;
		}
		return int_Scenes_Deside;
	}
	public int Language_Deside() //語言選擇
	{
		//場景樣式 旅館場景or餐廳場景
		if (ReadFile ("C:\\Player_Setting.txt", 3) == "Language=Chinese")
		{
			//語言選擇:中文
			Debug.Log("語言選擇:中文");
			int_Language_Deside=1;
		}
		else if (ReadFile ("C:\\Player_Setting.txt", 3) == "Language=")
		{
			//尚未選擇語言
			Debug.Log("尚未選擇語言");
			int_Language_Deside=0;
		}
		else if (ReadFile ("C:\\Player_Setting.txt", 3) == "Language=German")
		{
			//語言選擇:德文
			Debug.Log("語言選擇:德文");
			int_Language_Deside=2;
		}
		return int_Language_Deside;
	}
}
