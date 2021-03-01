Finance Run
For Capitol Technology University Senior Project (CS-457)
Developed by Jeremy Neville

Engine: Unreal Engine 4 (4.24.3)

-----------------------------------------------------------------------------

Current stage: working on minimum viable product
All milestones must be completed by 4/18/2021
Last milestone scheduled for 4/1/2021, ~2.5 weeks of buffer

Data being saved:
pMoney = player money
pVehicle = player vehicle stat
pTotalEarned = total money the player has earned
vPayment = vehicle payment per-room
ePayment = education payment per-room
eIncrease = player salary increase per-room

Tasks in progress:
---
>>Milestone 5: MVP complete (2/28/2021)
	>J: Wandering/chasing enemies
		-In enemy BP: add AI perception
			-on target perception updated: if percieved actor is player, update target actor
		-On combat: in attack range decorator

Tasks to-do:
---
>>Milestone 5: MVP complete (2/28/2021)
	>L: Enemy Combat (including loss event), randomized enemy instances from class
	>K: Item pickups + Inventory
>>Milestone 6: Complete Menus (3/9/2021)
	>A: Main Menu
	>B: Pause Menu
	>C: Settings Menu
	>D: UI Elements (incl. loading screen)
	>O: Random job selection w/ education choices
	>P: Rundown of per-room payments and increase in intros
>>Milestone 7: Obstacle Adjustments (3/12/2021)
	>E: Obstacle Climbing
	>F: Obstacle Variety
>>Milestone 8: Hub and Upgrades (3/19/2021)
	>G: Hub + Money Saving
	>H: Upgrades with in-game effects
	>I: Cosmetic Upgrades with placeholder models
>>Milestone 9: Graphics and Sound (4/4/2021)
	>J: Final Models
	>K: Final Textures
	>L: Final Animations
	>M: Final Sounds + Music
>>Milestone 10: itch.io PC (4/9/2021)
	>A: Gather all screenshots, info and media for itch.io
	>B: Publish on itch.io
>>Milestone 11: itch.io Android (4/18/2021)
	>C: Test Android port on emulator
	>D: Test Android port tethered or sideloaded

-
At this point, the game will need to be evaluated and tested,
I may decide that more post-graudation content and polish is 
required for Steam and Google Play. Itch.io is the minimum release
for class project purposes.
-

>>Milestone 11: Steam
	>C: Find criteria of Steam release
	>D: Add API for Steam (if necessary)
	>E: Gather all screenshots, info and media for Steam
	>F: Publish on Steam
>>Milestone 12: Google Play
	>G: Find criteria of Google Play release
	>H: Add Google Play API (if necessary)
	>I: Gather all screenshots, info and media for Google Play
	>J: Publish on Google Play
	
Post-release update tasks:
---
>>Milestone 13: Expanded controls
	>A: WASD/Controller support for gameplay
	>B: Controller support for menu and UI
>>Milestone 14: Infinite run
	>C: Log journal - UI piece to show recent transactions
	>D: Infinite run mode on-paper details
	>E: Implement infinite run mode
	
Tasks complete:
---
>>Milestone 1: Fully functional player
	>B: Player Movement
	>C: Player Interaction + interactable item abstract class with test functionality
	>D: Player $ + HUD
>>Milestone 2: Complete levels
	>E: Randomized Rooms
	>F: Room 1-10 progression with door and per-room salary + saving between rooms
>>Milestone 3: Stats added 
	>A: List meta info (enemies, education, vehicles, items, stats)
	>G: Initial player stats assignment on room 1 + saving between rooms
>>Milestone 4: Vehicles, Education, and Retirement 
	>H: Vehicle menu + math + debt (with stat effect)
	>I: Education menu + math + debt (with salary effect)
	>M: Retirement screens + math