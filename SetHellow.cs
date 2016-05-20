using UnityEngine;
using System.Collections;

public class SetHellow : MonoBehaviour {
	public Animator Waiter;//服務生的動畫控制器
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter()
	{

		Waiter.SetBool("Hellow",false);//當玩家再次靠近npc時

	}
}
