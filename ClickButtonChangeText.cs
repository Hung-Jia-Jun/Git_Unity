using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class ClickButtonChangeText : MonoBehaviour {
	public GameObject System_Simple_Text;//要切換的文字物件
	public string chinese;//中文
	public string Germen;//德文
	public bool Germen_Lanauge=false;//切換語言
	void Start ()
	{
		System_Talk(chinese);
	}
	void Update ()
	{
	}
	public void Button_Click()
		{
			if (Germen_Lanauge==false)
			{
				System_Talk(Germen);
				Germen_Lanauge=true;
			}
			else
			{
				System_Talk (chinese);
				Germen_Lanauge=false;
			}

		}
	public void	System_Talk(string Text_Show)
		{
			System_Simple_Text.GetComponentInChildren<Text> ().text = Text_Show;
		}
}
