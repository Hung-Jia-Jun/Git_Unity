using UnityEngine;
using System.Collections;
using System.IO;
using UnityEngine.UI;
public class Input_class
{

	public string message;
	public GameObject[] Button;
	public InputField InputField;
	bool WriteMode;
	public void Clear_Text() //清空文字框
	{
		InputField.text = "";
	}

	public void WriteToTxtFile(string Message)
	{
		WriteFile (Message, "C:\\Sound_Str.txt",/*WriteMode寫入模式*/true);
	}

	public void WriteFile(string message,string TxtLocation,bool WriteMode)
	{
		//文件流訊息
		StreamWriter sw=new StreamWriter(TxtLocation,WriteMode); //範例格式:"C:\\A.txt"
		sw.WriteLine(message);
		//sw.WriteLine("\n");

		//關閉資料流
		sw.Close();
		//銷毀資料流
		sw.Dispose();
	}
}

