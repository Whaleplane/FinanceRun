Finance Run
For Capitol Technology University Senior Project (CS-457)
Developed by Jeremy Neville

Engine: Unreal Engine 4 (4.24.3)

-----------------------------------------------------------------------------

Current stage: working on minimum viable product
All milestones must be completed by 4/18/2021

Data being saved:
pMoney = player money
pPreparation = player preparation stat
pKnowledge = player knowledge stat
pTotalEarned = total money the player has earned
vPayment = vehicle payment per-room
ePayment = education payment per-room
eIncrease = player salary increase per-room

Tasks in progress:
---
>>Milestone 6: Complete Menus (3/28/2021)
	>2O: Random job selection w/ education choices
		-Base per-room salary on data table
		-Base education cost on data table
		-Base salary increase on data table
		-Disable reject button if education is required
		-Show (required) next to "Increase: 0" if education is required
	>2P: Rundown of per-room payments and increase in intros
	>2C: Options Menu
		-Audio volume
		-General video quality
		-Video resolution/screen size
	>2A: Main Menu
		-Start game
		-Options
		-Quit
	>2B: Pause Menu
		-Pause button on-screen
		-Resume
		-Options
		-Main Menu
	>2E: Extra menu parts
		-R/P/S rules on combat screen for reference
		-Enemy name on screen during combat
		-Color text shown on hit/miss during combat
		-Show potential salary increase on education menu
		-Show salary per-room on popup
		-Show additional salary increase on popup
		-Show per-room payments on popup
	>2D: Graphical UI Elements (incl. loading screen)
	
Tasks to-do:
---
>>Milestone 7: Obstacle Adjustments (3/31/2021)
	>2E: Obstacle Climbing
	>2F: Obstacle Variety
>>Milestone 8: Hub and Upgrades (4/4/2021)
	>2G: Hub + Money Saving
	>2H: Upgrades with in-game effects
	>2I: Cosmetic Upgrades with placeholder models
>>Milestone 9: Graphics and Sound (4/14/2021)
	>2J: Final Models
	>2K: Final Textures
	>2L: Final Animations
	>2M: Final Sounds + Music
>>Milestone 10: itch.io PC (4/16/2021)
	>3A: Gather all screenshots, info and media for itch.io
	>3B: Publish on itch.io
>>Milestone 11: itch.io Android (4/18/2021)
	>3C: Test Android port on emulator
	>3D: Test Android port tethered or sideloaded
	>3E: Add APK to itch.io page

Post-graduation update tasks:
---
>>Milestone 12: Expanded controls
	>4A: WASD/Controller support for gameplay
	>4B: Controller support for menu and UI
>>Milestone 13: Infinite run
	>4C: Log journal - UI piece to show recent transactions
	>4D: Infinite run mode on-paper details
	>4E: Implement infinite run mode
>>Milestone 14: Expanded graphics and extras
	>4F: Weather and lighting changes per level
	>4G: Items can spawn on base blocks
	>4H: Individual selectable campaigns for each job
>>Milestone 15: Steam
	>5C: Find criteria of Steam release
	>5D: Add API for Steam (if necessary)
	>5E: Gather all screenshots, info and media for Steam
	>5F: Publish on Steam
>>Milestone 16: Google Play
	>5G: Find criteria of Google Play release
	>5H: Add Google Play API (if necessary)
	>5I: Gather all screenshots, info and media for Google Play
	>5J: Publish on Google Play
	
Known High Priority Issues:
---
>>Player does not immediately lose game when going negative in combat

Know Low Priority Issues:
---
>>Cursor type does not change to normal mouse when combat HUD appears 
>>Stats HUD overlaps with popups
>>Enemies float during popup
>>Camera can sometimes overlap blocks and cause issues (make blocks around combat invisible, set player position on start)
