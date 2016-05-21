using UnityEngine;
using System.Collections;
using System.IO;
public class Change_Scene_Class {
	public string ScenceName;//可填入場景名稱
	int Control;//控制方式的選擇
	int int_Sound_Str;//使用者劇本的選擇
	int int_Scenes_Deside;//餐廳場景/旅館的選擇
	int int_Language_Deside;//語言的選擇
	int int_Lesson_Deside;//第一課/第二課的選擇
	int PageNum;//目前使用者在哪一頁
	int Change_Switch;//切換場景的switch
	public int Player_Setting_Mode(int PageNum)
	{
		if (PageNum==1)
		{
			Control=Control_Deside();//判斷Player_Setting裡面的控制方式狀態，並回傳數值
			int_Sound_Str=Sound_Str_Content();//判斷Player_Setting裡面的劇本填入狀態，並回傳數值
			int_Scenes_Deside=Scenes_Deside();//判斷Player_Setting裡面的場景選擇狀態，並回傳數值
			int_Language_Deside=Language_Deside();//判斷Player_Setting裡面的語言選擇狀態，並回傳數值
			int_Lesson_Deside=Lesson_Select ();//使用者課程選擇
			if (int_Sound_Str==0) //劇本檔沒有內容，第一次使用系統
			{
				Change_Switch=0;//進入第一次使用系統的Case
			}
			else if (/*控制方式已選擇*/Control !=0 & /*場景樣式未選擇*/int_Scenes_Deside ==0 ||/*語言未選擇*/ int_Language_Deside ==0 ||/*劇本內容未填寫*/ int_Sound_Str ==0 ||int_Lesson_Deside==0  )
			{
				Change_Switch=2;//載入劇本，回使用者設定修改
			}
			else if (int_Sound_Str !=0 & Control !=0 )//劇本檔已有內容，非第一次使用系統，控制也已經選擇了
			{
				Change_Switch=1;//載入劇本，進入編輯好的劇情
			}
		}
		if (PageNum==2)
		{
			Control=Control_Deside();//判斷Player_Setting裡面的控制方式狀態，並回傳數值
			int_Sound_Str=Sound_Str_Content();//判斷Player_Setting裡面的劇本填入狀態，並回傳數值
			int_Scenes_Deside=Scenes_Deside();//判斷Player_Setting裡面的場景選擇狀態，並回傳數值
			int_Language_Deside=Language_Deside();//判斷Player_Setting裡面的語言選擇狀態，並回傳數值
			int_Lesson_Deside=Lesson_Select ();//使用者課程選擇
		}
		if (PageNum==3)
		{
			Control=Control_Deside();//判斷Player_Setting裡面的控制方式狀態，並回傳數值
			int_Sound_Str=Sound_Str_Content();//判斷Player_Setting裡面的劇本填入狀態，並回傳數值
			int_Scenes_Deside=Scenes_Deside();//判斷Player_Setting裡面的場景選擇狀態，並回傳數值
			int_Language_Deside=Language_Deside();//判斷Player_Setting裡面的語言選擇狀態，並回傳數值
			int_Lesson_Deside=Lesson_Select ();//使用者課程選擇
		}
		if (PageNum==4)
		{
			Control=Control_Deside();//判斷Player_Setting裡面的控制方式狀態，並回傳數值
			int_Sound_Str=Sound_Str_Content();//判斷Player_Setting裡面的劇本填入狀態，並回傳數值
			int_Scenes_Deside=Scenes_Deside();//判斷Player_Setting裡面的場景選擇狀態，並回傳數值
			int_Language_Deside=Language_Deside();//判斷Player_Setting裡面的語言選擇狀態，並回傳數值
			int_Lesson_Deside=Lesson_Select ();//使用者課程選擇
		}
		if (PageNum==5)
		{
			Control=Control_Deside();//判斷Player_Setting裡面的控制方式狀態，並回傳數值
			int_Sound_Str=Sound_Str_Content();//判斷Player_Setting裡面的劇本填入狀態，並回傳數值
			int_Scenes_Deside=Scenes_Deside();//判斷Player_Setting裡面的場景選擇狀態，並回傳數值
			int_Language_Deside=Language_Deside();//判斷Player_Setting裡面的語言選擇狀態，並回傳數值
			int_Lesson_Deside=Lesson_Select ();//使用者課程選擇
		}
		if (PageNum==6)
		{
			Control=Control_Deside();//判斷Player_Setting裡面的控制方式狀態，並回傳數值
			int_Sound_Str=Sound_Str_Content();//判斷Player_Setting裡面的劇本填入狀態，並回傳數值
			int_Scenes_Deside=Scenes_Deside();//判斷Player_Setting裡面的場景選擇狀態，並回傳數值
			int_Language_Deside=Language_Deside();//判斷Player_Setting裡面的語言選擇狀態，並回傳數值
			int_Lesson_Deside=Lesson_Select ();//使用者課程選擇
		}
		return Change_Switch;
	}
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
			//Debug.Log("滑鼠+鍵盤控制方式");
			Control = 1;
		}
		else if (ReadFile ("C:\\Player_Setting.txt", 1) == "Player Control=")
		{
			//控制方式未設定
			//Debug.Log("控制方式未設定");
			Control = 0;
		}
		else if (ReadFile ("C:\\Player_Setting.txt", 1) == "Player Control=Rocker And headset")
		{
			//搖桿+耳機控制方式
			//Debug.Log("搖桿+耳機控制方式");
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
		if (ReadFile("C:\\Sound_Str.txt",2)=="")
		{
			//文字檔沒有內容
			//Debug.Log("劇本檔沒有內容");
			int_Sound_Str=0;
		}
		else
		{
			//文字檔有內容
			//Debug.Log("劇本檔有內容");
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
			//Debug.Log("場景樣式 餐廳場景");
			int_Scenes_Deside=1;
		}
		else if (ReadFile ("C:\\Player_Setting.txt", 2) == "Scenes Mode=")
		{
			//尚未選擇場景樣式
			//Debug.Log("尚未選擇場景樣式");
			int_Scenes_Deside=0;
		}
		else if (ReadFile ("C:\\Player_Setting.txt", 2) == "Scenes Mode=Hotel")
		{
			//場景樣式 旅館場景
			//Debug.Log("場景樣式 旅館場景");
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
			//Debug.Log("語言選擇:中文");
			int_Language_Deside=1;
		}
		else if (ReadFile ("C:\\Player_Setting.txt", 3) == "Language=")
		{
			//尚未選擇語言
			//Debug.Log("尚未選擇語言");
			int_Language_Deside=0;
		}
		else if (ReadFile ("C:\\Player_Setting.txt", 3) == "Language=German")
		{
			//語言選擇:德文
			//Debug.Log("語言選擇:德文");
			int_Language_Deside=2;
		}
		return int_Language_Deside;
	}


	public int Lesson_Select ()
	{
		if (ReadFile ("C:\\Player_Setting.txt", 4) == "Lesson=1")
		{
			//課程選擇 第一課
			//Debug.Log("課程選擇 第一課");
			int_Lesson_Deside=1;
		}
		else if (ReadFile ("C:\\Player_Setting.txt", 4) == "Lesson=")
		{
			//尚未選擇課程
			//Debug.Log("尚未選擇課程");
			int_Lesson_Deside=0;
		}
		else if (ReadFile ("C:\\Player_Setting.txt", 4) == "Lesson=2")
		{
			//課程選擇 第二課
			//Debug.Log("課程選擇 第二課");
			int_Lesson_Deside=2;
		}
		return int_Lesson_Deside;
	}
}
