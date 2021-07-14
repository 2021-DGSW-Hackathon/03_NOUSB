using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Nlove : MonoBehaviour
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
    public void SpeakAdmission1() // 입학 이벤트
    {
        whoImage.sprite = gM.change[6];
        who.text = "변강순 T";
        speak.text = "시청각실은 저쪽으로 가면 있단다.";
    }

    public void SpeakAdmission2()
    {
        whoImage.sprite = gM.change[6];
        who.text = "변강순 T";
        speak.text = "지금 빨리 가보렴 시간이 늦었단다";

    }

    public void SpeakAdmission3()
    {
        whoImage.sprite = gM.change[11];
        who.text = "나";
        speak.text = "감사합니다";
    }

    public void Presentation0() // 설명회 이벤트
    {
        whoImage.sprite = gM.change[11];
        who.text = "나";
        speak.text = "선생님을 어떤 것을 설명 해주시냐요";
    }
    public void Presentation1()
    {
        whoImage.sprite = gM.change[6];
        who.text = "변강순 T";
        speak.text = "내신 성적에 대해 설명합니다.";
    }

    public void Presentation2()
    {
        whoImage.sprite = gM.change[6];
        who.text = "변강순 T";
        speak.text = "이 학교에서는 내신도 어느 정도 챙겨야만 한단다.";
    }

    public void Presentation3()
    {
        whoImage.sprite = gM.change[6];
        who.text = "변강순 T";
        speak.text = "너무 전공 공부만 하다 보면 내신이 부족하여 1차 서류면접에서," + "\n" + " 떨어질 수도 있단다. 시험 기간에 놀지만 말고 성적도 관리하렴";
    }

    public void FisrtFinalExam0() // 1학기 기말 이벤트
    {
        whoImage.sprite = gM.change[11];
        who.text = "나";
        speak.text = "벌써 시험 기간이라니, 왜 이렇게 시간이 빠르게 흐르지";
    }
    public void FisrtFinalExam1()
    {
        whoImage.sprite = gM.change[11];
        who.text = "나";
        speak.text = "분명 한건 없는 것 같은데" + "\n" + "내신을 챙겨야 할까?"; // 뒤에 선택지 나오기
    }


    public void LastExam0()
    {
        whoImage.sprite = gM.change[11];
        who.text = "나";
        speak.text = "벌써 기말 시험이라니" + "\n" + "너무 빠르게 지난 간 것 같네";
    }

    public void LastExam1()
    {
        whoImage.sprite = gM.change[11];
        who.text = "나";
        speak.text = "이번에도 시험공부를 해야할까? ";//선택지 1. 시험 공부를 한다 , 2. 시험공부는 개뿔 놀아야지
    }

    public void LastExam2()
    {
        whoImage.sprite = gM.change[11];
        who.text = "System";
        speak.text = "1학년의 모든 시험이 끝이 났습니다";
    }


    public void TwoFisrtFinalExam0() // 2학년 1학기 기말고사
    {
        whoImage.sprite = gM.change[11];
        who.text = "나";
        speak.text = "시험기간이 다가왔네" + "\n" + "어휴 이번에도 공부를 해야할까?"; // 선택지 1. 그래 역시 시험 공부는 중요해 2. 내신따위는 개나 줘버려
    }

    public void Exam()
    {
        whoImage.sprite = gM.change[11];
        who.text = "나";
        speak.text = "그래 공부 열심히 해서 내신 챙겨야지~!"; // 뒤에 선택지 나오기
    }
    public void Examno()
    {
        whoImage.sprite = gM.change[11];
        who.text = "나";
        speak.text = "그래 내신은 원래 던지라고 있는거지~"; // 뒤에 선택지 나오기
    }
    public void Exam1()
    {
        whoImage.sprite = gM.change[11];
        who.text = "나";
        speak.text = "역시 공부하니 난 잘 맞을 것 같아"; // 뒤에 선택지 나오기
    }
    public void Examn2()
    {
        whoImage.sprite = gM.change[11];
        who.text = "나";
        speak.text = "2학년 때 잘하면 되는 거지"; // 뒤에 선택지 나오기
    }

    public void TwoLastExam0() // 2학년 마지막 기말고사
    {
        whoImage.sprite = gM.change[11];
        who.text = "나";
        speak.text = "2학년 마지막 기말이라니" + "\n" + "시간이 참 빠르게 흐른네";
    }

    public void TwoLastExam1()
    {
        whoImage.sprite = gM.change[11];
        who.text = "나";
        speak.text = "이게 2학년 마지막 시험이니 공부를 해볼까?"; // 선택지 1. 그래 열심히 해서 공부를 해보자 2. 아냐 공부는 아닌 것 같네
    }
    public void TwoLastExam2()
    {
        whoImage.sprite = gM.change[11];
        who.text = "System";
        speak.text = "2학년의 모든 시험이 끝이 났습니다"; 
    }

    public void ThreeFinalExam0() // 3학년 기말고사
    {
        whoImage.sprite = gM.change[11];
        who.text = "시스템";
        speak.text = "시간이 빠르게 흘러 대소고의 마지막 시험이 다가왔다";
    }

    public void ThreeFinalExam1()
    {
        whoImage.sprite = gM.change[11];
        who.text = "나";
        speak.text = "시간 참 빠르네";
    }
    public void ThreeFinalExam2()
    {
        whoImage.sprite = change[11];
        who.text = "나";
        speak.text = "마지막 시험이라니";
    }
    public void ThreeFinalExam3()
    {
        whoImage.sprite = gM.change[11];
        who.text = "나";
        speak.text = "시험이 마지막이니 한 번 제대로 쳐볼까?"; // 선택지 1. 열심히 하자 화이팅 ! 2. 마지막인데 뭐 대충 쳐도 되겠지
    }
    public void ThreeFinalExam4()
    {
        whoImage.sprite = gM.change[11];
        who.text = "System";
        speak.text = "이것을 마지막으로 모든 시험이 끝났다"; // 선택지 1. 열심히 하자 화이팅 ! 2. 마지막인데 뭐 대충 쳐도 되겠지
    }
}
