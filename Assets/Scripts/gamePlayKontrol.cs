using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gamePlayKontrol : MonoBehaviour
{
    int btnSayac = 0;

    public Button[] btns;
    public GameObject mermiPrefab;
    public GameObject mermi45;
    public GameObject mermi452;
    public GameObject player;
    public Transform mermiCikis;
    public Transform mermiCikis1;
    public Transform mermiCikis2;


    private bool baslangicBool = false;
    private bool button1 =false;
    private bool button2 = false;
    private bool button3 = false;
    private bool button4 = false;
    private bool button5 = false;

    public static bool derece45 = false;




    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(InstantiateMermi(mermiPrefab));
        Instantiate(player, new Vector3(0, 0, 0), Quaternion.identity);

    }

    IEnumerator InstantiateMermi(GameObject abc)
    {
        while (true)
        {
            if (button1)
            {
                yield return new WaitForSeconds(2f);
                Instantiate(mermi45, new Vector3(mermiCikis1.position.x, mermiCikis1.position.y, mermiCikis1.position.z), Quaternion.identity);
                Instantiate(mermi452, new Vector3(mermiCikis2.position.x, mermiCikis2.position.y, mermiCikis2.position.z), Quaternion.identity);
            }
            else
            {
                yield return new WaitForSeconds(2f);
                Instantiate(abc, new Vector3(0, mermiCikis.position.y, 0), Quaternion.identity);
            }

            if (button2)
            {
                yield return new WaitForSeconds(2f);
                Instantiate(abc, new Vector3(0, mermiCikis.position.y, 0), Quaternion.identity);
                Instantiate(abc, new Vector3(0, mermiCikis.position.y, 0), Quaternion.identity);
            }
            else
            {
                yield return new WaitForSeconds(2f);
                Instantiate(abc, new Vector3(0, mermiCikis.position.y, 0), Quaternion.identity);

            }

            if (button3)
            {
                yield return new WaitForSeconds(1f);
                Instantiate(abc, new Vector3(0, mermiCikis.position.y, 0), Quaternion.identity);

            }
            else
            {
                yield return new WaitForSeconds(2f);
                Instantiate(abc, new Vector3(0, mermiCikis.position.y, 0), Quaternion.identity);

            }

            if (button4)
            {
                MermiKontrol.hiz = 9;


            }
            else
            {
                MermiKontrol.hiz = 6;

            }

        }

    }

    // Update is called once per frame
    void Update()
    {
        if (btnSayac >= 3)
        {
            for (int i = 0; i < btns.Length; i++)
            {
                btns[i].interactable = false;
                baslangicBool = true;
            }
        }
        else if(baslangicBool)
        {
            if (button1==false)
            {
                btns[0].interactable = true;
            }
            if (button2==false)
            {
                btns[1].interactable = true;
            }
            if (button3==false)
            {
                btns[2].interactable = true;
            }
            if (button4==false)
            {
                btns[3].interactable = true;
            }
            if (button5==false)
            {
                btns[4].interactable = true;
            }
        }
    }

    public void bitir()
    {
        SceneManager.LoadScene("AnaMenu");
    }
    
    public void btn1()
    {
        
        btnSayac++;
        btns[0].interactable = false;
        button1 = true;
        derece45 = true;
    }
    public void btn1OnOff()
    {
        btnSayac--;
        btns[0].interactable = true;
        button1 = false;
        derece45 = false;
    }

    public void btn2()
    {
        btnSayac++;
        btns[1].interactable = false;
        button2 = true;
    }
    public void btn2OnOff()
    {
        btnSayac--;
        btns[1].interactable = true;
        button2 = false;
    }
    public void btn3()
    {
        btnSayac++;
        btns[2].interactable = false;
        button3 = true;

    }
    public void btn3OnOff()
    {
        btnSayac--;
        btns[2].interactable = true;
        button3 = false;

    }
    public void btn4()
    {
        btnSayac++;
        btns[3].interactable = false;
        button4 = true;


    }
    public void btn4OnOff()
    {
        btnSayac--;
        btns[3].interactable = true;
        button4 = false;

    }
    public void btn5()
    {
        btnSayac++;
        btns[4].interactable = false;
        button5 = true;

    }
    public void btn5OnOff()
    {
        btnSayac--;
        btns[4].interactable = true;
        button5 = false;
    }


}
