using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PopupEndGame : UIPopupComponent
{
    public TextMeshProUGUI txtScore;

    private GameManager gameManager => GameManager.Instance;

    public override void OnShown()
    {
        base.OnShown();

        txtScore.text = gameManager.Level.ToString();
        //await CoreGame.CoreClient.Instance.ReportHightScore("knife_score", (long)gameManager.Level);
    }

    public void OnClickedRetry()
    {
        gameManager.UpdateGameLevel(1);
        gameManager.ResetGame();
        this.ClosePopup();
    }
}
