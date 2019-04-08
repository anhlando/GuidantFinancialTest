##### Guidant Financial Test ######

1. Clone this repo to your local machine

2. Open it within Microsoft Visual Studio (2017 or above)

3. Copy the chromedriver.exe file from "\lib" to "C:\Users\[your_username]\AppData\Roaming\GuidantFinancialTest\lib" folder 
--> this folder could be used to store the config files & other neccessary files in the future. Within the source code, there is a Helper.cs class that has the method to getLibFolder() which will return the absolute path to this folder.

4. Open 'Test Exporer' panel within Microsoft VS -> you will see the 'HomepageTestFeature' displayed there -> expand it and you will see 5 scenarios: SubmitHomepageWithEmptyFields (4 scenarios) and SubmitHomepageWithValidInfo (1 scenario)

5. Right-click on the scenario(s)/feature(s) you want to run -> Run it, then sit back and watch the test script to be run
