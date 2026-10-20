using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;

public class boton : MonoBehaviour
{
    public TMP_Dropdown dropdown;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Start()
    {
        List<string> idiomas = new List<string> { "catalan", "english", "castellano" };

        dropdown.ClearOptions();
        dropdown.AddOptions(idiomas);
        
    }
    public void cambiarIdioma(int value)
    {
        var enLoc = LocalizationSettings.AvailableLocales.GetLocale("en");
        var esLoc = LocalizationSettings.AvailableLocales.GetLocale("es");
        var caLoc = LocalizationSettings.AvailableLocales.GetLocale("ca");
        switch (value)
        {
            case 0: LocalizationSettings.SelectedLocale = caLoc;
                break;
            case 1: LocalizationSettings.SelectedLocale = enLoc;
                break;
            case 2: LocalizationSettings.SelectedLocale = esLoc;
                break;
        }
    }
}
