using UnityEngine;
using System.Collections;

public class Lesson_Class
{
	public GameObject Default_1_1_Pic;//預設語言1圖片
	public GameObject  Change_1_2_Pic;//切換語言1圖片

	public GameObject Default_2_1_Pic;//預設語言2圖片
	public GameObject  Change_2_2_Pic;//切換語言2圖片

	public GameObject Default_3_1_Pic;//預設編輯語言圖片
	public GameObject  Change_3_2_Pic;//切換編輯語言圖片

	public GameObject Pic_F;//要顯示的F圖，詳情請看Docx文件
	public GameObject Pic_G;//要顯示的G圖，詳情請看Docx文件


	public GameObject HotelButton;//旅館button
	public GameObject ResturnButton;//餐廳button
	/***********************右側狀態顯示圖********************************/
	public GameObject LessPic;//要show的課程圖 圖A
	public GameObject ArraowPic_top;//較上面的指向圖 	  圖C
	public GameObject ArraowPic_down;//較下面指向圖 	  圖C
	public GameObject Lanugue_Pic;//語言圖	  圖B
	public GameObject WritePic;//寫入圖		  圖D
	/***********************右側狀態顯示圖********************************/

	void Start () {
		Default_1_1_Pic.gameObject.SetActive(true); //關閉預設的圖
		Change_1_2_Pic.gameObject.SetActive(false); //顯示玩家按下去後顯示的圖片

		Default_2_1_Pic.gameObject.SetActive(true); //關閉預設的圖
		Change_2_2_Pic.gameObject.SetActive(false); //顯示玩家按下去後顯示的圖片

		Default_3_1_Pic.gameObject.SetActive(true); //關閉預設的圖
		Change_3_2_Pic.gameObject.SetActive(false); //顯示玩家按下去後顯示的圖片

	}

	// Update is called once per frame
	void Update () {

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
	public void Click_Button_Lesson(/*第1.3張圖會關閉*/GameObject image1,/*第2.4張圖會開啟*/GameObject image2,GameObject image3,GameObject image4 )
	{
		image1.gameObject.SetActive(false);
		image2.gameObject.SetActive(true);
		image3.gameObject.SetActive(false);
		image4.gameObject.SetActive(true);
	}

}
