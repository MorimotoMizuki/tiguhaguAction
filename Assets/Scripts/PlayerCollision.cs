using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerController playerController;
    public Blinkinger blinkinger;
    public Gameclearover gameclearover;
    public HPbarManager hpbarManager;
    public GameManager gameManager;
    public Clear_pic_Generate clear_pic_generate;
    public StageSEManager stageSEManager;

    public bool isBlink = false;//点滅しているかどうか
    public ScoreManager scoreManager;

    public int stage1MAXscore;
    public int stage2MAXscore;
    public int stage3MAXscore;
    public int playerHPMAX;

    private Collider otherCol;

    public void PCollision(Collider other)//接触時に呼び出される
    {
        otherCol = null;
        if (other.gameObject.tag == "Obstacle")//障害物(小石)
        {
            playerController.playerHP-=5;
            hpbarManager.HPdamage();
            isBlink = true;
            otherCol = other.gameObject.GetComponent<MeshCollider>();
            otherCol.enabled = false;
            stageSEManager.DamageSE();
        }
        if (other.gameObject.tag == "Obstacle2")//障害物(岩)
        {
            playerController.playerHP -= 10;
            hpbarManager.HPdamage();
            isBlink = true;
            otherCol = other.gameObject.GetComponent<MeshCollider>();
            otherCol.enabled = false;
            stageSEManager.DamageSE();
        }
        if (other.gameObject.tag == "IronBall")//障害物(鉄球)
        {
            playerController.playerHP -= 15;
            hpbarManager.HPdamage();
            isBlink = true;
            otherCol = other.gameObject.GetComponent<MeshCollider>();
            otherCol.enabled = false;
            stageSEManager.DamageSE();
        }
        if (other.gameObject.tag == "Bard")//障害物(鳥)
        {
            playerController.playerHP -= 10;
            hpbarManager.HPdamage();
            isBlink = true;
            otherCol = other.gameObject.GetComponent<MeshCollider>();
            otherCol.enabled = false;
            stageSEManager.DamageSE();
        }
        if (other.gameObject.tag == "Obstacle3")//障害物(焼き石)
        {
            playerController.playerHP -= 10;
            hpbarManager.HPdamage();
            isBlink = true;
            otherCol = other.gameObject.GetComponent<MeshCollider>();
            otherCol.enabled = false;
            stageSEManager.DamageSE();
        }
        if (other.gameObject.tag == "Obstacle4")//障害物(焼き岩)
        {
            playerController.playerHP -= 15;
            hpbarManager.HPdamage();
            isBlink = true;
            otherCol = other.gameObject.GetComponent<MeshCollider>();
            otherCol.enabled = false;
            stageSEManager.DamageSE();
        }
        if (other.gameObject.tag == "RedBall")//障害物(赤球)
        {
            playerController.playerHP -= 20;
            hpbarManager.HPdamage();
            isBlink = true;
            otherCol = other.gameObject.GetComponent<MeshCollider>();
            otherCol.enabled = false;
            stageSEManager.DamageSE();
        }
        if (other.gameObject.tag == "HeelPotion")//回復ポーション
        {
            if(playerController.playerHP != playerHPMAX)
            {
                if (playerHPMAX - playerController.playerHP > 5)
                {
                    playerController.playerHP += 5;
                }
                else if(playerHPMAX - playerController.playerHP < 5)
                {
                    playerController.playerHP += playerHPMAX - playerController.playerHP;
                }
                hpbarManager.HPdamage();
                stageSEManager.HeelSE();
            }
            Destroy(other.gameObject);
        }

        if(other.gameObject.tag == "Over")//ゲームオーバー
        {
            playerController.isOver = true;
        }

        if (other.gameObject.tag=="Clear")//クリアWall
        {
            gameclearover.GameClearobj.SetActive(true);
            playerController.isClear = true;
            stageSEManager.ClearSE();

            //スコアを保存かつParfectかどうか見る
            if (GameManager.stage_num == 1)
            {
                if(scoreManager.score_num>PlayerPrefs.GetInt("STAGE1SCORE",-1))
                    PlayerPrefs.SetInt("STAGE1SCORE", scoreManager.score_num);
                if (scoreManager.score_num == stage1MAXscore && playerController.playerHP == playerHPMAX)
                    GameManager.stage1_P = true;
            }
            if (GameManager.stage_num == 2)
            {
                if (scoreManager.score_num > PlayerPrefs.GetInt("STAGE2SCORE", -1))
                    PlayerPrefs.SetInt("STAGE2SCORE", scoreManager.score_num);
                if (scoreManager.score_num == stage2MAXscore && playerController.playerHP == playerHPMAX)
                    GameManager.stage2_P = true;
            } 
            if (GameManager.stage_num == 3)
            {
                if (scoreManager.score_num > PlayerPrefs.GetInt("STAGE3SCORE", -1))
                    PlayerPrefs.SetInt("STAGE3SCORE", scoreManager.score_num);
                if (scoreManager.score_num == stage3MAXscore && playerController.playerHP == playerHPMAX)
                    GameManager.stage3_P = true;
            }
            if (GameManager.stage_num == 1)
                GameManager.stage1_clear = true;
            if (GameManager.stage_num == 2)
                GameManager.stage2_clear = true;
            if (GameManager.stage_num == 3)
                GameManager.stage3_clear = true;

            //クリアした時の演出
            clear_pic_generate.ClearDisplay();
        }
        if(other.gameObject.tag == "Gold")//金コイン
        {
            scoreManager.score_num += 3000;
            Destroy(other.gameObject);
            stageSEManager.CoinSE();
        }
        if(other.gameObject.tag == "Silver")//銀コイン取得時
        {
            scoreManager.score_num += 1500;
            Destroy(other.gameObject);
            stageSEManager.CoinSE();
        }
        if(other.gameObject.tag == "Copper")//銅コイン取得時
        {
            scoreManager.score_num += 1000;
            Destroy(other.gameObject);
            stageSEManager.CoinSE();
        }
        Debug.Log(other.gameObject.name);
        Debug.Log(other.gameObject.tag);
    }
}
