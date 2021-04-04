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
pSkill = player skill stat
pTotalEarned = total money the player has earned
vPayment = vehicle payment per-room
ePayment = education payment per-room
eIncrease = player salary increase per-room
sQuality = video quality setting

Tasks in progress:
---
	
Tasks to-do:
---
>>Milestone 8: Graphics and Sound
	>2J: Final Models
		4/4/2021 {
		-Floor (fix import)
		-Wall Block Lower
		-Wall Block Upper
		-Random Block Lower
		-Random Block Upper
		-Exit Door
		-Item Pickup
		}
		4/5/2021 {
		-Enemy Weapon: Appliance Replacement
		-Enemy Weapon: Car Insurance
		-Enemy Weapon: Car Repairs
		-Enemy Weapon: Electricity Bill
		-Enemy Weapon: Flood Damage
		-Enemy Weapon: Groceries
		-Enemy Weapon: Heating Bills
		-Enemy Weapon: Entertainment
		-Enemy Weapon: Holiday Shopping
		-Enemy Weapon: New Tires
		-Enemy Weapon: Renovations
		-Enemy Weapon: Roof Damage
		-Enemy Weapon: Tank of Gas
		-Enemy Weapon: Water Bill
		}
		4/6/2021 {
		-Player Weapon
		-Player Character
		-Enemy Character
		}
	>2K: Final Effects
		4/7/2021 {
		-Fog/lighting (incl. final lighting build in all levels)
		}
		4/8/2021 {
		-Footstep dust
		-Player attacking enemy
		-Enemy attacking player
		-Enemy being defeated
		-Item pickup
		}
	4/9/2021 {
	>2M: Final Sounds + Music
	}
	4/10/2021 {
	>2L: Final Animations
	}
>>Milestone 9: Final Tweaks 
	4/11/2021 {
	>2V: Pause button icon
	>2N: R/P/S rules on combat screen for reference (K -> S -> P)
	>2O: Color text shown on hit/miss during 
	>2P: Bug fix: player losing game during combat if negative
	>2Q: Bug fix: two enemies attacking player at once
	}
	4/12/2021 {
	>2R: Invisible surrounding blocks during combat
	>2T: Show job name on intro
	>2S: Final playthrough/numbers tweak
	>2U: Level # and preparation increase shown for cars
	}
4/13/2021 {
>>Milestone 10: itch.io PC
	>3A: Gather all screenshots, info and media for itch.io
	>3F: Build game
	>3B: Publish on itch.io
}
>>Milestone 11: itch.io Android
	4/14/2021 {
	>3G: Create separate branch for Android port
	>3C: Test Android port on emulator
	}
	4/15/2021 {
	>3D: Test Android port tethered or sideloaded
	>3F: Build game
	>3E: Add APK to itch.io page
	}

4/16/2021 {
>>Update and submit paper
}

Post-graduation update tasks:
---
>>Milestone 11: Hub and Upgrades
	>2G: Hub + Money Saving
	>2H: Upgrades with in-game effects
	>2I: Cosmetic Upgrades
	>2J: Confirm quit/main menu
	>2D: Add UI graphics
	>2E: Obstacle Climbing
	>2F: Obstacle Variety
>>Milestone 12: Expanded controls
	>4A: WASD/Controller support for gameplay
	>4B: Controller support for menu and UI
	>4C: Show recent transactions as a pop-up above money
	>4I: Expanded video settings (individual graphics, resolution, etc)
>>Milestone 13: Infinite run
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
>>Another enemy can attack player while player is already in combat

Know Low Priority Issues:
---
>>Cursor type does not change to normal mouse when combat HUD appears
>>Camera can sometimes overlap blocks and cause issues (make blocks around combat invisible, set player position on start)
>>Audio setting does not save between sessions