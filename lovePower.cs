using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public  class lovePower 
{
    public static int Nlove = 0;//내신 호감도(변강순쌤)
    public static int Slove = 0;//임베디드
    public static int Plove = 0;//포토플리오
    public static int Glove = 0;//기능반
    public  int month = 3;//1,2,월(달)
    public  int Ground = 1;//학년
    public int casenumber=0;
    public  int[] NloveSave=new int[4];
    public  int[] SloveSave = new int[4];
    public  int[] GloveSave = new int[4];
    public  int[] PloveSave = new int[4];
    public  int[] MonthSave = new int[4];
    public  int[] GroundSave = new int[4];
    public  int[] caseNSave = new int[4];

    public  int Savenumber=0;


    public int test()
    {
       return Plove;
    }
    public void NlovePower()
    {

        Nlove++;
       
        Debug.Log("N: " +Nlove);
    }
    public void SlovePower()
    {
        Slove++;
       
        Debug.Log("S: " + Slove);
    }
    public void GlovePower()
    {
        Glove++;
       
        Debug.Log("G: " + Glove);
    }
    public void PlovePower()
    {
        Plove++;
        
        Debug.Log("P: " + Plove);
    }

    public void monthPluis()
    {
        month++;
        if (month > 12)
        {
            Ground++;
            month = 3;
        }
        Debug.Log("M: " + month);
    }

    public int NLove()
    {
        return Nlove;
    }
    public int SLove()
    {
        return Slove;
    }
    public int GLove()
    {
        return Glove;
    }
    public int PLove()
    {
        return Plove;
    }

    public void NewStart()
    {
        Nlove = 0;
        Slove = 0;
        Plove = 0;
        Glove = 0;
        month = 3;
        Ground = 1;
        casenumber = 0;

    }
    public void SaveLove(int number)
    {
        Savenumber = number;
        NloveSave[Savenumber] = Nlove;
        SloveSave[Savenumber] = Slove;
        PloveSave[Savenumber] = Plove;
        GloveSave[Savenumber] = Glove;
        MonthSave[Savenumber] = month;
        GroundSave[Savenumber] = Ground;
        caseNSave[Savenumber] = casenumber;

    }
    public int Load(int number)
    {
        Savenumber = number;
       
        Nlove = NloveSave[Savenumber];
        Slove = SloveSave[Savenumber];
        Plove = PloveSave[Savenumber];
        Glove = GloveSave[Savenumber];
        month = MonthSave[Savenumber];
        Ground = GroundSave[Savenumber];
        casenumber = caseNSave[Savenumber];
        return month;
    }
   
    public void First()
    {
        NewStart();
        for (int i = 0; i <4; i++)
        {
            NloveSave[i] = 0;
            SloveSave[i] = 0;
            PloveSave[i] = 0;
            GloveSave[i] = 0;
            GroundSave[i] = 1;
            MonthSave[i] = 3;
            caseNSave[i] = 0;

        }
        
    }
}
