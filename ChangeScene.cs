using UnityEngine;
using System.Collections;
using System.IO;
public class ChangeScene: MonoBehaviour
{
	Change_Scene_Class Change_This_Scene = new Change_Scene_Class ();
	StrWrite Str_Clean_Txt = new StrWrite();
	public int Player_Mode_Switch;
	int Player_Mode;
	public string Scenes_Name;//場景名稱
	public int This_PageNum;//當前頁面
	void Start ()
	{
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
				Change_This_Scene.ChangeScence(Scenes_Name);
				break;
			}
			case 1:
			{
				break;
			}
			case 2:
			{
				break;
			}
			case 3:
			{
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
		Player_Mode_Switch=Change_This_Scene.Player_Setting_Mode(This_PageNum);//傳入當前頁數判斷Switch狀態
	}
	public void When_User_Click_Leaf_Button()//當使用者按下離開按鈕時
	{
		Str_Clean_Txt.Clear_Txt_File_Content ();//清空文字檔
		Str_Clean_Txt.Clear_Tag_Mode_Content();//清空所有Tag狀態
	}
}


