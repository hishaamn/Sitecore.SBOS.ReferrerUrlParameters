using Sitecore.Diagnostics;
using Sitecore.Rules;
using Sitecore.Rules.Conditions;
using Sitecore.Data.Items;
using System;

namespace Sitecore.Analytics.Rules.Conditions
{
    public class HasUTMSourceMediumCampaignTriggerCampaign<T> : StringOperatorCondition<T> where T : RuleContext
    {
        public string UtmSource { get; set; }
        public string UtmMedium { get; set; }
        public string UtmCampaign { get; set; }
        public string CampaignId { get; set; }
        protected override bool Execute(T ruleContext)
        {
            Assert.ArgumentNotNull(ruleContext, "ruleContext");
            Assert.IsNotNull(Tracker.Current, "The current Tracker is not initialized");
            Assert.IsNotNull(Tracker.Current.Session, "The current Tracker.Current.Session is not initialzied");
            Assert.IsNotNull(Tracker.Current.Interaction, "The current Tracker.Current.Interaction is not initialized");
            Assert.IsNotNullOrEmpty(this.CampaignId, "The CampaignId is not initialized");
            Assert.IsNotNullOrEmpty(this.UtmCampaign, "The UtmCampaign is not initialized");
            Assert.IsNotNullOrEmpty(this.UtmMedium, "The UtmMedium is not initialized");
            Assert.IsNotNullOrEmpty(this.UtmSource, "The UtmSource is not initialized");

            //get customValues from Current.Iteration
            var customValues = Tracker.Current.Interaction.CustomValues;
            //decalre variable objects
            object utmSourceObj, utmMediumObj, utmCampaignObj;
            //check if campaignid is empty or null

            if (CampaignId == null)
            {
                return false;
            }
            Item CampaignValue = Sitecore.Context.Database.GetItem(CampaignId);
            //get utmSourceObj value if one exist otherwise exit method
            if (!customValues.TryGetValue("utm_source", out utmSourceObj))
            {
                throw new InvalidOperationException("CustomValues does not contain specified key");
            }

            if (utmSourceObj == null)
            {
                return false;
            }
            string utmSourceValue = utmSourceObj.ToString();
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
            //get utmCampaignObj value if one exist otherwise exit method
            if (!customValues.TryGetValue("utm_campaign", out utmCampaignObj))
            {
                throw new InvalidOperationException("CustomValues does not contain specified key");
            }

            if (utmCampaignObj == null)
            {
                return false;
            }
            string utmCampaignValue = utmCampaignObj.ToString();

            //does campaignvalue, mediumvalue, sourcevalue, and campaign_id compares?
            return this.Compare(utmCampaignValue, this.UtmCampaign ?? String.Empty) && this.Compare(utmMediumValue, this.UtmMedium ?? string.Empty) && this.Compare(utmSourceValue, this.UtmSource ?? String.Empty) && this.Compare(CampaignValue.ID.ToString(), CampaignId.ToString() ?? String.Empty);
        }
    }
}
