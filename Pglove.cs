using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pglove : MonoBehaviour
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
        whoImage.sprite = gM.change[9];
        who.text = "김수민 T";
        speak.text = "시청각실은 저쪽으로 가면 있단다.";
    }

    public void SpeakAdmission2()
    {
        whoImage.sprite = gM.change[9];
        who.text = "김수민 T";
        speak.text = "지금 빨리 가보렴 시간이 늦었단다";

    }

    public void SpeakAdmission3()
    {
        whoImage.sprite = gM.change[11];
        who.text = "나";
        speak.text = "감사합니다";
    }

    public void Presentation0()
    {
        whoImage.sprite = gM.change[11];
        who.text = "나";
        speak.text = "선생님을 어떤 것을 설명 해주시냐요";
    }
    public void Presentation1()
    {
        whoImage.sprite = gM.change[9];
        who.text = "김수민 T";
        speak.text = "포트플리오 관리에 대해 설명할 거란다.";
    }

    public void Presentation2()
    {
        whoImage.sprite = gM.change[9];
        who.text = "김수민 T";
        speak.text = "애들아, 면접을 보게 될 때에는 포토플리오에 대해 질문을 받게 될거에요";
    }

    public void Presentation3()
    {
        whoImage.sprite = gM.change[9];
        who.text = "김수민 T";
        speak.text = "그러기 위해서는 포트플리오 관리를 열심히 해야겠죠";
    }
    public void Presentation4()
    {
        whoImage.sprite = gM.change[9];
        who.text = "김수민 T";
        speak.text = "그러기 위해서는 포트플리오 관리를 열심히 해야겠죠";
    }
    public void oneIct0() // 1학년 ICT
    {
        whoImage.sprite = gM.change[11];
        who.text = "나";
        speak.text = "시간 정말 빠르게 흘러간다."+"\n"+"입학한지 벌써 반년이 지났네";
    }
    public void oneIct1()
    {
        whoImage.sprite = gM.change[9];
        who.text = "김수민 T";
        speak.text = "안녕 애들아." + "\n" + "자리에 안자";
    }
    public void oneIct2()
    {
        whoImage.sprite = gM.change[9];
        who.text = "김수민 T";
        speak.text = "ICT가 이번 달에 있어, 혹시 참여 할 학생들 있니";
    }
    public void oneIct3()
    {
        whoImage.sprite = gM.change[9];
        who.text = "김수민 T";
        speak.text = "1학년들은 필수 참여는 아니고 하고 싶은 사람들은 나에게 찾아와";  //선택지 1. 한번 참여 해볼까? 2, 아냐 1학년이 뭘 참여해
    }
    public void oneIct4()
    {
        whoImage.sprite = gM.change[11];
        who.text = "System";
        speak.text = "이후 시간이 흘러 11월이 다가 왔다";  
    }

    public void twoIct0()
    {
        whoImage.sprite = gM.change[9];
        who.text = "김수민 T";
        speak.text = "애들아 앉아보자, 오늘은 공지 할 게 있단다";
    }
    public void twoIct1()
    {
        whoImage.sprite = gM.change[9];
        who.text = "김수민 T";
        speak.text = "혹시 작년에 내가 애기 했던 ICT 기억나니?";
    }
    public void twoIct2()
    {
        whoImage.sprite = gM.change[9];
        who.text = "김수민 T";
        speak.text = "2학년들은 필참해야하기 때문에 열심히 하렴" +"\n"+ "좋은 포트플리오가 될 때니 열심히 참여하렴"; // 선택지 1. 열심히 해서 좋은 결과를 내겠어 2. 아냐, 실력이 부족한 것 같아
    }
    public void twoIct3()
    {
        whoImage.sprite = gM.change[9];
        who.text = "Sysytem";
        speak.text = "ICT로 인해 정신없이 시간이 흘러 다음달이 되었다"; // 선택지 1. 열심히 해서 좋은 결과를 내겠어 2. 아냐, 실력이 부족한 것 같아
    }

}   
