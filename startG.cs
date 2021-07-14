using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class startG : MonoBehaviour
{
    public GameM gM;
    public int gameing=0;
    public bool speaking = true;
    public lovePower loP;
    public Pglove pLove;
    public Slove sLove;
    public Glove gLove;
    public Nlove nLove;
    public NpcTalk globerTalk;

    public bool playerYN = true;
    public bool scrs=false;
    void Start()
    {
        pLove = FindObjectOfType<Pglove>();
        sLove = FindObjectOfType<Slove>();
        gLove = FindObjectOfType<Glove>();
        nLove = FindObjectOfType<Nlove>();
        gM = FindObjectOfType<GameM>();
        loP = GameObject.Find("DataM").GetComponent<DataM>().loveP;
        globerTalk = FindObjectOfType<NpcTalk>();
    }

    // Update is called once per frame
    void Update()
    {
        
        switch (loP.casenumber)
        {
            case 0:
                globerTalk.Oping();
                break;
            case 1:
                globerTalk.Oping1();
                break;
            case 2:
                gM.BackG.sprite = gM.ChangeB[5];
                gM.whoImage.sprite = gM.change[11];
               globerTalk.who.text = "나";
                globerTalk.speak.text = " 근데 시청각실이 어디에 있지? 저 선생님께 물어보자";
                globerTalk.okAnswer();
                break;
            case 3:
                if (globerTalk.what == 1)
                {
                    nLove.SpeakAdmission0();
                }
                else if(globerTalk.what == 2)
                {
                    gLove.SpeakAdmission0();
                }
                else if (globerTalk.what == 3)
                {
                    sLove.SpeakAdmission0();
                }
                else if (globerTalk.what == 4)
                {
                    pLove.SpeakAdmission0();
                }

                break;
            case 4:
                if (globerTalk.what == 1)
                {
                    nLove.SpeakAdmission1();
                }
                else if (globerTalk.what == 2)
                {
                    gLove.SpeakAdmission1();
                }
                else if (globerTalk.what == 3)
                {
                    sLove.SpeakAdmission1();
                }
                else if (globerTalk.what == 4)
                {
                    pLove.SpeakAdmission1();
                }
                break;
            case 5:
                if (globerTalk.what == 1)
                {
                    nLove.SpeakAdmission2();
                }
                else if (globerTalk.what == 2)
                {
                    gLove.SpeakAdmission2();
                }
                else if (globerTalk.what == 3)
                {
                    sLove.SpeakAdmission2();
                }
                else if (globerTalk.what == 4)
                {
                    pLove.SpeakAdmission2();
                }
                break;
            case 6:
                if (globerTalk.what == 1)
                {
                    nLove.SpeakAdmission3();
                }
                else if (globerTalk.what == 2)
                {
                    gLove.SpeakAdmission3();
                }
                else if (globerTalk.what == 3)
                {
                    sLove.SpeakAdmission3();
                }
                else if (globerTalk.what == 4)
                {
                    pLove.SpeakAdmission3();
                }
                break;
            case 7:
                globerTalk.syYoung();

                break;
            case 8:
                globerTalk.younging();

                break;
            case 9:
                globerTalk.younging1();

                break;
            case 10:
                globerTalk.younging2();

                break;
            case 11:

                globerTalk.yongingQ();
             
                break;
            case 12:
                globerTalk.yongingQEnd();
                if (playerYN == true)
                {
                    globerTalk.DagonTime();
                    playerYN = false;
                }
                loP.casenumber += 1;
                break;
            case 13:
                sLove.ElectricalAndElectronicBasics0(); // 전기전자 기초
                break;
            case 14:
                sLove.ElectricalAndElectronicBasics1();
                break;
            case 15:
                sLove.ElectricalAndElectronicBasics2();
                break;
            case 16:
                sLove.ElectricalAndElectronicBasics3();
                break;
            case 17:
                globerTalk.EvedQ();
                
                break;
            case 18:
                globerTalk.EvedEnd();
                if (playerYN == true)
                {
                    if (scrs == false)
                    {
                        loP.SlovePower();
                        scrs = true;
                    }
                    sLove.Eresentation0();
                    
                }
                else
                {
                    loP.casenumber = 22;
                }
                break;
            case 19:
                sLove.Eresentation1();

                break;
            case 20:
                sLove.Eresentation2();
                break;
            case 21:
                sLove.Eresentation3();
                break;
            case 22:
                scrs = false;
                globerTalk.sixMounth();
                break;
            case 23:
                
                globerTalk.sixMounth1();
                break;
            case 24:
                globerTalk.okAnswer();
                break;
            case 25:
                if (globerTalk.what == 1)
                {
                    nLove.Presentation0();
                }
                else if (globerTalk.what == 2)
                {
                    gLove.Presentation0();
                }
                else if (globerTalk.what == 3)
                {
                    sLove.Presentation0();
                }
                else if (globerTalk.what == 4)
                {
                    pLove.Presentation0();
                }

                break;
            case 26:
                if (globerTalk.what == 1)
                {
                    nLove.Presentation1();
                }
                else if (globerTalk.what == 2)
                {
                    gLove.Presentation1();
                }
                else if (globerTalk.what == 3)
                {
                    sLove.Presentation1();
                }
                else if (globerTalk.what == 4)
                {
                    pLove.Presentation1();
                }

                break;
            case 27:
                if (globerTalk.what == 1)
                {
                    nLove.Presentation2();
                }
                else if (globerTalk.what == 2)
                {
                    gLove.Presentation2();
                }
                else if (globerTalk.what == 3)
                {
                    sLove.Presentation2();
                }
                else if (globerTalk.what == 4)
                {
                    pLove.Presentation2();
                }

                break;

            case 28:
                if (globerTalk.what == 1)
                {
                    nLove.Presentation3();
                }
                else if (globerTalk.what == 2)
                {
                    gLove.Presentation3();
                }
                else if (globerTalk.what == 3)
                {
                    sLove.Presentation3();
                }
                else if (globerTalk.what == 4)
                {
                    pLove.Presentation3();
                }

                break;
            case 29:
                if (globerTalk.what == 1)
                {
                    loP.casenumber = 30;
                }
                else if (globerTalk.what == 2)
                {
                    gLove.Presentation4();
                }
                else if (globerTalk.what == 3)
                {
                    loP.casenumber = 30;
                }
                else if (globerTalk.what == 4)
                {
                    pLove.Presentation4();
                }

                break;
            case 30:
                globerTalk.sixMounth2();
                nLove.FisrtFinalExam0();


                break;
            case 31:
                nLove.FisrtFinalExam1();
                globerTalk.NasinE();

                break;
            case 32:
                
                globerTalk.NasinEnd();
                if (playerYN == true)
                {
                    if (scrs == false)
                    {
                        loP.NlovePower();
                        scrs = true;
                   
                    }
                    nLove.Exam();
                }
                else
                {
                    nLove.Examno();
                }

                break;
            case 33:
                pLove.oneIct0();
                break;
            case 34:
                pLove.oneIct1();
                break;
            case 35:
                pLove.oneIct2();
                break;
            case 36:
                pLove.oneIct3();
                globerTalk.ICTE();
                break;
           
            case 37:
                globerTalk.ICTEnd();
                if (playerYN == true)
                {
                    if (scrs == false)
                    {
                        loP.PlovePower();
                        scrs = true;

                    }
                }
                loP.casenumber += 1;
                break;
            case 38:
                nLove.TwoLastExam0();
                break;
            case 39:
                nLove.TwoLastExam1();
                break;
            case 40:
                globerTalk.NasinE();
                break;
            case 41:
                globerTalk.NasinEnd();
                if (playerYN == true)
                {
                    if (scrs == false)
                    {
                        loP.NlovePower();
                        scrs = true;

                    }
                    nLove.Exam1();
                    //loP.NlovePower();
                    //playerYN = false;
                }
                else
                {
                    nLove.Examn2();
                }
                loP.casenumber += 1;
                break;
            case 42:
                nLove.TwoLastExam2();
                break;
            case 43:
                gLove.SelectGame0();
                break; 
            case 44:
                gLove.SelectGame1();
                break;
            case 45:
                gLove.SelectGame2();
                break;
            case 46:
                globerTalk.Game();

                break;
            case 47:
                globerTalk.GameEnd();
                if (playerYN == true)
                {
                    if (scrs == false)
                    {
                        loP.GlovePower();
                        scrs = true;

                    }
                    //loP.GlovePower ();
                    //playerYN = false;
                    loP.casenumber += 1;
                }
                else if (playerYN == false)
                {
                    loP.casenumber = 54;
                }
                break;
            case 48:
                gLove.SelectGame3();
                break;
            case 49:
                gLove.SelectGame4();
                break;
            case 50:
                gLove.StartGameCompetitionLocal0();
                break;
            case 51:
                gLove.StartGameCompetitionLocal1();
                break;
            case 52:
                gM.BackG.sprite = gM.ChangeB[7];
                gLove.StartGameCompetitionLocal2();
                break;
            case 53:
                gM.BackG.sprite = gM.ChangeB[8];
                gLove.StartGameCompetitionLocal3();
                
                break;

            case 54:
                gM.BackG.sprite = gM.ChangeB[9];
                gLove.StartGameCompetitionLocal4();
                break;

        }
    }
    public void Click()
    {
        
            loP.casenumber += 1;
        
    }
}
