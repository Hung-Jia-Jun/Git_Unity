using UnityEngine;
using System.Collections;

public class Button_Lesson : MonoBehaviour {
	Lesson_Class Button_Click=new Lesson_Class();
	Input_class Input = new Input_class ();
	public GameObject First_Lesson_1_A; //選擇第一課位置一 A圖片
	public GameObject First_Lesson_1_B; //選擇第一課位置一 B圖片

	public GameObject First_Lesson_2_A; //選擇第一課位置二 A圖片
	public GameObject First_Lesson_2_B; //選擇第一課位置二 B圖片

	public GameObject Second_Lesson_1_A;//選擇第二課位置一 A圖片
	public GameObject Second_Lesson_1_B;//選擇第二課位置一 B圖片


	public GameObject Second_Lesson_2_A;//選擇第二課位置二 A圖片
	public GameObject Second_Lesson_2_B;//選擇第二課位置二 B圖片
	// Use this for initialization
	void Start () {
		First_Lesson_1_B.gameObject.SetActive(false);

		First_Lesson_2_B.gameObject.SetActive(false);

		Second_Lesson_1_B.gameObject.SetActive(false);

		Second_Lesson_2_B.gameObject.SetActive(false);

	}

	// Update is called once per frame
	void Update () {

	}
	public void Click_Button_First_Lesson()//當按下第一課按鈕時
	{
		Input.Write_Mark_Line ("Lesson=1",4,"C:\\Player_Setting.txt");
		First_Lesson_1_A.gameObject.SetActive(false);
		First_Lesson_1_B.gameObject.SetActive(true);

		First_Lesson_2_A.gameObject.SetActive(false);
		First_Lesson_2_B.gameObject.SetActive(true);

	}
	public void Click_Button_Second_Lesson()//當按下第二課按鈕時
	{
		Input.Write_Mark_Line ("Lesson=2",4,"C:\\Player_Setting.txt");
		Second_Lesson_1_A.gameObject.SetActive(false);
		Second_Lesson_1_B.gameObject.SetActive(true);

		Second_Lesson_2_A.gameObject.SetActive(false);
		Second_Lesson_2_B.gameObject.SetActive(true);

	}
	public void Back()
	{
		Application.LoadLevel("Scence/Page1");
	}
}
