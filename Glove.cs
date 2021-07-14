using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Glove : MonoBehaviour
{

    public Text speak;
    public Text who;
    public Image whoImage;
    public Sprite[] change;
    public GameObject canves;
    public GameObject QandA;
    public bool clickOn = false;
    public lovePower loveP;
    public GameM gM;


    void Start()
    {
        string[] Sprite = new string[4];
        gM = FindObjectOfType<GameM>();
        loveP = GameObject.Find("DataM").GetComponent<DataM>().loveP;
        canves = GameObject.Find("Canvas");
        whoImage = canves.transform.Find("whoIm").gameObject.GetComponent<Image>();
        speak = canves.transform.Find("Speak").gameObject.GetComponent<Text>();
        who = canves.transform.Find("Whoname").gameObject.GetComponent<Text>();
        QandA = canves.transform.Find("Answer").gameObject;
        QandA.SetActive(false);
    }

    public void SpeakAdmission0()
    {
        whoImage.sprite = gM.change[11];
        who.text = "나";
        speak.text = "저 혹시 시청각실이 어디 있나요?";
    }

    public void SpeakAdmission1()
    {
        whoImage.sprite = gM.change[10];
        who.text = "강준호 T";
        speak.text = "시청각실은 저쪽으로 가면 있단다.";
    }

    public void SpeakAdmission2()
    {
        whoImage.sprite = gM.change[10];
        who.text = "강준호 T";
        speak.text = "지금 빨리 가보렴 시간이 늦었단다";

    }

    public void SpeakAdmission3()
    {
        whoImage.sprite = gM.change[11];
        who.text = "나";
        speak.text = "감사합니다";
    }

    public void Presentation0() // 1학년 설명회
    {
        whoImage.sprite = gM.change[11];
        who.text = "나";
        speak.text = "선생님은 어떤 것을 설명 해주시나요?";
    }

    public void Presentation1()
    {
        whoImage.sprite = gM.change[10];
        who.text = "강준호 T";
        speak.text = "어서와라 기능반에 대해 설명할 거다";
    }

    public void Presentation2()
    {
        whoImage.sprite = gM.change[10];
        who.text = "강준호 T";
        speak.text = "기능반에 들어오면 매년 열리는 기능 대회에 참여 할 수 있도록" + "\n" + "대회에 필요한 정보들을 제공해주고 교육비를 제공해준단다.";
    }

    public void Presentation3()
    {
        whoImage.sprite = gM.change[10];
        who.text = "강준호 T";
        speak.text = "그리고 전국대회에서 1등을 하게 된다면"+ "\n" +" 취업을 하는데 도움이 된다,";
    }

    public void Presentation4()
    {
        whoImage.sprite = gM.change[10];
        who.text = "강준호 T";
        speak.text = "만약 신청하고 싶은 사람들은 나중에 다시 안내 할 때 신청하렴";
    }
    public void Presentation5()
    {
        whoImage.sprite = gM.change[10];
        who.text = "강준호 T";
        speak.text = "만약 신청하고 싶은 사람들은 나중에 다시 안내 할 때 신청하렴";
    }

    public void SelectGame0()//기능반 선택
    {
        whoImage.sprite = gM.change[11];
        who.text = "나";
        speak.text = "아 벌써 1학년이 지나가는구나" + "\n" + "나도 곧 있으면 2학년이 되겠구나";
    }
    public void SelectGame1() // 기능반 신청
    {
        who.text = "???";
        speak.text = "방송 : 아아! 수업중에 죄송합니다.1학년 "+"\n"+"학생들 중 기능반 신청을 할 학생들은";    
    }
    public void SelectGame2() // 기능반 신청
    {
        who.text = "???";
        speak.text = "2층 본관 교무실을 찾아오시기 바랍니다.";
    }
    public void SelectGame3()
    {
        whoImage.sprite = gM.change[11];
        who.text = "나";
        speak.text = "어? 기능반 신청?"; // 선택지 1. 1학기 설명회 때 들었던 거구나, 한번 신청해볼꺄 2. 그게 뭔지도 모르는데 신청안해
    }
    public void SelectGame4()
    {
        whoImage.sprite = gM.change[11];
        who.text = "나";
        speak.text = "그렇게 나는 해서는 안될 선을 넘어버렸다"; // 선택지 1. 1학기 설명회 때 들었던 거구나, 한번 신청해볼꺄 2. 그게 뭔지도 모르는데 신청안해
    }

    public void StartGameCompetitionLocal0() //2학년 3월 이벤트 기능대회 시작 
    {
        whoImage.sprite = gM.change[11];
        who.text = "나";
        speak.text = "으아아, 떨린다. 잘할 수 있을까?";
    }
    public void StartGameCompetitionLocal1()
    {
        whoImage.sprite = gM.change[11];
        who.text = "나";
        speak.text = "아니 나라면 잘해 낼 수 있을거야!!";
    }
    public void StartGameCompetitionLocal2() //2학년 3월 이벤트 기능대회 시작 
    {
        whoImage.sprite = gM.change[11];
        who.text = "나";
        speak.text = "지역예선은 간단하게 통과하였다"+"\n"+"하지만 그 이후로도 난 계속 기능반에 했어야했고";
    }
    public void StartGameCompetitionLocal3() //2학년 3월 이벤트 기능대회 시작 
    {
        whoImage.sprite = gM.change[11];
        who.text = "나";
        speak.text = "결국에는 세계 대회까지 나가 아주 좋은 곳에 취직 하였다";
    }

    public void StartGameCompetitionLocal4() //2학년 3월 이벤트 기능대회 시작 
    {
        whoImage.sprite = gM.change[11];
        who.text = "나";
        speak.text = "그렇게 난 3년간 적당한 실력을 쌓아올려"+"\n"+"적당한 곳에 취직했다 TheEnd";
    }


}
