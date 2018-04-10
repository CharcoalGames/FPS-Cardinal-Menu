--------------------------------------------
[Cardinal Menu System by Metahusk | Community Project | Steam Server Browser, Credits, and Game Settings](http://repositories.metahusk.com/menu.hg):
An Unreal Engine 4 Community Online Menu System By Metahusk
--------------------------------------------

**Source Location:** [Repository Webpage](http://repositories.metahusk.com/menu.hg)

> **Clone Source Over HTTP:** http://repositories.metahusk.com/menu.hg

**Built Using:** [Unreal 4 Engine](http://www.unrealengine.com/what-is-unreal-engine-4) developed by [Epic Games, Inc.](http://epicgames.com) 

--------------------------------------------
About This Project
--------------------------------------------
We are releasing the menu from our game, Cardinal Fall, to the community for free. 
This project packages a combination of other community projects to create a single, easy to implement menu system. 
We will do our best to update the project with new engine releases. 
Thank you to all the community members who's content we employed to release this package.

--------------------------------------------
Getting Started 
--------------------------------------------
1. Create a Project Directory folder in your Unreal 4 Projects Directory.
> **Example Structure:** C:\Users\User\Documents\Unreal Projects\Directory_Name

2. Download the project or Clone the development files to your Unreal 4 Projects Directory using your favorite mercurial client.
>  **Hg Repository URL:** http://repositories.metahusk.com/menu.hg

 > **Common Mercurial Clients:** [SourceTree](http://www.sourcetreeapp.com/), [TortoiseHG](http://tortoisehg.bitbucket.org/), or [SmartGitHG](http://www.syntevo.com/smartgit/)

3. Download and Install Microsoft's Visual Studio Community 2015 for Windows Desktop
>  [Visual Studio Community 2015](https://www.visualstudio.com)

4a. Navigate to \Your_Directory\Plugins and extract the files in VictoryPlugin(newest-version).zip to the plugins directory into a folder called VictoryPlugin
>  **Plugins Directory Structure:** \Your_Directory\Plugins\VictoryPlugin\"plugin files"

4b. Navigate to \Your_Directory\Plugins and extract the files in MainMenuLib(newest-version).zip to the plugins directory into a folder called MainMenuLib
>  **Plugins Directory Structure:** \Your_Directory\Plugins\MainMenuLib\"plugin files"

4c. Navigate to \Your_Directory\Plugins and extract the files in AdvancedSessions(newest-version).zip to the plugins directory into a folder called AdvancedSessions
>  **Plugins Directory Structure:** \Your_Directory\Plugins\AdvancedSessions\"plugin files"

4d. Navigate to \Your_Directory\Plugins and extract the files in LoadingScreen-master(newest-version).zip to the plugins directory into a folder called LoadingScreen-master
>  **Plugins Directory Structure:** \Your_Directory\Plugins\LoadingScreen-master\"plugin files"

4e. Navigate to \Your_Directory\Plugins and extract the files in GamepadUMGPlugin(newest-version).zip to the plugins directory into a folder called GamepadUMGPlugin
>  **Plugins Directory Structure:** \Your_Directory\Plugins\GamepadUMGPlugin\"plugin files"

5. Execute cardinal.uproject and click _Yes_ to Recompile Project Modules.
6. Enable The Web Browser Plugin at Edit -> Plugins -> Widgets -> Web Browser
7. Navigate to the MainMenu Blueprints folder at \Cardinal\MainMenu\Blueprints
8. Insert your GameModes into Enum_GameModes, list your available map names to Enum_Maps, and set your server host's preferred maximum number of players to Enum_NumberOfPlayers using the supplied pattern. 
For skipped number of player options, use the enumeration's integer. For the number of players option you'd like available, spell out the integer. 
For example: 0, 1, Three will make a server with a maximum of "Three Players." (Please note the game modes and player limits are not implemented in the actual project. This is up to the end user to implement.)
9. Enjoy :)
***NOTE: To utilize Steam you must launch as a "Standalone Game" or utilize a packaged build with Steam running.***


--------------------------------------------
Windows US Keyboard Default Input Bindings
\Saved\Config\Windows\Input.ini and \Config\DefaultInput.ini
--------------------------------------------
[/Script/Engine.InputSettings]
ActionMappings=(ActionName="Jump",Key=SpaceBar,bShift=False,bCtrl=False,bAlt=False,bCmd=False)
ActionMappings=(ActionName="Menu",Key=M,bShift=False,bCtrl=False,bAlt=False,bCmd=False)
AxisMappings=(AxisName="Backward",Key=S,Scale=-1.000000)
AxisMappings=(AxisName="Forward",Key=W,Scale=1.000000)
AxisMappings=(AxisName="LookDown",Key=None,Scale=1.000000)
AxisMappings=(AxisName="LookUp",Key=MouseY,Scale=-1.000000)
AxisMappings=(AxisName="TurnLeft",Key=MouseX,Scale=1.000000)
AxisMappings=(AxisName="TurnRight",Key=None,Scale=-1.000000)

[/Script/Engine.Console]
HistoryBuffer=mexit
HistoryBuffer=exit




--------------------------------------------
Project Credits
--------------------------------------------
 **Project Credits:** 
Metahusk, mordentral, rama, Thaddeus Delude (parvan), The Tune Peddler, ZioYuri78

**Cardinal Menu:**
This project was put together by Metahusk using a collection of community content. Please credit everyone listed here and provide a link to our websites.

**Project Blueprints:**
This project’s blueprint files are released under the Creative Commons Attribution 4.0 International License. CC BY 4.0
Please provide credit where credit is due. You must credit the following people listed below. You can find this information in the project’s readme.
(https://creativecommons.org/licenses/by/4.0/) 

**Main Menu by ZioYuri78:**
The basic menu framework is an adaptation of ZioYuri78’s ‘Main menu and in game menu with basic game, graphics, controls and audio settings.’
(https://forums.unrealengine.com/showthread.php?103583-C-Blueprint-Main-menu-and-in-game-menu-with-basic-game-graphics-controls-and-audio-settings)

**Online Browser by mordentral:**
The online browser utilizes mordentral’s Advanced Sessions Plugin.
(https://forums.unrealengine.com/showthread.php?69901-Advanced-Sessions-Plugin)

**Rebindable Keys by rama:**
The key binding system utilizes Rama’s UMG Rebindable Key System, Rebind keys at Runtime.
(https://forums.unrealengine.com/showthread.php?51449-Full-Project-Rama-s-UMG-Rebindable-Key-System-Rebind-keys-at-Runtime!)

**Background Music by The Tune Peddler:**
The music used in this project is owned by The Tune Peddler. You do not have permission to use the project’s music without agreeing to the terms at The Tune Peddler’s website. (As of July 2016, this includes a $5 a month subscription fee.)
(http://thetunepeddler.com/)

**Graphics Settings Widget by Mathew Wadstein:**
The graphics setting widget was adapted from Mathew Wadstein's Blueprint Only Video Settings Menu.
(https://www.youtube.com/watch?v=U_nCvY1OsdE)

**Gamepad-Friendly UMG by rama:**
The Gamepad-Friendly UMG plugin was put together bry RAMA.
(https://forums.unrealengine.com/showthread.php?86981-Gamepad-Friendly-UMG-Control-Cursor-with-Gamepad-Analog-Stick!-Easily-Click-Buttons!)

--------------------------------------------
How To Donate
--------------------------------------------
If we achieve nonprofit status, we will provide written (emailed) donor acknowledgment letters to those who donate $250 or more to our organization as required by the IRS. 
Our apologies to donors outside of the United States. We will not be able to provide you with any tax benefits for donating to our organization.

#### This will include
> The corporate name and EIN of our organization
> The name of the donor as it appears on PayPal
> The date and ammount of the contribution
> A statement that our organization is a valid 501c3 organization
> An affirmation that no goods or services were provided to the donor
> And information about how your donation was used

Thank you,
[Donate Through Paypal Here](https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=MSXKLJFLLEVR6)

--------------------------------------------
License Information
--------------------------------------------
The Menu System Was Adapted From Cardinal Fall: ©2016 Nonprofit Videogame Development Group, Inc.  All rights reserved.  
This Menu System is free to use under the Creative Commons Attribution 4.0 International License. CC BY 4.0 (https://creativecommons.org/licenses/by/4.0/) 3rd Party Assets are discussed in the credits section above.


