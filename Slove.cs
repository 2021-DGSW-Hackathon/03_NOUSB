 using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slove : MonoBehaviour
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

    public void SpeakAdmission1()
    {
        whoImage.sprite = gM.change[4];
        who.text = "이승택 T";
        speak.text = "시청각실은 저쪽으로 가면 있단다.";
    }

    public void SpeakAdmission2()
    {
        whoImage.sprite = gM.change[4];
        who.text = "이승택 T";
        speak.text = "지금 빨리 가보렴 시간이 늦었단다";

    }

    public void SpeakAdmission3()
    {
        whoImage.sprite = gM.change[11];
        who.text = "나";
        speak.text = "감사합니다";
    }

    public void ElectricalAndElectronicBasics0() //전기전자기초
    {
        whoImage.sprite = gM.change[11];
        who.text = "시스템";
        speak.text = "입학한 3월달은 학교에 적응해가며 빠르게 지나가 4월달이 되었다 ";
    }
    public void ElectricalAndElectronicBasics1()
    {
        whoImage.sprite = gM.change[8];
        who.text = "김익현 T";
        speak.text = "애들아 모두 조용! 자리에 앉아보렴";
    }
    public void ElectricalAndElectronicBasics2()
    {
        whoImage.sprite = gM.change[8];
        who.text = "김익현 T";
        speak.text = "오늘 방과후부터 전기전자기초에 대해 배우게 될거 란다" + "\n" + " 전기전자기초는 아두이노를 이용해서 배워나가는 거야";
    }
    public void ElectricalAndElectronicBasics3()
    {
        whoImage.sprite = gM.change[11];
        who.text = "나";
        speak.text = "음 전기전자기초가 나에게 꼭 필요할까"; // 선택지 1. 혹시 모르니 한 번 들어보자 2. 몰라 그시간에 난 놀래!
    }

    public void ElectricalAndElectronicBasics4()
    {
        whoImage.sprite = gM.change[11];
        who.text = "시스템";
        speak.text = "시간이 빠르게 흘러 4월이 지나 행복한 가정의 달   5월로 다가왔다";
    }

    public void Presentation0()// 설명회
    {
        whoImage.sprite = gM.change[11];
        who.text = "나";
        speak.text = "선생님은 어떤 것을 설명 해주시나요?";
    }

    public void Presentation1()
    {
        whoImage.sprite = gM.change[4];
        who.text = "이승택 T";
        speak.text = "임베디드에 대해 한 번 알아볼 거란다";
    }

    public void Presentation2()
    {
        whoImage.sprite = gM.change[4];
        who.text = "이승택 T";
        speak.text = "임베디드는 PC나 여러 전자기기에 들어가는 칩을 개발하는 것을 말한단다.";
    }

    public void Presentation3()
    {
        whoImage.sprite = gM.change[4];
        who.text = "이승택 T";
        speak.text = "만약 자신이 관심이 있다고 생각한다면 전공과목으로 선택해보는 것도" + "\n" + "나쁘지 않은 선택이란다. ";
    }
    public void Presentation4()
    {
        whoImage.sprite = gM.change[11];
        who.text = "나";
        speak.text = "임베디드에 대해 잘 알아 본 것 같다 ";
    }

    public void Eresentation0()// 설명회
    {
        gM.BackG.sprite = gM.ChangeB[1];
        whoImage.sprite = gM.change[11];
        who.text = "나";
        speak.text = "한번 열심히 해야겠다!";
    }

    public void Eresentation1()
    {
        gM.BackG.sprite = gM.ChangeB[1];
        whoImage.sprite = gM.change[4];
        who.text = "이승택 T";
        speak.text = "오늘은 LED와 아두이노를 이용해 불을 켜보자";
    }

    public void Eresentation2()
    {
        gM.BackG.sprite = gM.ChangeB[1];
        whoImage.sprite = gM.change[11];
        who.text = "Sy";
        speak.text = "4시간뒤..";
    }

    public void Eresentation3()
    {
        gM.BackG.sprite = gM.ChangeB[1];
        whoImage.sprite = gM.change[4];
        who.text = "이승택 T";
        speak.text = "오늘 수고했다. 수업들은 애들은 나중에 도움이 될꺼야";
    }
    public void ChoiceOfMajor()// 전공 과목 선택
    {
        whoImage.sprite = gM.change[3];
        who.text = "시스템";
        speak.text = "시간이 흘러 1학년의 마지막이 다가왔다";
    }
    public void ChoiceOfMajor0()
    {
        whoImage.sprite = gM.change[3];
        who.text = "김경호 T";
        speak.text = "애들아 오늘 2학년 전공과목을 선택해야한단다" + "\n" + "자신이 원하는 전공 과목을 선택 해서 알려주렴";
    }
    public void ChoiceOfMajor1()
    {
        whoImage.sprite = gM.change[3];
        who.text = "김경호 T";
        speak.text = "이 전공 과목은 앞으로의 2년간 배우게 될 내용이니 잘 선택하거라";
    }

    public void ChoiceOfMajor2()
    {
        whoImage.sprite = gM.change[11];
        who.text = "나";
        speak.text = "음... 어떤 전공을 선택하지? "; //선택지 1. 소프트웨어개발과 2. 임베디드소프트웨어개발과
    }
    public void ChoiceOfMajor3()
    {
        whoImage.sprite = gM.change[11];
        who.text = "나";
        speak.text = "그래 난 내 선택을 믿겠어";
    }
}
