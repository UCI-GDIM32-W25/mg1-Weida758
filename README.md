[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## Devlog
1. Weida Chen, he/him
2. The code I wrote is pretty consistent with the plan inside of the google doc that plans out MG1. We have a player class which controls what the player is able to do, more specifically, moving and planting seeds. We put the movement and planting seed input codes inside the Update method so the game can continuously detect our player inputs and react accordingly. Pressing space calls the PlantSeed() method which instantiates a seed prefab that consists of a sprite renderer component and nothing else. The method also updates the internal seed left and seed planted data that the player records, so that these data can be sent to the PlantCountUI class in the UpdateSeeds method to update the text components that are referenced in the script. 


## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites
