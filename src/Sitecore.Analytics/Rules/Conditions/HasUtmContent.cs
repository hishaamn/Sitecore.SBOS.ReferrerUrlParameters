using Sitecore.Diagnostics;
using Sitecore.Rules;
using Sitecore.Rules.Conditions;
using System;

namespace Sitecore.Analytics.Rules.Conditions
{
  public class HasUtmContent<T> : StringOperatorCondition<T> where T : RuleContext
  {
    public string UtmContent { get; set; }
    protected override bool Execute(T ruleContext)
    {
      Assert.ArgumentNotNull(ruleContext, "ruleContext");
      Assert.IsNotNull(Tracker.Current, "The current Tracker is not initialized");
      Assert.IsNotNull(Tracker.Current.Session, "The current Tracker.Current.Session is not initialzied");
      Assert.IsNotNull(Tracker.Current.Interaction, "The current Tracker.Current.Interaction is not initialized");
      Assert.IsNotNullOrEmpty(this.UtmContent, "The Keyword is not initialized");

      //get CustomValues from Interaction
      var customValues = Tracker.Current.Interaction.CustomValues;
      
      //get UtmContentValueObj value if one exist otherwise exit method
      object UtmContentValueObj;
      if (!customValues.TryGetValue("utm_content", out UtmContentValueObj))
      {
        throw new InvalidOperationException("CustomValues does not contain specified key");
      }

      if (UtmContentValueObj == null)
      {
        return false;
      }

      string UtmContentValue = UtmContentValueObj.ToString();
      
      //does contentvalue compares?
      return this.Compare(UtmContentValue, this.UtmContent ?? String.Empty);
    }
  }
}
