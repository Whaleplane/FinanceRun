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

Tasks
------
>>Milestone 8: Graphics and Sound
	4/15/2021 {
	>2M: Final Sounds + Music
	>2L: Player attack/damaged animation
	}
>>Milestone 9: Final Tweaks
	4/16/2021 {
	>2V: Pause button icon
	>2N: R/P/S rules on combat screen for reference (K -> S -> P)
	>2P: Bug fix: player losing game during combat if negative
	>2Q: Bug fix: two enemies attacking player at once
	}
	4/17/2021 {
	>2R: Invisible surrounding blocks during combat
	>2T: Show job name on intro
	>2S: Final playthrough/numbers tweak
	>2U: Level # and preparation increase shown for cars
	}
4/18/2021 {
>>Milestone 10: itch.io PC
	>3A: Gather all screenshots, info and media for itch.io
	>3F: Build game
	>3B: Publish on itch.io
>>Milestone 11: itch.io Android
	>3G: Create separate branch for Android port
	>3C: Test Android port on emulator
	>3D: Test Android port tethered or sideloaded
	>3F: Build game
	>3E: Add APK to itch.io page
 }

	
Known High Priority Issues:
---
>>Player does not immediately lose game when going negative in combat
>>Another enemy can attack player while player is already in combat

Know Low Priority Issues:
---
>>Cursor type does not change to normal mouse when combat HUD appears
>>Camera can sometimes overlap blocks and cause issues (make blocks around combat invisible, set player position on start)
>>Audio setting does not save between sessions