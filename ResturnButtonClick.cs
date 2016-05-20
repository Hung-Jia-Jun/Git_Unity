using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;// 使用事件系統
public class ResturnButtonClick : MonoBehaviour{
	public GameObject HotelButton;//餐廳button
	public GameObject ResturnButton;//餐廳button
	public GameObject Pic_G;//要顯示的G圖，詳情請看Docx文件
	public GameObject Player_Edit_Hotel;//使用者自訂輸入區
	public GameObject Player_Edit_Resturn;//使用者自訂輸入區

	public void PointerClick()//滑鼠按下事件
	{
		Player_Edit_Resturn.SetActive (true);//開啟餐廳的編輯區
		Player_Edit_Hotel.SetActive (false);//關閉旅館的編輯區
		Pic_G.SetActive (true);//開啟餐廳的圖片
		HotelButton.SetActive (false);//關閉旅館的button
		ResturnButton.SetActive (false);
	}

}
