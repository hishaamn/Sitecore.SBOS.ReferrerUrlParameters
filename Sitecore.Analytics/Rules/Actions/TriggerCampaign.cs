using Sitecore.Analytics.Data.Items;
using Sitecore.Data.Items;
using Sitecore.Diagnostics;
using Sitecore.Rules;
using Sitecore.Rules.Actions;

namespace Sitecore.Analytics.Rules.Actions
{
  public class TriggerCampaign<T> : RuleAction<T> where T : RuleContext
  {
    public string CampaignId { get; set; }
    public override void Apply(T ruleContext)
    {
      Assert.ArgumentNotNull(ruleContext, "ruleContext");
      Assert.IsNotNull(Tracker.Current, "The current Tracker is not initialized");
      Assert.IsNotNull(Tracker.Current.Session, "The current Tracker.Current.Session is not initialzied");
      Assert.IsNotNull(Tracker.Current.CurrentPage, "The current Tracker.Current.CurrentPage is not initialized");
      Assert.IsNotNullOrEmpty(this.CampaignId, "The CampaignId is not initialized");

      //trigger the campaign
      Item campaignItem = Sitecore.Context.Database.GetItem(this.CampaignId);
      CampaignItem compaignToTrigger = new CampaignItem(campaignItem);
      Tracker.Current.CurrentPage.TriggerCampaign(compaignToTrigger);
    }
  }
}
