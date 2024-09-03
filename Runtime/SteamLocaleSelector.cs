using System;
using System.Collections.Generic;
using System.Linq;
using Steamworks;
using UnityEngine;

namespace Audune.Localization.Steam
{
  // Class that defines a locale selector that uses the Steam application language
  [AddComponentMenu("Audune/Localization/Locale Selectors/Steam Locale Selector")]
  public sealed class SteamLocaleSelector : LocaleSelector
  {
    // Locale selector properties
    [SerializeField, Tooltip("The alt code of a locale to compare to the Steam language")]
    private string _code = "steam";
    
    
    // Return if a locale could be selected according to this selector and store the selected locale
    public override bool TrySelectLocale(IReadOnlyList<ILocale> locales, out ILocale locale)
    {
      locale = null;

      try
      {
        var language = SteamApps.GetCurrentGameLanguage();
        if (string.IsNullOrEmpty(language))
            return false;
        
        locale =  locales.Where(locale => locale.altCodes.TryGetValue(_code, out var code) && code == language).FirstOrDefault();
        return locale != null;
      }
      catch (InvalidOperationException ex)
      {
        Debug.LogWarning($"Cannot resolve locale using Steam locale selector: {ex.Message}", this);
        return false;
      }
    }
  }
}