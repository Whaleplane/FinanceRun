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
pTotalEarned = total money the player has earned
vPayment = vehicle payment per-room
ePayment = education payment per-room
eIncrease = player salary increase per-room

Tasks in progress:
---
>>Milestone 5: MVP complete (3/21/2021)
	>K: Item pickups
		-All stats loaded/reset at begin play
		-Items increment stats (based on randomized effect) and save stat

Tasks to-do:
---
>>Full gameplay test of MVP
>>Milestone 6: Complete Menus (3/28/2021)
	>2A: Main Menu
	>2B: Pause Menu
	>2C: Settings Menu
	>2D: UI Elements (incl. loading screen)
		-R/P/S rules on combat screen for reference
		-Color text shown on hit/miss during combat
	>2O: Random job selection w/ education choices
	>2P: Rundown of per-room payments and increase in intros
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
	
Known Issues:
---
>>Cursor type does not change to normal mouse when combat HUD appears
>>Player sometimes too close to enemy
	>Make a "player stand" position in the enemy BP and move the player to it
>>Another enemy can attack the player while already in combat
>>Player AI can get stuck when surrounded by blocks on all 3 sides