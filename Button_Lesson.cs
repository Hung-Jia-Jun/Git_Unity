using UnityEngine;
using System.Collections;

public class Button_Lesson : MonoBehaviour {
	Lesson_Class Button_Click=new Lesson_Class();
	public GameObject First_Lesson_A_1; //選擇第一課 A圖片
	public GameObject First_Lesson_B_2; //選擇第一課 B圖片

	public GameObject Second_Lesson_A_1;//選擇第二課 A圖片
	public GameObject Second_Lesson_B_2;//選擇第二課 B圖片

	public GameObject First_Lesson_A_3; //選擇第一課 A圖片
	public GameObject First_Lesson_B_4; //選擇第一課 B圖片

	public GameObject Second_Lesson_A_3;//選擇第二課 A圖片
	public GameObject Second_Lesson_B_4;//選擇第二課 B圖片
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	public void Click_Button_First_Lesson()
	{
		Button_Click.Click_Button_Lesson(First_Lesson_A_1,First_Lesson_B_2,First_Lesson_A_3,First_Lesson_B_4);
	}
	public void Click_Button_Second_Lesson()
	{
		Button_Click.Click_Button_Lesson(Second_Lesson_A_1,Second_Lesson_B_2,Second_Lesson_A_3,Second_Lesson_B_4);
	}

}
