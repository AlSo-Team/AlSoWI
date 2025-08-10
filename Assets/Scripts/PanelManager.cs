using AlSo.WI;
using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;


public class PanelManager : MonoBehaviour
{
    private void Start()
    {
        CommonScreen screen = new CommonScreen();
        IPanelView view = new PanelScrollableView();
        screen.AddChild(view);

        IArticleSetController controller = new ArticleSetController(view);
        IArticleSetModel model = new ArticleSetModel();
        controller.Data = model;


        //mainMenuCtrl = new MainMenuCtrl(view);

        //mainMenuCtrl.OnFirstHandler = ShowSettings;
        //mainMenuCtrl.OnSecondHandler = () => Debug.LogError("second");
        //mainMenuCtrl.Enable();

        //VisualTreeAsset asset = Resources.Load<VisualTreeAsset>("UI/Item");
        //for (int i = 0; i < 5; i++)
        //{ 
        //    TemplateContainer container = asset.Instantiate();

        //    view.VisualElement.Add(container.Q<VisualElement>());
        //}

    }

    //private void ShowSettings()
    //{
    //    settingsCtrl = new SettingsCtrl(new SettingsView());

    //    settingsCtrl.OnFirstHandler = () => Debug.LogError("first");
    //    settingsCtrl.OnSecondHandler = () => Debug.LogError("second");
    //    settingsCtrl.Enable();
    //    mainMenuCtrl.Hide();
    //}

}