using System.Collections.Generic;
using System.Linq;
using Foundation.Localization;
using UnityEngine;

public class LocalizationExample : MonoBehaviour
{
    /// <summary>
    /// Example of how to localize your code behind
    /// </summary>
    [Localized("Eamples.ExampleString1")]
    public static string ExampleString = "Hello Friend";


    public void Awake()
    {
        //Localizes the example string
        LocalizationService.Instance.Localize(this);

        //alt way of getting strings
        var s = LocalizationService.Instance.Get("Eamples.ExampleString1");

        // auto magical string updates
        var s2 = ExampleString;
    }

    /// <summary>
    /// Example of how to change the language
    /// </summary>
    public void RandomLanguage()
    {
        var languages = LocalizationService.Instance.Languages;
        
        LocalizationService.Instance.Language = Random(languages);
    }


    static T Random<T>(IEnumerable<T> list)
    {
        var count = list.Count();

        if (count == 0)
            return default(T);

        return list.ElementAt(UnityEngine.Random.Range(0, count));
    }
}
