using Sitecore.Diagnostics;
using Sitecore.Rules;
using Sitecore.Rules.Conditions;
using System;

namespace Sitecore.Analytics.Rules.Conditions
{
  public class HasGoogleAdsKeywords<T> : StringOperatorCondition<T> where T : RuleContext
  {
    public string Keywords { get; set; }
    protected override bool Execute(T ruleContext)
    {
      Assert.ArgumentNotNull(ruleContext, "ruleContext");
      Assert.IsNotNull(Tracker.Current, "The current Tracker is not initialized");
      Assert.IsNotNull(Tracker.Current.Session,"The current Tracker.Current.Session is not initialzied");
      Assert.IsNotNull(Tracker.Current.Interaction, "The current Tracker.Current.Interaction is not initialized");
      Assert.IsNotNullOrEmpty(this.Keywords, "The Keyword is not initialized");

      //get CustomValues from Interaction
      var customValues = Tracker.Current.Interaction.CustomValues;
      
      //get keywords value if one exist otherwise exit method
      object keywordsValueObj;
      if (!customValues.TryGetValue("keyword_k", out keywordsValueObj))
      {
        throw new InvalidOperationException("CustomValues does not contain specified key");
      }

      if (keywordsValueObj == null)
      {
        return false;
      }

      string keywordsValue = keywordsValueObj.ToString();

      //does keywords compares?
      return this.Compare(keywordsValue, this.Keywords ?? String.Empty);
    }
  }
}
