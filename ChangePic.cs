using UnityEngine;
using System.Collections;

public class ChangePic : MonoBehaviour
{
	Input_class Input = new Input_class ();
	Change_Scene_Class Change_To_Scene = new Change_Scene_Class();
	public GameObject Default_1_1_Pic;//預設語言1圖片
	public GameObject  Change_1_2_Pic;//切換語言1圖片

	public GameObject Default_2_1_Pic;//預設語言2圖片
	public GameObject  Change_2_2_Pic;//切換語言2圖片

	public GameObject Default_3_1_Pic;//預設編輯語言圖片
	public GameObject  Change_3_2_Pic;//切換編輯語言圖片


	void Start () {
		Default_1_1_Pic.gameObject.SetActive(true); //關閉預設的圖
		Change_1_2_Pic.gameObject.SetActive(false); //顯示玩家按下去後顯示的圖片

		Default_2_1_Pic.gameObject.SetActive(true); //關閉預設的圖
		Change_2_2_Pic.gameObject.SetActive(false); //顯示玩家按下去後顯示的圖片

		Default_3_1_Pic.gameObject.SetActive(true); //關閉預設的圖
		Change_3_2_Pic.gameObject.SetActive(false); //顯示玩家按下去後顯示的圖片

	}

	public void Change_1Pic()
	{
		Input.Write_Mark_Line ("Language=Chinese",3,"C:\\Player_Setting.txt");
		Change_To_Scene.ChangeScence("Scence/Page4_Less1");//切換到Page4
		Default_1_1_Pic.gameObject.SetActive(false); //關閉預設的圖
		Change_1_2_Pic.gameObject.SetActive(true); //顯示玩家按下去後顯示的圖片
	}
	public void Change_2Pic()
	{
		Input.Write_Mark_Line ("Language=German",3,"C:\\Player_Setting.txt");
		Change_To_Scene.ChangeScence("Scence/Page4_Less1");//切換到Page4
		Default_2_1_Pic.gameObject.SetActive(false); //關閉預設的圖
		Change_2_2_Pic.gameObject.SetActive(true); //顯示玩家按下去後顯示的圖片
	}
	public void Change_3Pic()
	{
		Change_To_Scene.ChangeScence("Scence/Page5");//切換到Page5
		Default_3_1_Pic.gameObject.SetActive(false); //關閉預設的圖
		Change_3_2_Pic.gameObject.SetActive(true); //顯示玩家按下去後顯示的圖片
	}
	public void Back()
	{
		Change_To_Scene.ChangeScence("Scence/Page2");//切換到Page5
	}
}
