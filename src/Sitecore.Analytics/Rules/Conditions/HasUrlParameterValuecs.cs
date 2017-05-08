using Sitecore.Diagnostics;
using Sitecore.Rules;
using Sitecore.Rules.Conditions;
using System;

namespace Sitecore.Analytics.Rules.Conditions
{
  public class HasUrlParameterAndValue<T> : StringOperatorCondition<T> where T : RuleContext
  {
    public string UrlParameter { get; set; }
    public string UrlParameterValue { get; set; }

    protected override bool Execute(T ruleContext)
    {
      Assert.ArgumentNotNull(ruleContext, "ruleContext");
      Assert.IsNotNull(Tracker.Current, "The current Tracker is not initialized");
      Assert.IsNotNull(Tracker.Current.Session, "The current Tracker.Current.Session is not initialzied");
      Assert.IsNotNull(Tracker.Current.Interaction, "The current Tracker.Current.Interaction is not initialized");
      Assert.IsNotNullOrEmpty(this.UrlParameter, "The UrlParameter is not initialized");
      Assert.IsNotNullOrEmpty(this.UrlParameterValue, "The UrlParameterValue is not initialized");

      throw new NotImplementedException();
    }
  }
}
