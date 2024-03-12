using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class RPS
{
    const int PAPER = 1;
    const int ROCK = 2;
    const int SCISSORS = 3;
    const string SPRITE_PATH = "Art Assets/rock_scissors_paper";

    [Header("Type")]
    public int type;
    public string typeName;
    public Sprite sprite;

    public void LoadSprite()
    {
        if(type == 0)
        {
            sprite = null;
            return;
        }
        Sprite[] allSprites = Resources.LoadAll<Sprite>(SPRITE_PATH);
        foreach(Sprite curSprite in allSprites)
        {
            if (curSprite.name == typeName)
            {
                sprite = curSprite;
                break;
            }
        }
    }

    public RPS(string name)
    {
        switch (name)
        {
            case "rock":
                type = ROCK;
                typeName = "rock";
                break;
            case "paper":
                type = PAPER;
                typeName = "paper";
                break;
            case "scissors":
                type = SCISSORS;
                typeName = "scissors";
                break;
            default:
                type = 0;
                typeName = null;
                break;
        }
        LoadSprite();
    }
    
    public RPS(int type)
    {
        switch (type)
        {
            case ROCK:
                this.type = ROCK;
                this.typeName = "rock";
                break;
            case PAPER:
                this.type = PAPER;
                this.typeName = "paper";
                break;
            case SCISSORS:
                this.type = SCISSORS;
                this.typeName = "scissors";
                break;
            default:
                this.type = 0;
                this.typeName = null;
                break;
        }
        LoadSprite();
    }

    public static bool operator==(RPS l, RPS r)
    {
        return l.type == r.type;
    }

    public static bool operator!=(RPS l, RPS r)
    {
        return l.type != r.type;
    }

    public override bool Equals(object obj)
    {
        RPS rPS = obj as RPS;
        if(rPS == null)
        {
            return false;
        }
        return rPS.type == this.type;
    }

    public override int GetHashCode()
    {
        return type;
    }

    public static bool operator<(RPS l, RPS r)
    {
        if (l.type == 0 || r.type == 0)
        {
            return false;
        }
        if (l.type == PAPER && r.type == SCISSORS)
        {
            return true;
        }
        if (l.type == SCISSORS && r.type == ROCK)
        {
            return true;
        }
        if (l.type == ROCK && r.type == PAPER)
        {
            return true;
        }
        return false;
    }

    public static bool operator>(RPS l, RPS r)
    {
        if (l.type == 0 || r.type == 0)
        {
            return false;
        }
        if (l.type == SCISSORS && r.type == PAPER)
        {
            return true;
        }
        if (l.type == ROCK && r.type == SCISSORS)
        {
            return true;
        }
        if (l.type == PAPER && r.type == ROCK)
        {
            return true;
        }
        return false;
    }
}
