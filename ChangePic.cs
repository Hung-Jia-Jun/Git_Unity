using UnityEngine;
using System.Collections;

public class ChangePic : MonoBehaviour
{
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
		Default_1_1_Pic.gameObject.SetActive(false); //關閉預設的圖
		Change_1_2_Pic.gameObject.SetActive(true); //顯示玩家按下去後顯示的圖片
	}
	public void Change_2Pic()
	{
		Default_2_1_Pic.gameObject.SetActive(false); //關閉預設的圖
		Change_2_2_Pic.gameObject.SetActive(true); //顯示玩家按下去後顯示的圖片
	}
	public void Change_3Pic()
	{
		Default_3_1_Pic.gameObject.SetActive(false); //關閉預設的圖
		Change_3_2_Pic.gameObject.SetActive(true); //顯示玩家按下去後顯示的圖片
	}
}
