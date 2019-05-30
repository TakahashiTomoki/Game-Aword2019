using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;   //UIを使用可能にする

public class Swan : MonoBehaviour
{
    /********参考サイト********
     https://qiita.com/pilkul/items/eb9b4bbbb519772c3397
     http://d.hatena.ne.jp/uny_33/20150105/1420407788
    */
    public GameObject star1;
    public GameObject star2;
    public GameObject star3;
    public GameObject star4;
    public GameObject star5;
    public GameObject star6;
    public GameObject star7;
    public GameObject star8;
    public GameObject star9;
    public GameObject image;
    public GameObject line;
    public Text name;
    float time;
    int flg;
    int cflg;
    Text starttext;

    // Start is called before the first frame update
    void Start()
    {
        flg = 0;
        cflg = 0;
        starttext = GameObject.Find("start").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            cflg = 1;
        }
        if (cflg == 1)
        {
            starttext.enabled = false;
            time++;
        }
        output();
    }
    void output()
    {
        if (time >= 100f)
        {
            star1.GetComponent<SpriteRenderer>().color += new Color(255, 255, 0, 255);
        }
        if (time >= 200f)
        {
            star2.GetComponent<SpriteRenderer>().color += new Color(255, 255, 0, 255);
        }
        if (time >= 300f)
        {
            star3.GetComponent<SpriteRenderer>().color += new Color(255, 255, 0, 255);
        }
        if (time >= 400f)
        {
            star4.GetComponent<SpriteRenderer>().color += new Color(255, 255, 0, 255);
        }
        if (time >= 500f)
        {
            star5.GetComponent<SpriteRenderer>().color += new Color(255, 255, 0, 255);
        }
        if (time >= 600f)
        {
            star6.GetComponent<SpriteRenderer>().color += new Color(255, 255, 0, 255);
        }
        if (time >= 700f)
        {
            star7.GetComponent<SpriteRenderer>().color = new Color(255, 255, 0, 255);
        }
        if (time >= 800f)
        {
            star8.GetComponent<SpriteRenderer>().color = new Color(255, 255, 0, 255);
        }
        if (time >= 900f)
        {
            star9.GetComponent<SpriteRenderer>().color = new Color(255, 255, 0, 255);
        }
        if(time >= 1100f)
        {
            star1.GetComponent<SpriteRenderer>().color = new Color(255, 255, 0, 0);
            star2.GetComponent<SpriteRenderer>().color = new Color(255, 255, 0, 0);
            star3.GetComponent<SpriteRenderer>().color = new Color(255, 255, 0, 0);
            star4.GetComponent<SpriteRenderer>().color = new Color(255, 255, 0, 0);
            star5.GetComponent<SpriteRenderer>().color = new Color(255, 255, 0, 0);
            star6.GetComponent<SpriteRenderer>().color = new Color(255, 255, 0, 0);
            star7.GetComponent<SpriteRenderer>().color = new Color(255, 255, 0, 0);
            star8.GetComponent<SpriteRenderer>().color = new Color(255, 255, 0, 0);
            star9.GetComponent<SpriteRenderer>().color = new Color(255, 255, 0, 0);
            flg = 1;
        }

        if (time >= 1200 && flg == 1)
        {
            star1.GetComponent<SpriteRenderer>().color = new Color(255, 255, 0, 255);
            star2.GetComponent<SpriteRenderer>().color = new Color(255, 255, 0, 255);
            star3.GetComponent<SpriteRenderer>().color = new Color(255, 255, 0, 255);
            star4.GetComponent<SpriteRenderer>().color = new Color(255, 255, 0, 255);
            star5.GetComponent<SpriteRenderer>().color = new Color(255, 255, 0, 255);
            star6.GetComponent<SpriteRenderer>().color = new Color(255, 255, 0, 255);
            star7.GetComponent<SpriteRenderer>().color = new Color(255, 255, 0, 255);
            star8.GetComponent<SpriteRenderer>().color = new Color(255, 255, 0, 255);
            star9.GetComponent<SpriteRenderer>().color = new Color(255, 255, 0, 255);
            image.GetComponent<SpriteRenderer>().color += new Color(0.005f, 0.005f, 0.005f, 0.005f);
            line.GetComponent<SpriteRenderer>().color += new Color(0.01f, 0.01f, 0.01f, 0.01f);
        }
        if (time >= 1300)
        {
            name.GetComponent<Text>().color += new Color(0, 0.01f, 0, 0.01f);
            flg = 2;
        }
        if(time >= 1400 && flg == 2)
        {

        }
    }
}