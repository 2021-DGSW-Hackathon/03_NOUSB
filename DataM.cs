using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class DataM : MonoBehaviour
{
    private void Start()
    {
        LoveGameData();
        loveP.NewStart();
    }
    private static DataM dataM;
    private void Awake()
    {
        if (dataM == null)
        {
            dataM = this;
            DontDestroyOnLoad(dataM);


        }
        else
        {
            Destroy(gameObject);
        }
    }
   
        static GameObject contor;
    static GameObject Contor
    {
        get
        {
            return contor;                   
        }
    }
    static DataM instaance;
    public static DataM Instance 
    {
        get
        {
            if (!instaance)
            {
                contor = new GameObject();
                contor.name = "DataM";
                instaance = contor.AddComponent(typeof(DataM)) as DataM;
                DontDestroyOnLoad(contor);
            }
            return instaance;
        }   
    }

    public string GameDataFileName = ".json";

    public lovePower loveP;
    public lovePower LoveP 
    {
        get
        {
            if (loveP == null)
            {
                Debug.Log("1");
                LoveGameData();
                SaveGameData();
            }
            return loveP;
        }


    }
    public void LoveGameData()
    {
        string filePath = Application.persistentDataPath + GameDataFileName;
        if (File.Exists(filePath))
        {
            Debug.Log("불러오기 성");
            string FOrmJsonD = File.ReadAllText(filePath);
            loveP = JsonUtility.FromJson<lovePower>(FOrmJsonD);

        }
        else
        {
            Debug.Log("새파일 생");
            loveP = new lovePower();
        }
    }
    public void SaveGameData()
    {
        string TojsonD = JsonUtility.ToJson(LoveP);
        string filePath = Application.persistentDataPath + GameDataFileName;
        File.WriteAllText(filePath, TojsonD);
        Debug.Log("저장완");
    }
    private void OnApplicationQuit()
    {
        SaveGameData();
    }

    // Start is called before the first frame update
   

    // Update is called once per frame
    
}
