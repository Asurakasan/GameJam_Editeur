using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainGame : MonoBehaviour
{
    public List<Race> Races;
    private Race _currentRace;

    public Image BackGround;

    public Image Character;

    public Image Head;

    public Image Shirt;

    public Image Pants;

    private int _charanumber;
    private int _headnumber;
    private int _shirtnumber;
    private int _pantsnumber;
    public int _racenumber;

    private float red;
    private float green;
    private float blue;
    // Start is called before the first frame update
    void Start()
    {
        _racenumber = 0;
        _currentRace = Races[_racenumber];
        UpdateHead();
    }


    public void UpdateBG()
    {
        BackGround.sprite = _currentRace.Background;
    }

    public void UpdateChara()
    {
        if (_charanumber == 0)
        {
            Character.color = new Color32(40, 169, 202, 100); ;
        }
        if (_charanumber == 1)
        {
            Character.color = new Color32(198, 87, 162, 100); ;
        }
        //Character.sprite = _currentRace.CharaList[_charanumber];

    }
    public void UpdateHead()
    {
        Head.sprite = _currentRace.HeadList[_headnumber];
        
    }
    public void UpdateShirt()
    {
        Shirt.sprite = _currentRace.ShirtList[_shirtnumber];

    }
    public void UpdatePants()
    {
        Pants.sprite = _currentRace.PantsList[_pantsnumber];

    }

    public void OnclickHomme()
    {
        _charanumber = 0;
        
        UpdateChara();

    }
    public void OnclickFemme()
    {
        _charanumber = 1;

        UpdateChara();

    }



    public void OnclickHeadPlus()
    {
        if (_headnumber != 2)
        {
            _headnumber++;
        }
        UpdateHead();

    }
    public void OnclickHeadMoins()
    {
        if(_headnumber != 0)
        {
            _headnumber--;
        }
        UpdateHead();

    }
    public void OnclickHeadColor()
    {
        red = Random.Range(0f , 1f);
        green = Random.Range(0f, 1f);
        blue = Random.Range(0f, 1f);

        Head.color = new Color(red, green, blue, 1);

    }



    public void OnclickShirtPlus()
    {
        if (_shirtnumber != 2)
        {
            _shirtnumber++;
        }
        UpdateShirt();

    }
    public void OnclickShirtMoins()
    {
        if (_shirtnumber != 0)
        {
            _shirtnumber--;
        }
        UpdateShirt();

    }
    public void OnclickShirtColor()
    {
        red = Random.Range(0f, 1f);
        green = Random.Range(0f, 1f);
        blue = Random.Range(0f, 1f);

        Shirt.color = new Color(red, green, blue, 1);

    }



    public void OnclickPantsPlus()
    {
        if (_pantsnumber != 2)
        {
            _pantsnumber++;
        }
        UpdatePants();

    }
    public void OnclickPantsMoins()
    {
        if (_pantsnumber != 0)
        {
            _pantsnumber--;
        }
        UpdatePants();

    }
    public void OnclickPantsColor()
    {
        red = Random.Range(0f, 1f);
        green = Random.Range(0f, 1f);
        blue = Random.Range(0f, 1f);

        Pants.color = new Color(red, green, blue, 1);

    }

    public void OnclickHumain()
    {
        _racenumber = 0;
        _currentRace = Races[_racenumber];
        UpdateBG();
    }
    public void OnclickDemon()
    {
        _racenumber = 1;
        _currentRace = Races[_racenumber];
        UpdateBG();
    }
    public void OnclickAnge()
    {
        _racenumber = 2;
        _currentRace = Races[_racenumber];
        UpdateBG();
    }
    public void OnclickSirene()
    {
        _racenumber = 3;
        _currentRace = Races[_racenumber];
        UpdateBG();
    }
    public void OnclickElfe()
    {
        _racenumber = 4;
        _currentRace = Races[_racenumber];
        UpdateBG();
    }
}
