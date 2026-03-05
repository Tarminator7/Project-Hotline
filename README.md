# To-Do List:
- Main Menu
- Pause menu

# Top-down shooter plan

## Top-down shooter – Game Design Overview

### Main Game Design Elements

Objective (Win Condition)
- Destroy all enemies to clear the stage.
- Clear all the stages to win the game.

Optional secondary goals:
- Clear fast as possible.

Game Over (Lose Condition):
The player dies from an enemy attack.

### Main Mechanics

The player reaches the objective by destroying all the enemies on the stage.
- Movement: Up / down for forward and backward movement. Left / Right for strafing movement.
- Mouse: For turning the character and targeting with weapon.
- If the player dies, the player must start at the beginning of the game.

### Project Phases & Role Distribution (4 Weeks)

#### Week 1 - Prototyping core gameplay

Focus: Core mechanics

Tasks:
- Player movement (forward, back, strafing)
- Mouse movement (turning character, targeting with weapon)
- Basic collision detection
- Camera following the player
- Basic level
- Adding assets

Responsibilities:
- Joni: Level design / enemy placement / camera script / flexible
- Taro: Player controller, mouse movement, collision detection

#### Week 2 - Working core gameplay loop

Focus: Working gameplay loop

Tasks:
- Adding enemy AI
- Adding win condition to clear the stage
- Adding transition to the player moving to new stage
- Adding new stages

Responsibilities:
- Joni: New stages, stage to stage transition script
- Taro: Enemy AI script, stage win condition script

#### Week 3 – Improving the game &  adding new mechanics

Focus: Improve the game

Tasks:
- Shop
- Character / weapon upgrade system
- Grading system to earn money / points

Responsibilities:
- Joni: Grading system, shop
- Taro: Upgrade system, shop

#### Week 4 – Testing, polish & bug fixing

Focus: Stability and bug free

Tasks:
- Playtesting and difficulty tuning
- Bug fixing
- Performance
