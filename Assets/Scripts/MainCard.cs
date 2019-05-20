 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCard : MonoBehaviour
{
    private int _id;
     
    [SerializeField] private GameObject Card_Back;
    [SerializeField] private SceneControler controller;

    public int id
    {
        get { return _id; }
    }

    public void ChangeSprite(int id, Sprite sprite)
    {
        _id = id;
        GetComponent<SpriteRenderer>().sprite = sprite;
    }


    private void OnMouseDown()
    {
        if (Card_Back.activeSelf && controller.canReveal )
        {
            Card_Back.SetActive(false);
            controller.CardReveald(this);
        }
    }

    public void Unreveal()
    {
        Card_Back.SetActive(true);
    }
}
