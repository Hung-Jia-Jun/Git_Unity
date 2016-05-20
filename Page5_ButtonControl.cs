using UnityEngine;
using System.Collections;

public class Page5_ButtonControl : MonoBehaviour {
	/***********************右側狀態顯示圖********************************/
	public GameObject LessPic;//要show的課程圖 圖A
	public GameObject ArraowPic_top;//較上面的指向圖 	  圖C
	public GameObject ArraowPic_down;//較下面指向圖 	  圖C
	public GameObject Lanugue_Pic;//語言圖	  圖B
	public GameObject WritePic;//寫入圖		  圖D
	/***********************右側狀態顯示圖********************************/

	// Use this for initialization
	void Start () {
		LessPic.SetActive (false);
		ArraowPic_top.SetActive (false);
		ArraowPic_down.SetActive (false);
		Lanugue_Pic.SetActive (false);
		WritePic.SetActive (false);
	}

	void Update () {

	}
	public void Button_LessPic_Control(bool LessPic_Bool)//用訊息方式決定是否開啟button
	{
		LessPic.SetActive (LessPic_Bool);
	}
	public void Button_ArraowPic_top_Control(bool ArraowPic_top_Bool)
	{
		ArraowPic_top.SetActive (ArraowPic_top_Bool);
	}
	public void Button_LanuguePic_Control(bool Lanugue_Pic_Bool)
	{
		Lanugue_Pic.SetActive (Lanugue_Pic_Bool);
	}
	public void Button_ArraowPic_down_Control(bool ArraowPic_down_Bool)
	{
		ArraowPic_down.SetActive (ArraowPic_down_Bool);
	}
	public void Button_WritePic_Control(bool WritePic_Bool)
	{
		WritePic.SetActive (WritePic_Bool);
	}

}
