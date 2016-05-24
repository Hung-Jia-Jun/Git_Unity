using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Edit_Mode_NPCFeedBackOnTrigger : MonoBehaviour {
    Change_Scene_Class Read_File =new Change_Scene_Class();//從Change_Scene_Class抓取出Read File參考
    Scence1CatchRecog RecogText =new Scence1CatchRecog();//從語音辨識的腳本取出辨識功能
    public TextAsset Scence1_txt;//導入Txt
    public string TxtRecognize;
	public string Sound_Str_Content;//文字劇本檔內容
    public Camera[] CameraArray;//相機陣列
    public Animator Waiter;//服務生的動畫控制器
    public bool PlayerTalkText;//玩家說話框
    public bool WaiterTalkText;//服務生說話控制
    public GUIStyle btnStyle;//宣告上下一步按鈕style
    public int PlayerSwitch=1;//每次要說的話都放在這邊
    public GameObject NextButton;//下一步按鈕是否顯示
    public GameObject BackButton;//上一步按鈕是否顯示
    public GameObject ExitButton;//上一步按鈕是否顯示
	public GameObject RecognizeTextObj;//語音辨識的物件
    public GameObject Recognize_Button;//語音辨識按鈕
	public bool RecgStatus;//偵測辨識結果
    //---------------------------------------------------------------
    public GameObject NPCTextBox_BackGround;//NPC對話框背景
	public GameObject RecogTextBox;//語音辨識結果
    public GameObject NPCTextBox;//NPC要講的話，去文字檔動態產生
    public GameObject PlayerTextBox_BackGround;//玩家對話框背景
    public GameObject PlayerTextBox;//玩家要講的話，去文字檔動態產生
    //---------------------------------------------------------------

    public float Timer = 0f;

    void Start () {

        RecogTextBox.GetComponentInChildren<Text> ().text ="";
        RecognizeTextObj=GameObject.Find("RecognizeTextObj");//語音辨識之比對物件
        RecogTextBox=GameObject.Find("RecogTextBox");//語音辨識結果顯示窗
		Recognize_Button=GameObject.Find("Recognize");//語音辨識結果顯示窗
        //-------------------------------------------------------------------------------------------
        NPCTextBox_BackGround = GameObject.Find("NPCTalkText_Background");//NPC對話框背景
        PlayerTextBox_BackGround=GameObject.Find("PlayerTalkText_Background");//玩家對話框背景
        //-------------------------------------------------------------------------------------------
        NPCTextBox_BackGround.gameObject.SetActive(false);//關閉對話框物件
        PlayerTextBox_BackGround.gameObject.SetActive(false);//關閉對話框物件

    }

    void Update () {
        Timer = Timer + Time.deltaTime;
        TxtRecognize = Scence1_txt.text;//設定要辨識的字元來自於文字檔
        print (TxtRecognize);
    }

    void OnTriggerEnter (Collider other)
    {
        if(other.name == "FPSController")
        {
            CameraArray[0].gameObject.SetActive(false);//主角相機關
            CameraArray[1].gameObject.SetActive(true);//NPC相機開
            NPCTextBox_BackGround.gameObject.SetActive(true);//關閉對話框物件
            PlayerTextBox_BackGround.gameObject.SetActive(true);//關閉對話框物件

            Waiter.SetBool("Hellow", true);//宣告hellow動畫播放
            PlayerSwitch = 1;
        }
    }
    void OnGUI()
    {


     switch (PlayerSwitch)
        {
            case 0:
                {
                    Timer = 0;//設定計時器為0

                    break;
                }
            case 1:
                {
                 Sound_Str_Content=Read_File.ReadFile(/*檔案路徑*/"C:\\Sound_Str.txt",/*讀取第幾行*/PlayerSwitch);

                    Call_Txt_To_Talk(/*讀取對像NPC或是Player*/"NPC",/*Message去讀取的內容*/Sound_Str_Content);

                    if (Timer > 5)
                    {
                        PlayerSwitch++;
                        Timer = 0f;
                    }
                break;
                }
            case 2:
                {
                 Sound_Str_Content=Read_File.ReadFile(/*檔案路徑*/"C:\\Sound_Str.txt",/*讀取第幾行*/PlayerSwitch);

                    Call_Txt_To_Talk(/*讀取對像NPC或是Player*/"Player",/*Message去讀取的內容*/Sound_Str_Content);

                    if (Timer > 10)
                    {
                       SwitchRecognizeOk(/*語音辨識內容*/Read_File.ReadFile(/*檔案路徑*/"C:\\Sound_Str.txt",/*讀取第幾行*/PlayerSwitch));//傳入語音辨識驗證使用者的話
                    }
                    //ButtonUI(/*ShowNext*/false,/*ShowBack*/true,/*ShowExit*/false);//玩家可返回上一步

                    break;
                }
            case 3:
                {
                 Sound_Str_Content=Read_File.ReadFile(/*檔案路徑*/"C:\\Sound_Str.txt",/*讀取第幾行*/PlayerSwitch);

                    Call_Txt_To_Talk(/*讀取對像NPC或是Player*/"NPC",/*Message去讀取的內容*/Sound_Str_Content);

                    //ButtonUI(/*ShowNext*/false,/*ShowBack*/true,/*ShowExit*/false);//UIButton顯示設定
                    if (Timer > 3)
                    {
                        PlayerSwitch++;
                        Timer = 0f;
                        RecogTextBox.GetComponentInChildren<Text> ().text ="";
                    }
                    break;
                }
            case 4:
                {
                 Sound_Str_Content=Read_File.ReadFile(/*檔案路徑*/"C:\\Sound_Str.txt",/*讀取第幾行*/PlayerSwitch);

                    Call_Txt_To_Talk(/*讀取對像NPC或是Player*/"Player",/*Message去讀取的內容*/Sound_Str_Content);

                    if (Timer > 10)
                    {
                        SwitchRecognizeOk(/*語音辨識內容*/Read_File.ReadFile(/*檔案路徑*/"C:\\Sound_Str.txt",/*讀取第幾行*/PlayerSwitch));//傳入語音辨識驗證使用者的話
                    }
                    //ButtonUI(/*ShowNext*/false,/*ShowBack*/true,/*ShowExit*/false);//玩家可返回上一步


                    break;
                }
            case 5:
                {
                 Sound_Str_Content=Read_File.ReadFile(/*檔案路徑*/"C:\\Sound_Str.txt",/*讀取第幾行*/PlayerSwitch);

                    Call_Txt_To_Talk(/*讀取對像NPC或是Player*/"NPC",/*Message去讀取的內容*/Sound_Str_Content);



                    //ButtonUI(/*ShowNext*/false,/*ShowBack*/true,/*ShowExit*/false);//UIButton顯示設定
                    if (Timer > 5)
                    {
                        PlayerSwitch++;
                        Timer = 0f;
                    }
                     break;
                }
            case 6:
                {
                 Sound_Str_Content=Read_File.ReadFile(/*檔案路徑*/"C:\\Sound_Str.txt",/*讀取第幾行*/PlayerSwitch);

                    Call_Txt_To_Talk(/*讀取對像NPC或是Player*/"Player",/*Message去讀取的內容*/Sound_Str_Content);






                    if (Timer > 10)
                    {
                    SwitchRecognizeOk(/*語音辨識內容*/Read_File.ReadFile(/*檔案路徑*/"C:\\Sound_Str.txt",/*讀取第幾行*/PlayerSwitch));//傳入語音辨識驗證使用者的話
                    }
                    //ButtonUI(/*ShowNext*/false,/*ShowBack*/true,/*ShowExit*/false);//可返回上一步


                    break;
                }
            case 7:
                {
                 Sound_Str_Content=Read_File.ReadFile(/*檔案路徑*/"C:\\Sound_Str.txt",/*讀取第幾行*/PlayerSwitch);

                    Call_Txt_To_Talk(/*讀取對像NPC或是Player*/"NPC",/*Message去讀取的內容*/Sound_Str_Content);




                    //ButtonUI(/*ShowNext*/false,/*ShowBack*/true,/*ShowExit*/false);//UIButton顯示設定
                    if (Timer > 5)
                    {

                        Timer = 0f;
                        PlayerSwitch++;
                    }
                    break;
                }
            case 8:
                {
                 Sound_Str_Content=Read_File.ReadFile(/*檔案路徑*/"C:\\Sound_Str.txt",/*讀取第幾行*/PlayerSwitch);

                    Call_Txt_To_Talk(/*讀取對像NPC或是Player*/"NPC",/*Message去讀取的內容*/Sound_Str_Content);





                    //ButtonUI(/*ShowNext*/false,/*ShowBack*/true,/*ShowExit*/false);//UIButton顯示設定
                    if (Timer > 5)
                    {
                        Timer = 0f;
                        PlayerSwitch++;
                    }
                    break;
                }
            case 9:
                {
                 Sound_Str_Content=Read_File.ReadFile(/*檔案路徑*/"C:\\Sound_Str.txt",/*讀取第幾行*/PlayerSwitch);

                    Call_Txt_To_Talk(/*讀取對像NPC或是Player*/"Player",/*Message去讀取的內容*/Sound_Str_Content);







                    if (Timer > 10)
                    {
                        SwitchRecognizeOk(/*語音辨識內容*/Read_File.ReadFile(/*檔案路徑*/"C:\\Sound_Str.txt",/*讀取第幾行*/PlayerSwitch));//傳入語音辨識驗證使用者的話
                    }
                    //ButtonUI(/*ShowNext*/false,/*ShowBack*/true,/*ShowExit*/true);//UIButton顯示設定

                    break;


                }
            case 10:
                {
                 Sound_Str_Content=Read_File.ReadFile(/*檔案路徑*/"C:\\Sound_Str.txt",/*讀取第幾行*/PlayerSwitch);

                    Call_Txt_To_Talk(/*讀取對像NPC或是Player*/"NPC",/*Message去讀取的內容*/Sound_Str_Content);




                    //ButtonUI(/*ShowNext*/false,/*ShowBack*/true,/*ShowExit*/false);//UIButton顯示設定
                    if (Timer > 5)
                    {
                        PlayerSwitch++;
                        Timer = 0f;
                    }
                    break;
                }
            case 11:
                {
                 Sound_Str_Content=Read_File.ReadFile(/*檔案路徑*/"C:\\Sound_Str.txt",/*讀取第幾行*/PlayerSwitch);

                    Call_Txt_To_Talk(/*讀取對像NPC或是Player*/"Player",/*Message去讀取的內容*/Sound_Str_Content);






                    if (Timer > 10)
                    {
                        SwitchRecognizeOk(/*語音辨識內容*/Read_File.ReadFile(/*檔案路徑*/"C:\\Sound_Str.txt",/*讀取第幾行*/PlayerSwitch));//傳入語音辨識驗證使用者的話
                    }
                    //ButtonUI(/*ShowNext*/false,/*ShowBack*/true,/*ShowExit*/false);//UIButton顯示設定

                    break;
                }
            case 12:
                {
                 Sound_Str_Content=Read_File.ReadFile(/*檔案路徑*/"C:\\Sound_Str.txt",/*讀取第幾行*/PlayerSwitch);

                    Call_Txt_To_Talk(/*讀取對像NPC或是Player*/"NPC",/*Message去讀取的內容*/Sound_Str_Content);




                    //ButtonUI(/*ShowNext*/false,/*ShowBack*/true,/*ShowExit*/false);//UIButton顯示設定
                    if (Timer > 5)
                    {
                        PlayerSwitch++;
                        Timer = 0f;
                    }
                    break;
                }
            case 13:
                {
                 Sound_Str_Content=Read_File.ReadFile(/*檔案路徑*/"C:\\Sound_Str.txt",/*讀取第幾行*/PlayerSwitch);

                    Call_Txt_To_Talk(/*讀取對像NPC或是Player*/"Player",/*Message去讀取的內容*/Sound_Str_Content);






                    if (Timer > 10)
                    {
                        SwitchRecognizeOk(/*語音辨識內容*/Read_File.ReadFile(/*檔案路徑*/"C:\\Sound_Str.txt",/*讀取第幾行*/PlayerSwitch));//傳入語音辨識驗證使用者的話
                    }
                    //ButtonUI(/*ShowNext*/false,/*ShowBack*/true,/*ShowExit*/false);//UIButton顯示設定

                    break;
                }
            case 14:
                {
                 Sound_Str_Content=Read_File.ReadFile(/*檔案路徑*/"C:\\Sound_Str.txt",/*讀取第幾行*/PlayerSwitch);

                    Call_Txt_To_Talk(/*讀取對像NPC或是Player*/"NPC",/*Message去讀取的內容*/Sound_Str_Content);




                    //ButtonUI(/*ShowNext*/false,/*ShowBack*/true,/*ShowExit*/false);//UIButton顯示設定
                    if (Timer > 5)
                    {
                        PlayerSwitch++;
                        Timer = 0f;
                    }
                    break;
                }
            case 15:
                {
                 Sound_Str_Content=Read_File.ReadFile(/*檔案路徑*/"C:\\Sound_Str.txt",/*讀取第幾行*/PlayerSwitch);

                    Call_Txt_To_Talk(/*讀取對像NPC或是Player*/"Player",/*Message去讀取的內容*/Sound_Str_Content);






                    if (Timer > 10)
                    {
                        SwitchRecognizeOk(/*語音辨識內容*/Read_File.ReadFile(/*檔案路徑*/"C:\\Sound_Str.txt",/*讀取第幾行*/PlayerSwitch));//傳入語音辨識驗證使用者的話
                    }
                    //ButtonUI(/*ShowNext*/false,/*ShowBack*/true,/*ShowExit*/false);//UIButton顯示設定

                    break;
                }
            case 16:
                {
                 Sound_Str_Content=Read_File.ReadFile(/*檔案路徑*/"C:\\Sound_Str.txt",/*讀取第幾行*/PlayerSwitch);

                    Call_Txt_To_Talk(/*讀取對像NPC或是Player*/"NPC",/*Message去讀取的內容*/Sound_Str_Content);




                    //ButtonUI(/*ShowNext*/false,/*ShowBack*/true,/*ShowExit*/false);//UIButton顯示設定
                    if (Timer > 5)
                    {
                        PlayerSwitch++;
                        Timer = 0f;
                    }
                    break;
                }
            case 17:
                {
                 Sound_Str_Content=Read_File.ReadFile(/*檔案路徑*/"C:\\Sound_Str.txt",/*讀取第幾行*/PlayerSwitch);

                    Call_Txt_To_Talk(/*讀取對像NPC或是Player*/"Player",/*Message去讀取的內容*/Sound_Str_Content);






                    if (Timer > 10)
                    {
                        SwitchRecognizeOk(/*語音辨識內容*/Read_File.ReadFile(/*檔案路徑*/"C:\\Sound_Str.txt",/*讀取第幾行*/PlayerSwitch));//傳入語音辨識驗證使用者的話
                    }
                    //ButtonUI(/*ShowNext*/false,/*ShowBack*/true,/*ShowExit*/false);//UIButton顯示設定

                    break;
                }
            case 18:
                {
                 Sound_Str_Content=Read_File.ReadFile(/*檔案路徑*/"C:\\Sound_Str.txt",/*讀取第幾行*/PlayerSwitch);

                    Call_Txt_To_Talk(/*讀取對像NPC或是Player*/"NPC",/*Message去讀取的內容*/Sound_Str_Content);




                    //ButtonUI(/*ShowNext*/false,/*ShowBack*/true,/*ShowExit*/false);//UIButton顯示設定
                    if (Timer > 5)
                    {
                        PlayerSwitch++;
                        Timer = 0f;
                    }
                    break;
                }
            case 19:
                {
                 Sound_Str_Content=Read_File.ReadFile(/*檔案路徑*/"C:\\Sound_Str.txt",/*讀取第幾行*/PlayerSwitch);

                    Call_Txt_To_Talk(/*讀取對像NPC或是Player*/"Player",/*Message去讀取的內容*/Sound_Str_Content);






                    if (Timer > 10)
                    {
                        SwitchRecognizeOk(/*語音辨識內容*/Read_File.ReadFile(/*檔案路徑*/"C:\\Sound_Str.txt",/*讀取第幾行*/PlayerSwitch));//傳入語音辨識驗證使用者的話
                    }
                    //ButtonUI(/*ShowNext*/false,/*ShowBack*/true,/*ShowExit*/false);//UIButton顯示設定

                    break;
                }
            case 20:
                {
                 Sound_Str_Content=Read_File.ReadFile(/*檔案路徑*/"C:\\Sound_Str.txt",/*讀取第幾行*/PlayerSwitch);

                    Call_Txt_To_Talk(/*讀取對像NPC或是Player*/"NPC",/*Message去讀取的內容*/Sound_Str_Content);




                    //ButtonUI(/*ShowNext*/false,/*ShowBack*/true,/*ShowExit*/false);//UIButton顯示設定
                    if (Timer > 5)
                    {
                        PlayerSwitch++;
                        Timer = 0f;
                    }
                    break;
                }
            case 21:
                {
                    Sound_Str_Content=Read_File.ReadFile(/*檔案路徑*/"C:\\Sound_Str.txt",/*讀取第幾行*/PlayerSwitch);

                    Call_Txt_To_Talk(/*讀取對像NPC或是Player*/"Player",/*Message去讀取的內容*/Sound_Str_Content);






                    if (Timer > 10)
                    {
                        SwitchRecognizeOk(/*語音辨識內容*/Read_File.ReadFile(/*檔案路徑*/"C:\\Sound_Str.txt",/*讀取第幾行*/PlayerSwitch));//傳入語音辨識驗證使用者的話
                    }
                    //ButtonUI(/*ShowNext*/false,/*ShowBack*/true,/*ShowExit*/false);//UIButton顯示設定

                    break;
                }
            case 22:
                {
                 Sound_Str_Content=Read_File.ReadFile(/*檔案路徑*/"C:\\Sound_Str.txt",/*讀取第幾行*/PlayerSwitch);

                    Call_Txt_To_Talk(/*讀取對像NPC或是Player*/"NPC",/*Message去讀取的內容*/Sound_Str_Content);




                    //ButtonUI(/*ShowNext*/false,/*ShowBack*/true,/*ShowExit*/false);//UIButton顯示設定
                    if (Timer > 5)
                    {
                        PlayerSwitch++;
                        Timer = 0f;
                    }
                    break;
                }
            case 23:
                {
                 Sound_Str_Content=Read_File.ReadFile(/*檔案路徑*/"C:\\Sound_Str.txt",/*讀取第幾行*/PlayerSwitch);

                    Call_Txt_To_Talk(/*讀取對像NPC或是Player*/"Player",/*Message去讀取的內容*/Sound_Str_Content);






                    if (Timer > 10)
                    {
                        SwitchRecognizeOk(/*語音辨識內容*/Read_File.ReadFile(/*檔案路徑*/"C:\\Sound_Str.txt",/*讀取第幾行*/PlayerSwitch));//傳入語音辨識驗證使用者的話
                    }
                    //ButtonUI(/*ShowNext*/false,/*ShowBack*/true,/*ShowExit*/false);//UIButton顯示設定

                    break;
                }
            case 24:
                {
                 Sound_Str_Content=Read_File.ReadFile(/*檔案路徑*/"C:\\Sound_Str.txt",/*讀取第幾行*/PlayerSwitch);

                    Call_Txt_To_Talk(/*讀取對像NPC或是Player*/"NPC",/*Message去讀取的內容*/Sound_Str_Content);




                    //ButtonUI(/*ShowNext*/false,/*ShowBack*/true,/*ShowExit*/false);//UIButton顯示設定
                    if (Timer > 5)
                    {
                        PlayerSwitch++;
                        Timer = 0f;
                    }
                    break;
                }
            case 25:
                {
                    Sound_Str_Content=Read_File.ReadFile(/*檔案路徑*/"C:\\Sound_Str.txt",/*讀取第幾行*/PlayerSwitch);
                    Call_Txt_To_Talk(/*讀取對像NPC或是Player*/"Player",/*Message去讀取的內容*/Sound_Str_Content);






                    if (Timer > 10)
                    {
						SwitchRecognizeOk(/*語音辨識內容*/Sound_Str_Content);//傳入語音辨識驗證使用者的話
                    }
                    //ButtonUI(/*ShowNext*/false,/*ShowBack*/true,/*ShowExit*/false);//UIButton顯示設定

                    break;
                }
            case 26:
                {
				    Sound_Str_Content=Read_File.ReadFile(/*檔案路徑*/"C:\\Sound_Str.txt",/*讀取第幾行*/PlayerSwitch);
					Call_Txt_To_Talk(/*讀取對像NPC或是Player*/"NPC",/*Message去讀取的內容*/Sound_Str_Content);
                    //ButtonUI(/*ShowNext*/false,/*ShowBack*/true,/*ShowExit*/true);//UIButton顯示設定

                    break;
                }
            case 27: //離開鍵的狀態釋放區
                {
                    //ButtonUI(/*ShowNext*/false,/*ShowBack*/false,/*ShowExit*/false);//UIButton顯示設定
                    CameraArray[0].gameObject.SetActive(true);//主角相機關
                    CameraArray[1].gameObject.SetActive(false);//NPC相機開
                    break;
                }
		}
		}


public void ButtonUI(bool ShowNext,bool ShowBack,bool ShowExit)//按鈕控制
{
	NextButton.gameObject.SetActive(ShowNext);//顯示下一步按鈕
	BackButton.gameObject.SetActive(ShowBack);//顯示上一步按鈕
	ExitButton.gameObject.SetActive(ShowExit);//顯示退出按鈕
}
public void NextButtonClick()//下一步
{

	PlayerSwitch++;//玩家對話狀態+1
	//CloseAllTextBox();//每次畫面刷新都先關閉所有物件
}
public void BackButtonClick()//上一步
{
	PlayerSwitch--;//玩家對話狀態-1
	//CloseAllTextBox();//每次畫面刷新都先關閉所有物件


}
public void ExitButtonClick()//退出
{

	PlayerSwitch = 27;//離開鍵的狀態釋放區
	//CloseAllTextBox();//每次畫面刷新都先關閉所有物件

	CameraArray[0].gameObject.SetActive(true);//主角相機開
	CameraArray[1].gameObject.SetActive(false);//NPC相機關


}


public void Call_Txt_To_Talk(/*NPC或是Player*/ string Select,/*Message*/string Message)//顧客要說的話
{
    if (Select=="NPC")
    {
        NPCTextBox.GetComponentInChildren<Text> ().text = Message;//說話內容
    }
    else
    {
        PlayerTextBox.GetComponentInChildren<Text> ().text = Message;//說話內容
    }
}
public void SwitchRecognizeOk(string message)//傳入語音辨識驗證使用者的話
{

	RecgStatus=RecogText.CheckRecog(message);//回傳辨識結果

	Timer=0.0f;
	if(RecgStatus==true)
	{
		RecogTextBox.GetComponentInChildren<Text>().text ="辨識成功!!!";
		PlayerSwitch++;//下一步
		RecgStatus=false;//清空辨識結果
	}
	else
	{

		RecogTextBox.GetComponentInChildren<Text> ().text ="辨識失敗!!!";
	}

}


}

