using UnityEngine;
using System.Collections;
using System.IO;
public class ChangeScene: MonoBehaviour
{
	Change_Scene_Class Change_This_Scene = new Change_Scene_Class ();
	public int Player_Mode_Switch;
	int Mode_Control;
	int Mode_Sound_Str;
	int Mode_Scenes_Deside;
	int Mode_Language_Deside;
	void Start ()
	{
		Player_Setting_Mode();
	}

	// Update is called once per frame
	void Update ()
	{

		switch (Player_Mode_Switch)
		{
			case 0:
			{
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
		}
	}

public void Player_Setting_Mode()
{
	Mode_Control=Change_This_Scene.Control_Deside();//判斷Player_Setting裡面的控制方式狀態，並回傳數值
	Debug.Log(Mode_Control);

	Mode_Sound_Str=Change_This_Scene.Sound_Str_Content();//判斷Player_Setting裡面的劇本填入狀態，並回傳數值
	Debug.Log(Mode_Sound_Str);

	Mode_Scenes_Deside=Change_This_Scene.Scenes_Deside();//判斷Player_Setting裡面的場景選擇狀態，並回傳數值
	Debug.Log(Mode_Scenes_Deside);

	Mode_Language_Deside=Change_This_Scene.Language_Deside();//判斷Player_Setting裡面的語言選擇狀態，並回傳數值
	Debug.Log(Mode_Language_Deside);

}





}


