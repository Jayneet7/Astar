# Astar
Ai 2020 pathfinding


The whole project contains following files.

Maretrials

This folder contains unity materials for the ojects have basic properties like colour and shaders.

Scenes

This folder contains diffrents scece where i impliment the diffrent AI.
	
Patrol
Contains the navmesh for the scene followplayer map.
	
Astar pathfinding

This scene contains the astar implimetation withing a simple map.

Followplayer

This scene contain An ai that follows player. This is done by baking a navigation area on the objects/map.

Learing

This scece contains an ai that keep perticular distance with the player. if player goes to far Ai start following the player and if player comes too close Ai will go in the oposite direction.

Patrol

This scene contain a implimentation of simple patrol ai. Where the object run a set point on the map and stay there for 2 sec then move to the next point on the map.

Scritps 
this folder contains 4 diffrent scripts 

Enemy

	This script conected with Enemy onject in learing scene. contains information about following player also have some personalization options such as enemy speed, stopdistance retreatdistance.

Followplayer

	This scrit is attached with Ai_playerfollow object. Also have option to change the target to follow.

PatrolAi

	This scrit is attached with the Ai_player object in Patrol scene. Also have option to change the location and size of the patrol points on the map.

Playermove
	
	Simple player move script attached with the player in followplayer scene and also in the Learning scene. It has a basic script to control the object with simple keyboard inputs.


Scripts 2 

	This folder contains 6 diffrent scripts those are used for implimeting the A* algorithm in the Astar pathfinding scene.

1 Grid
	This script is used to make gizmos to visualize the grid on the are the you wnat to cover up. and other information like unwalkable mask. where we want to put obsticales on the area. have public variable s like grid world size and node size. 

2 heap

	This script is a c# scrit have not attached with any object rather it used in the pathfinding script to find optimal path nodes on the gird.

3 Node

	This script is used in the grid for establish nodes and in the heap script to manipulate costs of the diffrent nodes.
	
4 pathfinding
	
	This script is used to establish the optimal path on the grid. with diffrent fuction to calculate the values of nodes.

5 pathfindingRequestManager

	This script is used to manage multiple request from diffrent node for establishing optimal path.

6 Units
	This script is attaced with all the units that you want to make a path. also have gizmos to visualize the evaluation process on the map.






