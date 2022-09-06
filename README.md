# Template project for modding Pathfinder: Wrath of the Righteous

Includes 
- Publicize task
- On build event to copy your built mod into Mods folder.
- On release build event to zip your built mod and put it into PublishOutput folder

## Setup 

0. Install UMM if you don't have it.
1. Set `WrathPath` environemnt variable to point 
2. Rename stuff
    Do full text replacement
    - `TemplateWotRModProject` -> `Your project name`
    - `TemplateWotRModAuthor` -> `Your name`
    Rename TemplateWotRModProject.csproj and TemplateWotRModProject.sln
3. Open in Visual Studio.
4. Click on Solution -> Restore Nuget packages
5. Do Build -> Clean Solution.
6. Write your code
7. Don't forget to change this readme.
8. Set your homepage and repository in Info.json