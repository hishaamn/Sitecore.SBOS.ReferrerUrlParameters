# Installed SBOS Referrer URL Parameter v0.3
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
1. [Download Sitecore Package v0.3](https://github.com/raseniero/Sitecore.SBOS.ReferrerUrlParameters)
2. Install using Sitecore's Package Installer

## Getting Started
Below are the steps on how to install and this package.

1. Login in Sitecore Client.

![image](https://cloud.githubusercontent.com/assets/2329372/26075898/d4ffd252-396b-11e7-8b89-5388328049e4.png)

2. On Sitecore Experience Platform click **Desktop**.

![image](https://user-images.githubusercontent.com/2329372/29325656-16fda4fc-821b-11e7-8270-b68963439398.png)

3. On desktop click **Sitecore logo**.

![image](https://user-images.githubusercontent.com/2329372/29327055-62eb498c-8220-11e7-94a8-4145fad4b54f.png)

4. On sitecore logo click **developer tools**.
5. Click *installation wizard*.

![image](https://user-images.githubusercontent.com/2329372/29327076-7a8a3bca-8220-11e7-8d0a-939c4729ddc0.png)

6. To Upload File: Click upload and select the package you want to upload. Then **Choose** a package and Choose a newly added Sitecore SBOS Referrer URL Parameter v0.3.zip and Click **Next**.

![image](https://user-images.githubusercontent.com/2329372/29378470-c554ef70-82f1-11e7-9ff3-9aa7c4caa313.png)

7. Now we can **install** the package.

![image](https://user-images.githubusercontent.com/2329372/29378564-1a87faa0-82f2-11e7-9d1b-519f31e6e192.png)

8. Overwrite the files click **Yes to All**.

![image](https://user-images.githubusercontent.com/2329372/29378623-5e0768c4-82f2-11e7-842e-ef218b556cf6.png)

9. You can now check **Restart the Sitecore Client** and click **Close**.

![image](https://user-images.githubusercontent.com/2329372/29327349-6bd021b6-8221-11e7-97b0-9b1a234bf83e.png)


## Supports
+ For support please email the author or [create an issue](https://github.com/raseniero/Sitecore.SBOS.ReferrerUrlParameters/issues/new).
+ Tested on Sitecore CMS 8.2 or later

THIS MODULE IS PROVIDED ON AN "AS IS" BASIS, WITHOUT SUPPORT, WARRANTIES OR CONDITIONS OF ANY KIND.
