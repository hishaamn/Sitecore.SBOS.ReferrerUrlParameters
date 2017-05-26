# Sitecore.SBOS.ReferrerUrlParameters (BETA)
This is a module that captures Google's referrer URL parameters and provides a 
custom Condition that you can use to personalized base on there values.


For example, a Google AdWords campaign is set on a landing page on http://www.connecttheexperience.com/thebook and 
Google has generated this Url parameter when the ads shows up on the search page 
http://www.connecttheexperience.com/thebook?utm_source=newsletter&utm_medium=email&utm_campaign=AprilCampaign&utm_term=paidkeyword&utm_content=examplecontent. 
This module parses and captures the parameters and saves it on the 
current Interaction and provides custom Conditions that you can use to 
personalize based on there values.

**Referral URL parameters** 
   
...where the Google AdWords Value Track keywords **contains** **specific value**

...where the specific **URL parameter** **contains** **specific value**

...where the utm_content **contains** **specific value**

...where the utm_source **contains** **specific value** and the utm_medium **contains** **specific value** and utm_campaign **contains** **specific value**

...where the utm_term **contains** **specific value**

...where the utm_source **contains** **specific value** and the utm_medium **contains** **specific value** and utm_campaign **contains** **specific value** then trigger **specified campaign**
   
   
## Availability

This module is currently under development and in beta version. Please check back for latest updates.


## Installation Instructions

1. [Download Sitecore Package](https://github.com/raseniero/Sitecore.SBOS.ReferrerUrlParameters/blob/master/SBOS%20Referrer%20URL%20Parameter-v0.3.zip)
2. Follow this step-by-step instructions for [installing the package](https://github.com/raseniero/Sitecore.SBOS.ReferrerUrlParameters/blob/master/PACKAGE-README(v0.3).md).

## Supports
+ For support please email the author or [create an issue](https://github.com/raseniero/Sitecore.SBOS.ReferrerUrlParameters/issues/new).
+ Tested on Sitecore CMS 8.2 or later

THIS MODULE IS PROVIDED ON AN "AS IS" BASIS, WITHOUT SUPPORT, WARRANTIES OR CONDITIONS OF ANY KIND.
