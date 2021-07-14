using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NpcTalk : MonoBehaviour
{
    public Text speak;
    public Text who;
    public Image whoImage;
    public Sprite[] change;
    public GameObject canves;
    public GameObject QandA;
    public bool clickOn = false;
    public lovePower loveP;
    public GameObject DagonT;
    public GameM gM;

    public GameObject YorN;

    public GameObject gOb;
    public GameObject sOb;
    public GameObject pOb;
    public GameObject nOb;

    public Text playerY;
    public Text playerN;
    public Text gText;
    public Text sText;
    public Text pText;
    public Text nText;

    public int what;



    void Start()
    {

        gM = FindObjectOfType<GameM>();
        loveP = GameObject.Find("DataM").GetComponent<DataM>().loveP;
        canves = GameObject.Find("Canvas");
        DagonT = canves.transform.Find("DrangonTMI").gameObject;
        DagonT.SetActive(false);
        whoImage = canves.transform.Find("whoIm").gameObject.GetComponent<Image>();
        speak = canves.transform.Find("Speak").gameObject.GetComponent<Text>();
        who = canves.transform.Find("Whoname").gameObject.GetComponent<Text>();
        QandA = canves.transform.Find("Answer").gameObject;
        YorN = canves.transform.Find("Answer2").gameObject;

        gOb = QandA.transform.Find("AnswerG").gameObject;
        sOb = QandA.transform.Find("AnswerS").gameObject;
        pOb = QandA.transform.Find("AnswerP").gameObject;
        nOb = QandA.transform.Find("AnswerN").gameObject;

        playerY = YorN.transform.Find("AnswerY").gameObject.transform.Find("Text").GetComponent<Text>();
        playerN = YorN.transform.Find("AnswerN").gameObject.transform.Find("Text").GetComponent<Text>();
        gText = gOb.transform.Find("Text").GetComponent<Text>();
        sText = sOb.transform.Find("Text").GetComponent<Text>();
        pText = pOb.transform.Find("Text").GetComponent<Text>();
        nText = nOb.transform.Find("Text").GetComponent<Text>();

        QandA.SetActive(false);
    }

    public void Oping()
    {
        gM.BackG.sprite = gM.ChangeB[5];
        whoImage.sprite = gM.change[11];
        who.text = "나";
        speak.text = " 와! 여기가 말로만 듣던 대구소프트웨어마이스터고등학교구나!!";
    }
    public void Oping1()
    {
        gM.BackG.sprite = gM.ChangeB[5];
        whoImage.sprite = gM.change[11];
        who.text = "나";
        speak.text = " 근데 시청각실이 어디에 있지? 저 선생님께 물어보자";
    }
    public void okAnswer() // 선생님
    {
        QandA.SetActive(true);
        gText.text = "강준호T";
        sText.text = "이승택T";
        pText.text = "김수민T";
        nText.text = "변강순T";

    }
    public void NClick()
    {
        QandA.SetActive(false);
        loveP.NlovePower();
        what = 1;
        loveP.casenumber++;

    }
    public void GClick()
    {
        QandA.SetActive(false);
        loveP.GlovePower();
        what = 2;
        loveP.casenumber++;

    }
    public void SClick()
    {
        QandA.SetActive(false);
        loveP.SlovePower();
        what = 3;
        loveP.casenumber++;

    }
    public void PClick()
    {
        QandA.SetActive(false);
        loveP.PlovePower();
        what = 4;
        loveP.casenumber++;
    }


    public void DagonTime()
    {
        DagonT.SetActive(true);

    }
    public void DagonTimeEnd()
    {
        DagonT.SetActive(false);

    }

    public void syYoung()
    {
        gM.BackG.sprite = gM.ChangeB[0];
        whoImage.sprite = gM.change[11];
        who.text = "system";
        speak.text = "입학식이 끝나고 난 지각하는 바람에 1대1 면담을 하게 되었다.";
    }
    public void younging()
    {
        gM.BackG.sprite = gM.ChangeB[4];
        whoImage.sprite = gM.change[5];
        who.text = "전용길 T";
        speak.text = "입학식부터 지각하다니 너무한 거 아니니";
    }
    public void younging1()
    {
        gM.BackG.sprite = gM.ChangeB[4];
        whoImage.sprite = gM.change[11];
        who.text = "나";
        speak.text = "죄송합니다...";
    }
    public void younging2()
    {
        gM.BackG.sprite = gM.ChangeB[4];
        whoImage.sprite = gM.change[5];
        who.text = "전용길 T";
        speak.text = "그래 다음부터 늦지말고" + "\n" + "학교에 대해 궁금한게 있니?";
    }
    public void QandA0()
    {
        playerY.text = "학교생활이 궁금해요.";
        playerN.text = "아니요 없어요.";

    }
    public void QandA1()
    {
        playerY.text = "<size=70>혹시 모르니" + "\n" + "한 번 들어보자.</size>";
        playerN.text = "<size=70>몰라 그시간에 난 놀래!</size>";
    }
    public void QandA2()
    {
        playerY.text = "<size=70>그래!" + "\n" + "내신 챙겨보자.</size>";
        playerN.text = "<size=70>몰라 그시간에 난  잘래!</size>";
    }
    public void QandA3()
    {
        playerY.text = "<size=70>한번" + "\n" + "참여해보자.</size>";
        playerN.text = "<size=70>1학년이 어떻게"+"\n"+"참여하겠어</size>";
    }

    public void QandA4()
    {
        playerY.text = "<size=70>1학기때 들었던 거구나" + "\n" + "한번 참여해보자.</size>";
        playerN.text = "<size=70>그게뭔데" + "\n" + "안해</size>";
    }
    public void sixMounth()
    {
        gM.BackG.sprite = gM.ChangeB[0];
        whoImage.sprite = gM.change[11];
        who.text = "System";
        speak.text = "어느덧 6월이 되어 설명회가 열렸다.";
    }
    public void sixMounth1()
    {
        gM.BackG.sprite = gM.ChangeB[0];
        whoImage.sprite = gM.change[11];
        who.text = "나";
        speak.text = "뭘 들을까?";
    }
    public void sixMounth2()
    {
        gM.BackG.sprite = gM.ChangeB[0];
        whoImage.sprite = gM.change[11];
        who.text = "System";
        speak.text = "그렇게 설명회를 듣고 생각을 하니 한달이 지났다";
    }

    public void yongingQ()
    {
        YorN.SetActive(true);
        QandA0();
    }
    public void yongingQEnd()
    {
        YorN.SetActive(false);

    }
    public void EvedQ()
    {
        YorN.SetActive(true);
        QandA1();

    }
    public void NasinE()
    {
        YorN.SetActive(true);
        QandA2();
    }

    public void NasinEnd()
    {
        YorN.SetActive(false);
    }

    public void ICTE()
    {
        YorN.SetActive(true);
        QandA3();
    }
    public void ICTEnd()
    {
        YorN.SetActive(false);
    }
    public void Game()
    {
        YorN.SetActive(true);
        QandA4();
    }

    public void GameEnd()
    {
        YorN.SetActive(false);
    }
    public void EvedEnd()
    {
        YorN.SetActive(false);


    }

    public void Narsh0() //2학년 1학기 나르샤
    {
        whoImage.sprite = gM.change[11];
        who.text = "나";
        speak.text = "벌써 나르샤를 정해야하는 구나" + "\n" + "시간이 참 빠르다";
    }

    public void Narsh1()
    {
        whoImage.sprite = gM.change[11];
        who.text = "나";
        speak.text = "이번년도에는 어떤 나르샤 프로젝트를 할까? "; //선택지 1. 소프트웨어관련 프로젝트 2. 임베디드관련 프로젝트
    }


    public void ChoseSubject0()// 2학년 선택과목 선택
    {
        whoImage.sprite = gM.change[0];
        who.text = "김동균 T";
        speak.text = "애들아 오늘 모이라 한 이유는 " + "\n" + "선택과목을 정하기 위해서란다";
    }
    public void ChoseSubject1()
    {
        whoImage.sprite = gM.change[0];
        who.text = "김동균 T";
        speak.text = "선택과목은 준호선생님이하는 C#과 " + "\n" + "승택쌤이하는 마이크로프로세서가 있단다 ";
    }
    public void ChoseSubject2()
    {
        whoImage.sprite = gM.change[11];
        who.text = "나";
        speak.text = "나는 뭘 선택하지? "; //선택지 1. C#(기능) 2. 마이크로프로세서
    }

    public void TwonGradeHackerton0() // 2학년 2학기 해커톤
    {
        whoImage.sprite = gM.change[0];
        who.text = "김동균 T";
        speak.text = "벌써 해커톤 시기가 다가왔구나";
    }
    public void TwonGradeHackerton1()
    {
        whoImage.sprite = gM.change[0];
        who.text = "김동균 T";
        speak.text = "해커톤팀빌딩을 할 거란다" + "\n" + "하고 싶은 주제를 선택 해서 팀빌딩을 해오렴";
    }
    public void TwonGradeHackerton2()
    {
        whoImage.sprite = gM.change[11];
        who.text = "나";
        speak.text = "해커톤 주제를 무엇으하지?"; // 선택 1. 소프트웨어 프로젝트(포플) 2. 임베디드 프로젝트(임베)
    }


    public void OneIndustryUniversityClass1() // 3학년 산학 프로잭트 4월 5월
    {
        whoImage.sprite = gM.change[0];
        who.text = "김동균 T ";
        speak.text = "3학년들은 산학 프로잭트 활동을 하게 됩니다." + "\n" + "2학년 때와 마찬가지로 주제를 정하여 프로젝트를 진행하시면 됩니다";
    }
    public void OneIndustryUniversityClass2()
    {
        whoImage.sprite = gM.change[0];
        who.text = "김동균 T ";
        speak.text = "4월달과 5월 동안 프로잭트를 진행하게 됩니다" + "\n" + "총 두가지의 프로젝트를 진행하면 됩니다";
    }
    public void OneIndustryUniversityClass3()
    {
        whoImage.sprite = gM.change[0];
        who.text = "김동균 T ";
        speak.text = "4월 달 프로젝트 주제를 선정하여 알려주시기 바랍니다"; // 선택지 1. 소프트웨어 프로젝트(포플) 2. 임베디드 프로젝트
    }
    public void OneIndustryUniversityClass4()
    {
        whoImage.sprite = gM.change[0];
        who.text = "김동균 T ";
        speak.text = "5월 달 프로젝트 주제를 선정하여 알려주시기 바랍니다"; // 선택지 1. 소프트웨어 프로젝트(포플) 2. 임베디드 프로젝트
    }


}