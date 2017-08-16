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

## Getting Started

1. [Download Sitecore Package v0.3](https://github.com/raseniero/Sitecore.SBOS.ReferrerUrlParameters)

2. Install using Sitecore's Package Installer, See the steps on how to install SBOS Referrer URL Parameter-v0.3.zip. (https://github.com/raseniero/Sitecore.SBOS.ReferrerUrlParameters/blob/master/PACKAGE-README(v0.3).md)

3. After Installing the Package Clone the repository.
4. Open the Solution file in Visual Studio.

![image](https://user-images.githubusercontent.com/2329372/29376980-f07e808a-82ec-11e7-8c92-4b1a742aacdc.png)

5. Right-click the Project Solution and then click **Restore NuGet Packages** to load all References.

![image](https://user-images.githubusercontent.com/2329372/29377272-e68d3354-82ed-11e7-80c2-1df3c8bc12a7.png)

6. Build the solution to compile all code files.
7. Copy the dll of your solution in the root folder and transfer the dll into the Instance which have a **Default** path of **C:\inetpub\wwwroot\NameOfYourInstance\Website\bin** and paste it t.

![image](https://user-images.githubusercontent.com/2329372/29377482-878cca94-82ee-11e7-9aa0-d865f46a3263.png)

8. Publish the Website folder of your solution to Publish your Custom Config file into your Sitecore Instance. Right-click the project solution and then select **Publish Web App**.

![image](https://user-images.githubusercontent.com/2329372/29377784-711fc2f6-82ef-11e7-86cf-4e7c39c9ab3d.png)

9. Inside Publish dialog click **Profile** tab select **Custom** to create new custom profile and enter Profile name after click **Next** Button to continue in connection tab.

![image](https://user-images.githubusercontent.com/2329372/29326763-5e2cfb8a-821f-11e7-8a4c-3fa531d215ef.png)

10. Inside Connection tab in the Publish method select **File System** and on Target Location enter your Sitecore Instance then click **Next** Button to continue in Settings tab.

![image](https://user-images.githubusercontent.com/2329372/29326802-83fd2830-821f-11e7-955a-a3ca4c99e6bf.png)

11. Inside Settings tab in the Configuration select **Debug** and then click **Next** Button to continue in Preview tab.

![image](https://user-images.githubusercontent.com/2329372/29326848-ac5a1c52-821f-11e7-9d1c-d6b147ab3a10.png)

12. Inside Preview tab set the Dropdown list to the Custom Profile you created and then Click publish to deploy all files inside your Sitecore Instance.

![image](https://user-images.githubusercontent.com/2329372/29326877-c8f1ceb4-821f-11e7-9521-0ef4781ecc74.png)

13. End

## Supports
+ For support please email the author or [create an issue](https://github.com/raseniero/Sitecore.SBOS.ReferrerUrlParameters/issues/new).
+ Tested on Sitecore CMS 8.2 or later

THIS MODULE IS PROVIDED ON AN "AS IS" BASIS, WITHOUT SUPPORT, WARRANTIES OR CONDITIONS OF ANY KIND.
