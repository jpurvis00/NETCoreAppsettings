# NETCoreAppsettings
Course on appsettings from iamtimcorey.com  
   
This application is for playing with the appsettings.json file(s) structure and hierarchy.   
   
There are 5 places that you can create/use settings for an application. These are read in a top down hierarchy.   
   
1. Command Line - Launch an application from the command line with flags.  
2. Environment variables - local system vars(user vars or system vars).  
3. User Secrets - secrets.json - This is not picked up by version control and is a good place for things like connection strings, user id's and pw's in a developement environment.  This is not encrypted so things like prod pw's should be dealt with in a more secure fashion(ie. Azure Key Vault).  
4. Environment specific json files  
    - appsettings.Development.json
    - appsettings.Staging.json
    - appsettings.Production.json  
5. appsetting.json
