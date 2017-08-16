## Demo on Referral URL Parameter(BETA)

## Assumption:
1. If you want to follow the demo, please install Sitecore Habitat sample site.

## Steps to Test Referral URL Parameter:

1. Login to the Sitecore Client using your prefered browser.

![image](https://cloud.githubusercontent.com/assets/2329372/26075898/d4ffd252-396b-11e7-8b89-5388328049e4.png)

2. In Sitecore Launchpad click on **Desktop**.

![image](https://user-images.githubusercontent.com/2329372/29325656-16fda4fc-821b-11e7-8270-b68963439398.png)

3. In Sitecore Desktop Click **Experience Editor**.

![image](https://user-images.githubusercontent.com/2329372/29379798-30713558-82f6-11e7-9a6d-9af4c48bc508.png)

4. In the Experience Editor click Teaser Component and click Personalize the component. 

![image](https://user-images.githubusercontent.com/2329372/29380044-029c1b60-82f7-11e7-9c34-6502434be6a2.png)

5. A Personalize the Component dialog will pop out and click **Edit Rule**.

![image](https://user-images.githubusercontent.com/2329372/29380199-7b2aacd6-82f7-11e7-8442-56075cfcd7e6.png)

6. In the Search box type **UTM** to locate Referral URL Parameter that you Install in the Package.

![image](https://user-images.githubusercontent.com/2329372/29380620-eff33f78-82f8-11e7-8c21-1aad17a951cb.png)

7.	In this Demo will be using **UTM_TERM** and click **contains** and select comparision **is equal to**.

![image](https://user-images.githubusercontent.com/2329372/29380792-9144d81e-82f9-11e7-9533-c42fb04ec6fc.png)

![image](https://user-images.githubusercontent.com/2329372/29380803-a1d11328-82f9-11e7-8c96-70ff88c30d2c.png)

8.	Click **Specific Value** and Enter **paidkeyword**.

![image](https://user-images.githubusercontent.com/2329372/29380901-03e4a994-82fa-11e7-99d8-09774824bb64.png)

![image](https://user-images.githubusercontent.com/2329372/29380926-1100f5ce-82fa-11e7-9432-48df9c761725.png)

9.	Click **OK**.

![image](https://user-images.githubusercontent.com/2329372/29380967-384d481c-82fa-11e7-890b-cb9fea1fca60.png)

10.	In the **Action** Panel Click **Hide** which means if utm_term is equal to paidkeyword the Page Teaser Component Introduction to Habitat will be Hidden otherwise if utm_term is not equal to paidkeyword the Page Teaser Component Introduction to Habitat will be Shown.

![image](https://user-images.githubusercontent.com/2329372/29381197-ff12b568-82fa-11e7-9cd1-aab2f8f2bf72.png)

![image](https://user-images.githubusercontent.com/2329372/29381230-1219df56-82fb-11e7-9ef7-5efcd8d79c98.png)

11.	Click **Save Button** to save the changes made.

![image](https://user-images.githubusercontent.com/2329372/29381333-60f502d6-82fb-11e7-82a5-e6404d704f9b.png)

12. In the Ribbon Click **Home** Select **Publish** and use **Smart Publish** Check Publish related items and Publish subitems and then Click **Publish**.

![image](https://user-images.githubusercontent.com/2329372/29381424-be6d38c0-82fb-11e7-8865-0d63847056b3.png)

13. To check if the Item is Publish we will use **Telerik Fiddler Web Debugger** since its still a BETA testing open Fiddler.

14.	In Fiddler right panel Click **composer** type this in the textbox **http://rup/?utm_term=paidkeyword** and add this the textarea see image below.
	User-Agent: Fiddler
	Referer: http:/www.google.com/
	Host: rup

![image](https://user-images.githubusercontent.com/2329372/29381605-6abc746a-82fc-11e7-8e17-70081dad08dd.png)

15.	Execute the query.

![image](https://user-images.githubusercontent.com/2329372/29381796-0d7ce978-82fd-11e7-9d2b-5e173e375468.png)

16.	Check if the Page Teaser Component is hidden since the condition is utm_term is equal to paidkeyword and if its false the Page Teaser Component is visible.

17.	utm_term is equal to paidkeyword which is true it should be hidden.

![image](https://user-images.githubusercontent.com/2329372/29382291-aea0ab90-82fe-11e7-83b4-afdea5fcf409.png)

18.	utm_term is equal to changethisvaluetoshownpageteaser which is false it should be visible.

![image](https://user-images.githubusercontent.com/2329372/29382325-cd5dd36e-82fe-11e7-9c3f-a15691074c77.png)

19.	End

## Supports

+ For support please email the author or [create an issue](https://github.com/raseniero/Sitecore.SBOS.LinkManager/issues/new).
+ Tested on Sitecore CMS 8.2 Update 1 or later

THIS MODULE IS PROVIDED ON AN "AS IS" BASIS, WITHOUT SUPPORT, WARRANTIES OR CONDITIONS OF ANY KIND.