using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class StrWrite : MonoBehaviour
{
	Input_class Input = new Input_class ();
	public Text PlayerEditStr; //抓取這個物件裡面的值寫入TXT
	public InputField PlayerCompontet;
	public GameObject Write;
	public GameObject Clear;
	public InputField InputField;
	public string IsUser;
	void Start()
	{
		Input.WriteFile ("","C:\\Sound_Str.txt",/*WriteMode寫入模式*/false);//先完全清空文字檔
	}



	public void inputStr()
	{
		IsUser = InputField.text;
		IsUser.ToString ();
		if (InputField.text=="")
		{
			Debug.Log("none Text");
		}
		else
		{
			Input.WriteToTxtFile (IsUser);
		}
	}

	public void Close_Clear_Button()
	{
		Write.gameObject.SetActive(true); //當寫入按鈕顯現時
		Clear.gameObject.SetActive(false);//關閉清空欄位
	}
	public void Close_Write_Button()
	{
		Write.gameObject.SetActive(false);
		Clear.gameObject.SetActive(true);
	}
	public void Clear_Text()
	{
		InputField.text = "";
	}
	public void Clear_Txt_File_Content()
	{
		Input.WriteFile ("Str_Content_None","C:\\Sound_Str.txt",/*WriteMode寫入模式*/false);//先完全清空文字檔
	}
	public void Clear_Tag_Mode_Content()
	{
		Input.WriteFile ("Player Control=","C:\\Player_Setting.txt",/*WriteMode寫入模式*/false);//先完全清空文字檔
		Input.WriteFile ("Scenes Mode=","C:\\Player_Setting.txt",/*WriteMode寫入模式*/true);//先完全清空文字檔
		Input.WriteFile ("Language=","C:\\Player_Setting.txt",/*WriteMode寫入模式*/true);//先完全清空文字檔
		Input.WriteFile ("Lesson=","C:\\Player_Setting.txt",/*WriteMode寫入模式*/true);//先完全清空文字檔
	}
	public void Back()
	{
		Application.LoadLevel("Scence/Page1");
	}
}
