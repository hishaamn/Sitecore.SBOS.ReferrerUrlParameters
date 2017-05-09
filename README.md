# Sitecore.SBOS.ReferrerUrlParameters (v1.0)
This is a module that captures Google's referrer URL parameters and provides a 
custom Condition that you can use to personalized base on there values.

### Scenario

A Google AdWords campaign is set on a landing page on http://www.connecttheexperience.com/thebook and 
Google has generated this Url parameter when the ads shows up on the search page 
http://www.connecttheexperience.com/thebook?utm_source=newsletter&utm_medium=email&utm_campaign=AprilCampaign&utm_term=paidkeyword&utm_content=examplecontent. 
This module parses and captures the parameters and saves it on the 
current Interaction and provides custom Conditions that you can use to 
personalize based on there values.

**Referral URL parameters** 
   
   where the utm_source contains value and the utm_medium contains value and utm_campaign contains value  
   
   where the utm_term contains value

   where the utm_content contains value

   where the URL parameter contains value

   where the Google Adwords Value Track keywords contains value



### Features

1. Captures and personalized on Google AdWords Value Track's **Keyword** parameters 
2. Captures and personalized on Google's UTM parameters namely below

   * Utm_Source
   * Utm_Medium
   * Utm_Campaign
   * Utm_Content
   * Utm_Term

### Installation Instructions

1. [Download Sitecore Package v1.0](https://github.com/raseniero/Sitecore.SBOS.ReferrerUrlParameters)
2. Install using Sitecore's Package Installer

### Supported Products
+ Tested on Sitecore CMS 8.2 or later

THIS MODULE IS PROVIDED ON AN "AS IS" BASIS, WITHOUT SUPPORT, WARRANTIES OR CONDITIONS OF ANY KIND.
