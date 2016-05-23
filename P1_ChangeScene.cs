using UnityEngine;
using System.Collections;
using System.IO;
public class P1_ChangeScene: MonoBehaviour
{
	Change_Scene_Class Change_This_Scene = new Change_Scene_Class ();
	StrWrite Str_Clean_Txt = new StrWrite();
	public int Player_Mode_Switch;
	int Player_Mode;
	public string Scenes_Name;//場景名稱
	public int This_PageNum=1;//當前頁面
	int Scenes_Mode;//使用者選擇場景
	void Start ()
	{
		//This_PageNum=1;
		//Change_This_Scene.Player_Setting_Mode(This_PageNum);
		Player_Mode_Switch=99;//預設Case
	}

	// Update is called once per frame
	void Update ()
	{
		//Player_Mode_Switch=Change_This_Scene.Player_Setting_Mode(This_PageNum);
		//Debug.Log(Player_Mode_Switch);
		switch (Player_Mode_Switch)
		{

			case 0:
			{
				Change_This_Scene.ChangeScence("Scence/Page2");//第一次使用系統 進入系統設定
				break;
			}
			case 1: //切換至使用者編輯好的場景
			{
				Scenes_Mode=Change_This_Scene.Scenes_Deside();
				if (Scenes_Mode==1)
				{
					Change_This_Scene.ChangeScence ("Scence/Scence1_hall");
					Debug.Log(Scenes_Mode);
				}
				else if (Scenes_Mode==2)
				{
					Change_This_Scene.ChangeScence ("Scence/Scence2_restaurant");
					Debug.Log(Scenes_Mode);
				}
				break;
			}
			case 2:
			{
				Change_This_Scene.ChangeScence ("Scence/Page5"); //切換到編輯場景內容
				break;
			}
			case 3:
			{
				Change_This_Scene.ChangeScence ("Scence/Page4_Less1"); //切換到編輯場景內容
				break;
			}
			case 4:
			{
				Change_This_Scene.ChangeScence ("Scence/Page3"); //切換到編輯場景內容
				break;
			}
			case 5:
			{
				Change_This_Scene.ChangeScence("Scence/Page5");//場景樣示未選擇
				break;
			}
			case 6:
			{
				Change_This_Scene.ChangeScence("Scence/Page2");//場景樣示未選擇
				break;
			}
			case 99:
			{
				break;
			}
		}
	}
	public void When_User_Click_Start_Button(int This_PageNum) //當使用者按下開始扭
	{
		This_PageNum=1;
		Player_Mode_Switch=Change_This_Scene.Player_Setting_Mode(This_PageNum);//傳入當前頁數判斷Switch狀態
	}
	public void When_User_Click_Leaf_Button()//當使用者按下離開按鈕時
	{
		Str_Clean_Txt.Clear_Txt_File_Content ();//清空文字檔
		Str_Clean_Txt.Clear_Tag_Mode_Content();//清空所有Tag狀態
	}
}


