using Sitecore.Diagnostics;
using Sitecore.Rules;
using Sitecore.Rules.Conditions;
using System;

namespace Sitecore.Analytics.Rules.Conditions
{
    public class HasUtmSourceMediumCampaign<T> : StringOperatorCondition<T> where T : RuleContext
    {
        public string UtmSource { get; set; }
        public string UtmMedium { get; set; }
        public string UtmCampaign { get; set; }
        protected override bool Execute(T ruleContext)
        {
            Assert.ArgumentNotNull(ruleContext, "ruleContext");
            Assert.IsNotNull(Tracker.Current, "The current Tracker is not initialized");
            Assert.IsNotNull(Tracker.Current.Session, "The current Tracker.Current.Session is not initialzied");
            Assert.IsNotNull(Tracker.Current.Interaction, "The current Tracker.Current.Interaction is not initialized");
            Assert.IsNotNullOrEmpty(this.UtmSource, "The UtmSource is not initialized");
            Assert.IsNotNullOrEmpty(this.UtmMedium, "The UtmMedium is not initialized");
            Assert.IsNotNullOrEmpty(this.UtmCampaign, "The UtmCampaign is not initialized");
            
            //get customValues from Current.Iteration
            var customValues = Tracker.Current.Interaction.CustomValues;

            //decalre variable objects
            object utmSourceObj, utmMediumObj, utmCampaignObj;

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
           
            if (utmMediumObj == null)
            {
                return false;
            }
            string utmCampaignmValue = utmCampaignObj.ToString();

            //does campaignvalue, mediumvalue, and sourcevalue compares?
            return this.Compare(utmCampaignmValue, this.UtmCampaign ?? String.Empty) && this.Compare(utmMediumValue, this.UtmMedium ?? String.Empty) && this.Compare(utmSourceValue, this.UtmSource ?? String.Empty);
        }
    }
}
