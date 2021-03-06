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

    public Image Shoes;

    public Image Eyes;

    private int _charanumber;
    private int _headnumber;
    private int _shirtnumber;
    private int _pantsnumber;
    private int _shoesnumber;
    public int _racenumber;
    private int _skincolor;

    private float red;
    private float green;
    private float blue;
    // Start is called before the first frame update
   

    void Start()
    {
        _charanumber = 0;
        _headnumber = 0;
        _shirtnumber = 0;
        _pantsnumber = 0;
        _shoesnumber = 0;
        _racenumber = 0;
        _skincolor = 0;
        _currentRace = Races[_racenumber];
        UpdateHead();
        UpdateBG();
        UpdateChara();
        UpdateSkin();
        UpdateHead();
        UpdateShirt();
        UpdatePants();
        UpdateShoes();

        red = Random.Range(0f, 1f);
        green = Random.Range(0f, 1f);
        blue = Random.Range(0f, 1f);

        Eyes.color = new Color(red, green, blue, 1);
        Head.color = new Color(red, green, blue, 1);
        Shirt.color = new Color(red, green, blue, 1);
        Pants.color = new Color(red, green, blue, 1);
        Shoes.color = new Color(red, green, blue, 1);

    }


    public void UpdateBG()
    {
        BackGround.sprite = _currentRace.Background;
    }

    public void UpdateChara()
    {
        Character.sprite = _currentRace.CharaList[_charanumber];
    }
    public void UpdateSkin()
    {
        Character.sprite = _currentRace.SkinColor[_skincolor];
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

    public void UpdateShoes()
    {
        Shoes.sprite = _currentRace.ShoesList[_shoesnumber];
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
        if (_headnumber != 12)
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
        if (_charanumber == 0)
        {
            if (_shirtnumber <= 6)
            {
               _shirtnumber++;
            }
        }
        if (_charanumber == 1)
        {
            if (_shirtnumber <= 13)
            {
                _shirtnumber++;
            }
        }

        UpdateShirt();

    }
    public void OnclickShirtMoins()
    {
        if (_charanumber == 0)
        { 
            if (_shirtnumber != 0)
            {
                _shirtnumber--;
            }
        }
        if (_charanumber == 1)
        {
            if (_shirtnumber > 6)
            {
                _shirtnumber--;
            }
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
        if (_pantsnumber != 7)
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


    public void OnclickShoesPlus()
    {
        if (_shoesnumber != 18)
        {
            _shoesnumber++;
        }
        UpdateShoes();

    }
    public void OnclickShoesMoins()
    {
        if (_shoesnumber != 0)
        {
            _shoesnumber--;
        }
        UpdateShoes();

    }
    public void OnclickShoesColor()
    {
        red = Random.Range(0f, 1f);
        green = Random.Range(0f, 1f);
        blue = Random.Range(0f, 1f);

        Shoes.color = new Color(red, green, blue, 1);

    }

    public void OnclickEyesColor()
    {
        red = Random.Range(0f, 1f);
        green = Random.Range(0f, 1f);
        blue = Random.Range(0f, 1f);

        Eyes.color = new Color(red, green, blue, 1);

    }




    public void OnclickHumain()
    {
        _racenumber = 0;
        _currentRace = Races[_racenumber];
        UpdateBG();
        UpdateChara();
        for (int i = 0; i < _currentRace.HideElement.Count; i++)
        {
            _currentRace.HideElement[i].SetActive(false);
        }
        for (int i = 0; i < _currentRace.UnHide.Count; i++)
        {
            _currentRace.UnHide[i].SetActive(true);
        }
    }
    public void OnclickDemon()
    {
        _racenumber = 1;
        _currentRace = Races[_racenumber];
        UpdateBG();
        UpdateChara();
        for (int i = 0; i < _currentRace.HideElement.Count; i++)
        {
            _currentRace.HideElement[i].SetActive(false);
        }
        for (int i = 0; i < _currentRace.UnHide.Count; i++)
        {
            _currentRace.UnHide[i].SetActive(true);
        }
    }
    public void OnclickAnge()
    {
        _racenumber = 2;
        _currentRace = Races[_racenumber];
        UpdateBG();
        UpdateChara();
        for (int i = 0; i < _currentRace.HideElement.Count; i++)
        {
            _currentRace.HideElement[i].SetActive(false);
        }
        for (int i = 0; i < _currentRace.UnHide.Count; i++)
        {
            _currentRace.UnHide[i].SetActive(true);
        }
    }
    public void OnclickSirene()
    {
        _racenumber = 3;
        _currentRace = Races[_racenumber];
        UpdateBG();
        UpdateChara();
        for (int i = 0; i < _currentRace.HideElement.Count; i++)
        {
            _currentRace.HideElement[i].SetActive(false);
        }
        for (int i = 0; i < _currentRace.UnHide.Count; i++)
        {
            _currentRace.UnHide[i].SetActive(true);
        }
    }
    public void OnclickElfe()
    {
        _racenumber = 4;
        _currentRace = Races[_racenumber];
        UpdateBG();
        UpdateChara();
        for (int i = 0; i < _currentRace.HideElement.Count; i++)
        {
            _currentRace.HideElement[i].SetActive(false);
        }
        for (int i = 0; i < _currentRace.UnHide.Count; i++)
        {
            _currentRace.UnHide[i].SetActive(true);
        }
    }


    public void OnclickSkin1()
    {
        if(_charanumber == 0)
        {
            _skincolor = 0;
        }
        if (_charanumber == 1)
        {
            _skincolor = 4;
        }
        UpdateSkin();
    }
    public void OnclickSkin2()
    {
        if (_charanumber == 0)
        {
            _skincolor = 1;
        }
        if (_charanumber == 1)
        {
            _skincolor = 5;
        }
        UpdateSkin();
    }
    public void OnclickSkin3()
    {
        if (_charanumber == 0)
        {
            _skincolor = 2;
        }
        if (_charanumber == 1)
        {
            _skincolor = 6;
        }
        UpdateSkin();
    }
    public void OnclickSkin4()
    {
        if (_charanumber == 0)
        {
            _skincolor = 3;
        }
        if (_charanumber == 1)
        {
            _skincolor = 7;
        }
        UpdateSkin();
    }
    
}
