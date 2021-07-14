using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonM : MonoBehaviour
{
    public SceanM ScM;

    
    public GameObject fix;

    public GameM gM;

    public lovePower lovP;

    public Ese ese;

    public int number;

    public int loadMouth;


    public GameObject LoadIm;

    public NpcTalk npcT;
    public startG stG;
    private void Start()
    {
        stG = FindObjectOfType<startG>();
        ese = FindObjectOfType <Ese>();
        gM = FindObjectOfType<GameM>();
        lovP = GameObject.Find("DataM").GetComponent<DataM>().loveP;
        npcT = FindObjectOfType<NpcTalk>();
    }

    public void NewStartGame()
    {
        lovP.NewStart();
        ScM.StartG();
    }
    public void CountinueG1()
    {
        number = 0;
        loadMouth=lovP.Load(number);
        
        ScM.ContG();
        LoadOUt();
    }
    public void CountinueG2()
    {
        number = 1;
        loadMouth = lovP.Load(number);
        ScM.ContG();
        LoadOUt();
    }
    public void CountinueG3()
    {
        number = 2;
        loadMouth = lovP.Load(number);
        ScM.ContG();
        LoadOUt();
    }
    public void CountinueG4()
    {
        number = 3;
        loadMouth = lovP.Load(number);
        ScM.ContG();
        LoadOUt();
    }
    public void QuitGame()
    {
        ScM.QuitGame();
    }
    public void Fixed()
    {
        
        fix.SetActive(true);    
    }
    public void FIrS()
    {
        ScM.FirstG();
    }
    public void Nclick()
    {
        npcT.NClick();
    }
    public void Sclick()
    {
        npcT.SClick(); 
    }
    public void Pclick()
    {
        npcT.PClick();
    }
    public void Gclick()
    {
        npcT.GClick();
    }
    public void EseCount()
    {
        ese.eseImgae.SetActive(false);
    }
    public void FixOut()
    {
        fix.SetActive(false);
    }
    public void Save1()
    {
        gM.loveP.SaveLove(0);
        LoadOUt();
        Debug.Log("저장~");
    }
    public void Save2()
    {
        gM.loveP.SaveLove(1);
        LoadOUt();
    }
    public void Save3()
    {
        gM.loveP.SaveLove(2);
        LoadOUt();
    }
    public void Save4()
    {
        gM.loveP.SaveLove(3);
        LoadOUt();
    }
    public void Clear()
    {
        gM.loveP.First();
       
    }
    public void LoadImage()
    {
        LoadIm.SetActive(true);
    }

    public void LoadOUt()
    {
        LoadIm.SetActive(false);
        EseCount(); 
    }
    

    public void Dragon()
    {
        npcT.DagonTime();
    }
    public void DragonE()
    {
        npcT.DagonTimeEnd();
    }
    public void yes()
    {
        stG.playerYN = true;
        lovP.casenumber += 1;
        npcT.YorN.SetActive(false);
    }
    public void No()
    {
        stG.playerYN = false;
        lovP.casenumber += 1;
        npcT.YorN.SetActive(false);

    }
  
}
