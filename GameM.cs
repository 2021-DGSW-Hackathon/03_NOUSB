using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameM : MonoBehaviour
{
    public Text speak;
    public Text who;
    public Image whoImage;
    public Sprite[] change;
    public GameObject canves;
    public GameObject QandA;
    public bool clickOn=false;
    public lovePower loveP;
    public Image BackG;
    public Sprite[] ChangeB;

    

    void Start()
    {
        loveP = GameObject.Find("DataM").GetComponent<DataM>().loveP;
        canves = GameObject.Find("Canvas");
        whoImage = canves.transform.Find("whoIm").gameObject.GetComponent<Image>();
        speak = canves.transform.Find("Speak").gameObject.GetComponent<Text>();
        who = canves.transform.Find("Whoname").gameObject.GetComponent<Text>();
        QandA = canves.transform.Find("Answer").gameObject;
        QandA.SetActive(false);
        BackG = canves.transform.Find("BackG").gameObject.GetComponent<Image>();
    }

    // Update is called once per frame
    public void Speak0() // 입학 이벤트 
    {
        who.text = "나";
        speak.text = "<size=50>와! 여기가 바로 소문의" + "\n" + "대구소프트웨어마이스터고등학교구나!</size>";
    }

    public void Speak1()
    {
        who.text = "나";
        speak.text = "근데 시청각실이 어디지?" + "\n" + "저 선생님께 물어보자";
    }

    

    public void Nspeak()
    {
        QDIe();
        whoImage.sprite = change[0];
        who.text = "내신";
        speak.text = "내신하실?";
        loveP.NlovePower();
    }
    public void Pspeak()
    {
        QDIe();
        whoImage.sprite = change[2];
        who.text = "포톨";
        speak.text = "포톨하실?";
        loveP.PlovePower();
    }
    public void Gspeak()
    {
        QDIe();
        whoImage.sprite = change[2];
        who.text = "기능";
        speak.text = "기능하실?";
        loveP.GlovePower();
    }
    public void Sspeak()
    {
        QDIe();
        whoImage.sprite = change[2];
        who.text = "임베";
        speak.text = "임베하실?";
        loveP.SlovePower();
        
       
    }
    public void Ran()
    {
        speak.text = " " +FindObjectOfType<DataM>().loveP.month;
    }

    public void QDIe()
    {
       
        QandA.SetActive(false);
        clickOn = true;
    }
    
}
