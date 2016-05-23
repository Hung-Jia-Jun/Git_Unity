using UnityEngine;
using System.Collections;

public class P2_Control : MonoBehaviour {
	Input_class Input = new Input_class ();

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	public void User_Control_Mouse()
	{
		Input.Write_Mark_Line ("Player Control=Mouse And KeyBord",1,"C:\\Player_Setting.txt");
	}
	public void User_Control_JoyStick()
	{
		Input.Write_Mark_Line ("Player Control=Rocker And headset",1,"C:\\Player_Setting.txt");
	}
	public void Back()//返回紐
	{
		Application.LoadLevel("Scence/Page1");
	}
}
