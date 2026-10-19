using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;

public class boton : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created


    public void cambiarIdioma()
    {
        var enLoc = LocalizationSettings.AvailableLocales.GetLocale("en");
        var esLoc = LocalizationSettings.AvailableLocales.GetLocale("es");
        var caLoc = LocalizationSettings.AvailableLocales.GetLocale("ca");

        if (LocalizationSettings.SelectedLocale == enLoc)
        {
            LocalizationSettings.SelectedLocale = esLoc;
        }
        if(LocalizationSettings.SelectedLocale == esLoc)
        {
            LocalizationSettings.SelectedLocale = caLoc;
        }
        if(LocalizationSettings.SelectedLocale == caLoc)
        {
            LocalizationSettings.SelectedLocale = caLoc;
        }

        Debug.Log("hola");
    }
}
