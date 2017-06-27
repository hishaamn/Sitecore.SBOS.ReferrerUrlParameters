using Sitecore.Diagnostics;
using Sitecore.Rules;
using Sitecore.Rules.Conditions;
using System;

namespace Sitecore.Analytics.Rules.Conditions
{
  public class HasUtmMedium<T> : StringOperatorCondition<T> where T : RuleContext
  {
    public string UtmMedium { get; set; }

    protected override bool Execute(T ruleContext)
    {
      Assert.ArgumentNotNull(ruleContext, "ruleContext");
      Assert.IsNotNull(Tracker.Current, "The current Tracker is not initialized");
      Assert.IsNotNull(Tracker.Current.Session, "The current Tracker.Current.Session is not initialzied");
      Assert.IsNotNull(Tracker.Current.Interaction, "The current Tracker.Current.Interaction is not initialized");
      Assert.IsNotNullOrEmpty(this.UtmMedium, "The UtmMedium is not initialized");

      //get customValues from Current.Iteration
      var customValues = Tracker.Current.Interaction.CustomValues;

      //decalre variable objects
      object utmMediumObj;

      //get utmMediumObj value if one exist otherwise exit method
      if (!customValues.TryGetValue("utm_medium", out utmMediumObj))
      {
        throw new InvalidOperationException("CustomValues does not contain specified key");
      }

      if (utmMediumObj == null)
      {
        return false;
      }
      
      string utmMediumValue = utmMediumObj.ToString();

      if (this.Compare(utmMediumValue, this.UtmMedium ?? String.Empty))
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}
