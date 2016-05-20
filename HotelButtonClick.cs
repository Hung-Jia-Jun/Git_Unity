using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;// 使用事件系統
public class HotelButtonClick : MonoBehaviour{
	public GameObject HotelButton;//旅館button
	public GameObject Pic_F;//要顯示的F圖，詳情請看Docx文件
	public GameObject ResturnButton;//餐廳button
	public GameObject Player_Edit_Hotel;//使用者自訂輸入區
	public GameObject Player_Edit_Resturn;//使用者自訂輸入區
	public void PointerClick()//滑鼠按下事件
	{
		Player_Edit_Hotel.SetActive (true);
		Player_Edit_Resturn.SetActive (false);
		Pic_F.SetActive (true);//開啟旅館的UI圖
		ResturnButton.SetActive (false);//關閉餐廳的按鈕
		HotelButton.SetActive (false);
	}

}
